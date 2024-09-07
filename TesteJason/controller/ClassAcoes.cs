using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteJason.controller
{
    class ClassAcoes
    {
        public void AlteraGrid(DataGridView dataGridView1, RadioButton RbDetalhado)
        {
            if (RbDetalhado.Checked)
            {
                // Mudar os nomes das colunas quando o CheckBox estiver marcado
                dataGridView1.Columns[0].HeaderText = "Data da venda";
                dataGridView1.Columns[1].HeaderText = "Hora da venda";
                dataGridView1.Columns[2].HeaderText = "Status da venda";
                dataGridView1.Columns[3].HeaderText = "Data da venda";
                dataGridView1.Columns[4].HeaderText = "valor da venda original";
                dataGridView1.Columns[5].HeaderText = "valor da venda atualizado";
                dataGridView1.Columns[6].HeaderText = "modalidade";
                dataGridView1.Columns[7].HeaderText = "tipo";
                dataGridView1.Columns[8].HeaderText = "número de parcelas";
                dataGridView1.Columns[9].HeaderText = "bandeira";
                dataGridView1.Columns[10].HeaderText = "taxa MDR";
                dataGridView1.Columns[11].HeaderText = "valor MDR";
                dataGridView1.Columns[12].HeaderText = "taxa de recebimento automático";
                dataGridView1.Columns[13].HeaderText = "valor taxa de recebimento automático";
                dataGridView1.Columns[14].HeaderText = "taxas descontadas (MDR+recebimento automático)";
                dataGridView1.Columns[15].HeaderText = "valor total das taxas descontadas (MDR+recebimento automático)";
                dataGridView1.Columns[16].HeaderText = "NSU/CV";
                dataGridView1.Columns[17].HeaderText = "Prazo de recebimento";
                dataGridView1.Columns[18].HeaderText = "resumo de vendas/número do lote";
                dataGridView1.Columns[19].HeaderText = "número da autorização (Auto)";
                dataGridView1.Columns[20].HeaderText = "número do estabelecimento";
                dataGridView1.Columns[21].HeaderText = "nome do estabelecimento";
                dataGridView1.Columns[22].HeaderText = "CNPJ";
                dataGridView1.Columns[23].HeaderText = "número do cartão";
                dataGridView1.Columns[24].HeaderText = "id carteira digital";
                dataGridView1.Columns[25].HeaderText = "meio de pagamento";
                dataGridView1.Columns[26].HeaderText = "tipo de maquininha";
                dataGridView1.Columns[27].HeaderText = "código da maquininha";
                dataGridView1.Columns[28].HeaderText = "TID";
                dataGridView1.Columns[29].HeaderText = "número do pedido";
                dataGridView1.Columns[30].HeaderText = "taxa de embarque";
                dataGridView1.Columns[31].HeaderText = "cancelada pelo estabelecimento";
                dataGridView1.Columns[32].HeaderText = "data do cancelamento";
                dataGridView1.Columns[33].HeaderText = "valor cancelado";
                dataGridView1.Columns[34].HeaderText = "em disputa de chargeback";
                dataGridView1.Columns[35].HeaderText = "data que entrou em disputa de chargeback";
                dataGridView1.Columns[36].HeaderText = "resolução do chargeback";
                dataGridView1.Columns[37].HeaderText = "data da resolução do chargeback";
                dataGridView1.Columns[38].HeaderText = "nacionalidade do cartão";
                dataGridView1.Columns[39].HeaderText = "moeda estrangeira (DCC)";
                dataGridView1.Columns[40].HeaderText = "cartão pré-pago";
            }
            else
            {
                // Mudar os nomes das colunas quando o CheckBox estiver desmarcado
                dataGridView1.Columns[0].HeaderText = "Data da venda";
                dataGridView1.Columns[1].HeaderText = "Modalidade";
                dataGridView1.Columns[2].HeaderText = "Bandeira";
                dataGridView1.Columns[3].HeaderText = "Quantidade de vendas";
                dataGridView1.Columns[4].HeaderText = "Total bruto do dia";
                dataGridView1.Columns[5].HeaderText = "Taxas do dia";
                dataGridView1.Columns[6].HeaderText = "Total líquido do dia";
                dataGridView1.Columns[7].HeaderText = "Total de desagendamentos";
                dataGridView1.Columns[8].HeaderText = "Parcela";
                dataGridView1.Columns[9].HeaderText = "Data de recebimento";
                dataGridView1.Columns[10].HeaderText = "Antecipado para";
                dataGridView1.Columns[11].HeaderText = "Total das parcelas";
                dataGridView1.Columns[12].HeaderText = "Status";

            }
        }
    }
}
