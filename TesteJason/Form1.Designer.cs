namespace TesteJason
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInportar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datadavenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horadavenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdavenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordavendaoriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordavendaatualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerodeparcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaMDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorliquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSUCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prazoderecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntCaminho = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblAgendado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRede = new System.Windows.Forms.RadioButton();
            this.rbGetNet = new System.Windows.Forms.RadioButton();
            this.RbParcVend = new System.Windows.Forms.RadioButton();
            this.RbDetalhado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInportar
            // 
            this.btnInportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInportar.Location = new System.Drawing.Point(1421, 77);
            this.btnInportar.Name = "btnInportar";
            this.btnInportar.Size = new System.Drawing.Size(75, 23);
            this.btnInportar.TabIndex = 0;
            this.btnInportar.Text = "Importar";
            this.btnInportar.UseVisualStyleBackColor = true;
            this.btnInportar.Click += new System.EventHandler(this.btnInportar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datadavenda,
            this.horadavenda,
            this.statusdavenda,
            this.valordavendaoriginal,
            this.valordavendaatualizado,
            this.modalidade,
            this.tipo,
            this.numerodeparcelas,
            this.bandeira,
            this.taxaMDR,
            this.valorMDR,
            this.valorliquido,
            this.NSUCV,
            this.Prazoderecebimento});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1510, 719);
            this.dataGridView1.TabIndex = 4;
            // 
            // datadavenda
            // 
            this.datadavenda.HeaderText = "Data da venda";
            this.datadavenda.Name = "datadavenda";
            this.datadavenda.ReadOnly = true;
            // 
            // horadavenda
            // 
            this.horadavenda.HeaderText = "Hora da venda";
            this.horadavenda.Name = "horadavenda";
            this.horadavenda.ReadOnly = true;
            // 
            // statusdavenda
            // 
            this.statusdavenda.HeaderText = "Status da venda";
            this.statusdavenda.Name = "statusdavenda";
            this.statusdavenda.ReadOnly = true;
            // 
            // valordavendaoriginal
            // 
            this.valordavendaoriginal.HeaderText = "Valor da venda original";
            this.valordavendaoriginal.Name = "valordavendaoriginal";
            this.valordavendaoriginal.ReadOnly = true;
            // 
            // valordavendaatualizado
            // 
            this.valordavendaatualizado.HeaderText = "Valor da venda atualizado";
            this.valordavendaatualizado.Name = "valordavendaatualizado";
            this.valordavendaatualizado.ReadOnly = true;
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            this.modalidade.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // numerodeparcelas
            // 
            this.numerodeparcelas.HeaderText = "Número de parcelas";
            this.numerodeparcelas.Name = "numerodeparcelas";
            this.numerodeparcelas.ReadOnly = true;
            // 
            // bandeira
            // 
            this.bandeira.HeaderText = "Bandeira";
            this.bandeira.Name = "bandeira";
            this.bandeira.ReadOnly = true;
            // 
            // taxaMDR
            // 
            this.taxaMDR.HeaderText = "Taxa MDR";
            this.taxaMDR.Name = "taxaMDR";
            this.taxaMDR.ReadOnly = true;
            // 
            // valorMDR
            // 
            this.valorMDR.HeaderText = "Valor MDR";
            this.valorMDR.Name = "valorMDR";
            this.valorMDR.ReadOnly = true;
            // 
            // valorliquido
            // 
            this.valorliquido.HeaderText = "Valor líquido";
            this.valorliquido.Name = "valorliquido";
            this.valorliquido.ReadOnly = true;
            // 
            // NSUCV
            // 
            this.NSUCV.HeaderText = "NSU/CV";
            this.NSUCV.Name = "NSUCV";
            this.NSUCV.ReadOnly = true;
            // 
            // Prazoderecebimento
            // 
            this.Prazoderecebimento.HeaderText = "Prazo de recebimento";
            this.Prazoderecebimento.Name = "Prazoderecebimento";
            this.Prazoderecebimento.ReadOnly = true;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(121, 80);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(508, 20);
            this.txtCaminho.TabIndex = 5;
            this.txtCaminho.Text = "E:\\Download\\Rede_Rel_Data_Das_Parcelas_Das_Vendas_2024_08_13-2024_08_19-b9d2049b-" +
    "7248-4e8c-b01c-55554b5aa380.xlsx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caminho da Planilha";
            // 
            // bntCaminho
            // 
            this.bntCaminho.Location = new System.Drawing.Point(635, 78);
            this.bntCaminho.Name = "bntCaminho";
            this.bntCaminho.Size = new System.Drawing.Size(32, 23);
            this.bntCaminho.TabIndex = 7;
            this.bntCaminho.Text = "...";
            this.bntCaminho.UseVisualStyleBackColor = true;
            this.bntCaminho.Click += new System.EventHandler(this.bntCaminho_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGetNet);
            this.groupBox1.Controls.Add(this.rbRede);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adquirentes";
            // 
            // lblPago
            // 
            this.lblPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(15, 954);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(32, 13);
            this.lblPago.TabIndex = 9;
            this.lblPago.Text = "Pago";
            // 
            // lblAgendado
            // 
            this.lblAgendado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAgendado.AutoSize = true;
            this.lblAgendado.Location = new System.Drawing.Point(530, 954);
            this.lblAgendado.Name = "lblAgendado";
            this.lblAgendado.Size = new System.Drawing.Size(56, 13);
            this.lblAgendado.TabIndex = 10;
            this.lblAgendado.Text = "Agendado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(708, 81);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(71, 20);
            this.txtData.TabIndex = 12;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 831);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(265, 120);
            this.txtResultado.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbParcVend);
            this.groupBox2.Controls.Add(this.RbDetalhado);
            this.groupBox2.Location = new System.Drawing.Point(172, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 63);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Relatório";
            // 
            // rbRede
            // 
            this.rbRede.AutoSize = true;
            this.rbRede.Checked = true;
            this.rbRede.Location = new System.Drawing.Point(6, 29);
            this.rbRede.Name = "rbRede";
            this.rbRede.Size = new System.Drawing.Size(51, 17);
            this.rbRede.TabIndex = 0;
            this.rbRede.TabStop = true;
            this.rbRede.Text = "Rede";
            this.rbRede.UseVisualStyleBackColor = true;
            // 
            // rbGetNet
            // 
            this.rbGetNet.AutoSize = true;
            this.rbGetNet.Location = new System.Drawing.Point(74, 29);
            this.rbGetNet.Name = "rbGetNet";
            this.rbGetNet.Size = new System.Drawing.Size(57, 17);
            this.rbGetNet.TabIndex = 1;
            this.rbGetNet.Text = "Getnet";
            this.rbGetNet.UseVisualStyleBackColor = true;
            // 
            // RbParcVend
            // 
            this.RbParcVend.AutoSize = true;
            this.RbParcVend.Location = new System.Drawing.Point(95, 29);
            this.RbParcVend.Name = "RbParcVend";
            this.RbParcVend.Size = new System.Drawing.Size(161, 17);
            this.RbParcVend.TabIndex = 3;
            this.RbParcVend.Text = "Data das Parcelas de Venda";
            this.RbParcVend.UseVisualStyleBackColor = true;
            // 
            // RbDetalhado
            // 
            this.RbDetalhado.AutoSize = true;
            this.RbDetalhado.Checked = true;
            this.RbDetalhado.Location = new System.Drawing.Point(6, 29);
            this.RbDetalhado.Name = "RbDetalhado";
            this.RbDetalhado.Size = new System.Drawing.Size(83, 17);
            this.RbDetalhado.TabIndex = 2;
            this.RbDetalhado.TabStop = true;
            this.RbDetalhado.Text = "Detatalhado";
            this.RbDetalhado.UseVisualStyleBackColor = true;
            this.RbDetalhado.CheckedChanged += new System.EventHandler(this.RbDetalhado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 976);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAgendado);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntCaminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInportar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInportar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCaminho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblAgendado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadavenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn horadavenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdavenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordavendaoriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordavendaatualizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodeparcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaMDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorliquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSUCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prazoderecebimento;
        private System.Windows.Forms.RadioButton rbGetNet;
        private System.Windows.Forms.RadioButton rbRede;
        private System.Windows.Forms.RadioButton RbParcVend;
        private System.Windows.Forms.RadioButton RbDetalhado;
    }
}

