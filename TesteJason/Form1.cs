using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TesteJason.cep;
using TesteJason.controller;

namespace TesteJason
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInportar_Click(object sender, EventArgs e)
        {
            ImportExcel excel = new ImportExcel();
            if (rbRede.Checked)
            {
                string filePath = txtCaminho.Text;

                if (!string.IsNullOrEmpty(filePath))
                {
                    excel.ImportRede(filePath, dataGridView1);
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um arquivo Excel da " + "REDE" + " primeiro.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                string filePath = txtCaminho.Text;

                if (!string.IsNullOrEmpty(filePath))
                {
                    excel.ImportGetnet(filePath, dataGridView1);
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um arquivo Excel da " + "Getnet" + " primeiro.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            AtualizarTotalLiquido();

        }

        private void bntCaminho_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Pega o caminho completo do arquivo selecionado
                    string filePath = openFileDialog.FileName;
                    // Exibe o caminho no TextBox
                    txtCaminho.Text = filePath;
                }
            }
        }

        private void AtualizarValorLiquidoRecebido()
        {
            // Obtém a data do TextBox
            DateTime? dataRecebimentoDesejada = DateTime.Parse(txtData.Text);

            // Se a data for válida
            if (dataRecebimentoDesejada.HasValue)
            {
                decimal totalLiquido = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DateTime dataRecebimento;
                        // Tenta converter o valor da célula para DateTime
                        if (DateTime.TryParse(row.Cells["recebimento"].Value?.ToString(), out dataRecebimento))
                        {
                            // Verifica se a data é igual à data desejada
                            if (dataRecebimento.Date == dataRecebimentoDesejada.Value.Date)
                            {
                                decimal valorLiquido;
                                // Tenta converter o valor da célula para decimal
                                if (decimal.TryParse(row.Cells["liquido"].Value?.ToString().Replace("R$", ""), out valorLiquido))
                                {
                                    totalLiquido += valorLiquido; // Soma o valor líquido
                                }
                            }
                        }
                    }
                }

                // Atualiza o Label com o valor total líquido recebido para a data especificada
                lblPago.Text = $"Total Líquido Recebido: R$ {totalLiquido:N2}";
            }
        }
        private void AtualizarTotalLiquido()
        {

            decimal totalLiquido = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string status = row.Cells["status"].Value?.ToString();
                    if (status == "Paga")
                    {
                        string valorString = row.Cells["liquido"].Value?.ToString();

                        // Remove o cifrão, se presente
                        string valorSemCifrao = valorString.Replace("R$ ", "").Trim();

                        // Converte para decimal
                        decimal valor;
                        if (decimal.TryParse(valorSemCifrao.Replace("R$", ""), out valor))
                        {
                            totalLiquido += valor;
                        }
                    }
                }
            }

            lblPago.Text = $"Recebido: R$ {totalLiquido:N2}";
            lblPago.ForeColor = Color.Green;
        }
        public void filtro(DateTime dataRecebimentoDesejada)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    DateTime dataRecebimento;
                    // Tenta converter o valor da célula para DateTime
                    if (DateTime.TryParse(row.Cells["recebimento"].Value?.ToString(), out dataRecebimento))
                    {
                        // Verifica se a data é igual à data desejada
                        if (dataRecebimento.Date == dataRecebimentoDesejada.Date)
                        {
                            row.Visible = true; // Mostra a linha se a data for igual
                        }
                        else
                        {
                            row.Visible = false; // Oculta a linha se a data não for igual
                        }
                    }
                    AtualizarTotalLiquido();
                }
            }
        }

        public void Teste()
        {
            // Dicionário para armazenar as somas dos valores líquidos por dia
            Dictionary<DateTime, decimal> totalPorDia = new Dictionary<DateTime, decimal>();

            // Itera sobre cada linha no DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    DateTime dataRecebimento;
                    decimal valorLiquido;

                    // Verifica se o status da linha é "Paga"
                    if (row.Cells["status"].Value?.ToString() == "Paga")
                    {
                        // Tenta converter o valor da célula de DataRecebimento para DateTime
                        if (DateTime.TryParse(row.Cells["recebimento"].Value?.ToString(), out dataRecebimento))
                        {
                            // Tenta converter o valor da célula de ValorLiquido para decimal
                            if (decimal.TryParse(row.Cells["liquido"].Value?.ToString().Replace("R$",""), out valorLiquido))
                            {
                                // Verifica se a data já existe no dicionário
                                if (totalPorDia.ContainsKey(dataRecebimento.Date))
                                {
                                    // Se a data já existir, soma o valor líquido ao total
                                    totalPorDia[dataRecebimento.Date] += valorLiquido;
                                }
                                else
                                {
                                    // Se a data não existir, adiciona uma nova entrada no dicionário
                                    totalPorDia[dataRecebimento.Date] = valorLiquido;
                                }
                            }
                        }
                    }
                }
            }

            // Exibe os resultados agrupados por dia
            txtResultado.Clear(); // Limpa a TextBox de resultado, se estiver usando uma
            foreach (var entry in totalPorDia)
            {
                // Exibe cada data e o total líquido correspondente
                txtResultado.AppendText($"Data: {entry.Key.ToShortDateString()} - Total Líquido: R$ {entry.Value:N2}" + "\r\n");
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {

              //  filtro(DateTime.Parse(txtData.Text));
            // AtualizarValorLiquidoRecebido();
            Teste();

            }

        private void RbDetalhado_CheckedChanged(object sender, EventArgs e)
        {
            ClassAcoes acoes = new ClassAcoes();
            acoes.AlteraGrid(dataGridView1, RbDetalhado);
        }
    }
    } 

