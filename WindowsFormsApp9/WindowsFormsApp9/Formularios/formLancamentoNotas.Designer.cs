namespace WindowsFormsApp9.Formularios
{
    partial class formLancamentoNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDataLancamentoNota = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblFornecedorLancamento = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.grpBoxEntradaMercadoria = new System.Windows.Forms.GroupBox();
            this.dataGridFornecedor = new System.Windows.Forms.DataGridView();
            this.cdgProdutoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdProdutoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGravarLancamento = new System.Windows.Forms.Button();
            this.lblEntradaDeMercadoria = new System.Windows.Forms.Label();
            this.grpBoxEntradaMercadoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // lblDataLancamentoNota
            // 
            this.lblDataLancamentoNota.AutoSize = true;
            this.lblDataLancamentoNota.Location = new System.Drawing.Point(70, 35);
            this.lblDataLancamentoNota.Name = "lblDataLancamentoNota";
            this.lblDataLancamentoNota.Size = new System.Drawing.Size(44, 20);
            this.lblDataLancamentoNota.TabIndex = 1;
            this.lblDataLancamentoNota.Text = "Data";
            this.lblDataLancamentoNota.Click += new System.EventHandler(this.lblDataLancamentoNota_Click);
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(520, 40);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(109, 20);
            this.lblNroDocumento.TabIndex = 3;
            this.lblNroDocumento.Text = "Nº Nota Fiscal";
            this.lblNroDocumento.Click += new System.EventHandler(this.lblNroDocumento_Click);
            // 
            // lblFornecedorLancamento
            // 
            this.lblFornecedorLancamento.AutoSize = true;
            this.lblFornecedorLancamento.Location = new System.Drawing.Point(246, 38);
            this.lblFornecedorLancamento.Name = "lblFornecedorLancamento";
            this.lblFornecedorLancamento.Size = new System.Drawing.Size(91, 20);
            this.lblFornecedorLancamento.TabIndex = 5;
            this.lblFornecedorLancamento.Text = "Fornecedor";
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(56, 58);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(166, 29);
            this.textBox15.TabIndex = 8;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(524, 63);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(167, 26);
            this.txtNroDocumento.TabIndex = 9;
            // 
            // grpBoxEntradaMercadoria
            // 
            this.grpBoxEntradaMercadoria.Controls.Add(this.dataGridFornecedor);
            this.grpBoxEntradaMercadoria.Controls.Add(this.label1);
            this.grpBoxEntradaMercadoria.Controls.Add(this.textBox1);
            this.grpBoxEntradaMercadoria.Controls.Add(this.btnGravarLancamento);
            this.grpBoxEntradaMercadoria.Controls.Add(this.textBox15);
            this.grpBoxEntradaMercadoria.Controls.Add(this.lblNroDocumento);
            this.grpBoxEntradaMercadoria.Controls.Add(this.txtNroDocumento);
            this.grpBoxEntradaMercadoria.Controls.Add(this.lblDataLancamentoNota);
            this.grpBoxEntradaMercadoria.Controls.Add(this.lblFornecedorLancamento);
            this.grpBoxEntradaMercadoria.Controls.Add(this.comboBox1);
            this.grpBoxEntradaMercadoria.Location = new System.Drawing.Point(240, 89);
            this.grpBoxEntradaMercadoria.Name = "grpBoxEntradaMercadoria";
            this.grpBoxEntradaMercadoria.Size = new System.Drawing.Size(773, 448);
            this.grpBoxEntradaMercadoria.TabIndex = 10;
            this.grpBoxEntradaMercadoria.TabStop = false;
            this.grpBoxEntradaMercadoria.Text = "Descrição da Nota";
            // 
            // dataGridFornecedor
            // 
            this.dataGridFornecedor.AllowUserToAddRows = false;
            this.dataGridFornecedor.AllowUserToDeleteRows = false;
            this.dataGridFornecedor.AllowUserToResizeColumns = false;
            this.dataGridFornecedor.AllowUserToResizeRows = false;
            this.dataGridFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdgProdutoEntrada,
            this.nomeProdutoEntrada,
            this.qtdProdutoEntrada});
            this.dataGridFornecedor.Location = new System.Drawing.Point(56, 145);
            this.dataGridFornecedor.MultiSelect = false;
            this.dataGridFornecedor.Name = "dataGridFornecedor";
            this.dataGridFornecedor.ReadOnly = true;
            this.dataGridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFornecedor.Size = new System.Drawing.Size(667, 217);
            this.dataGridFornecedor.TabIndex = 90;
            // 
            // cdgProdutoEntrada
            // 
            this.cdgProdutoEntrada.DataPropertyName = "cdgProdutoEntrada";
            this.cdgProdutoEntrada.HeaderText = "Cód do Produto";
            this.cdgProdutoEntrada.Name = "cdgProdutoEntrada";
            this.cdgProdutoEntrada.ReadOnly = true;
            this.cdgProdutoEntrada.Width = 160;
            // 
            // nomeProdutoEntrada
            // 
            this.nomeProdutoEntrada.DataPropertyName = "nomeProdutoEntrada";
            this.nomeProdutoEntrada.HeaderText = "Nome do Produto";
            this.nomeProdutoEntrada.Name = "nomeProdutoEntrada";
            this.nomeProdutoEntrada.ReadOnly = true;
            this.nomeProdutoEntrada.Width = 300;
            // 
            // qtdProdutoEntrada
            // 
            this.qtdProdutoEntrada.DataPropertyName = "qtdProdutoEntrada";
            this.qtdProdutoEntrada.HeaderText = "Quantidade";
            this.qtdProdutoEntrada.Name = "qtdProdutoEntrada";
            this.qtdProdutoEntrada.ReadOnly = true;
            this.qtdProdutoEntrada.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Código do Produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 26);
            this.textBox1.TabIndex = 88;
            // 
            // btnGravarLancamento
            // 
            this.btnGravarLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarLancamento.Location = new System.Drawing.Point(643, 368);
            this.btnGravarLancamento.Name = "btnGravarLancamento";
            this.btnGravarLancamento.Size = new System.Drawing.Size(80, 66);
            this.btnGravarLancamento.TabIndex = 11;
            this.btnGravarLancamento.Text = "Salvar";
            this.btnGravarLancamento.UseVisualStyleBackColor = true;
            // 
            // lblEntradaDeMercadoria
            // 
            this.lblEntradaDeMercadoria.AutoSize = true;
            this.lblEntradaDeMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaDeMercadoria.Location = new System.Drawing.Point(455, 55);
            this.lblEntradaDeMercadoria.Name = "lblEntradaDeMercadoria";
            this.lblEntradaDeMercadoria.Size = new System.Drawing.Size(324, 31);
            this.lblEntradaDeMercadoria.TabIndex = 11;
            this.lblEntradaDeMercadoria.Text = "Entrada de Mercadorias";
            // 
            // formLancamentoNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1248, 613);
            this.Controls.Add(this.lblEntradaDeMercadoria);
            this.Controls.Add(this.grpBoxEntradaMercadoria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLancamentoNotas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpBoxEntradaMercadoria.ResumeLayout(false);
            this.grpBoxEntradaMercadoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDataLancamentoNota;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblFornecedorLancamento;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.GroupBox grpBoxEntradaMercadoria;
        private System.Windows.Forms.Label lblEntradaDeMercadoria;
        private System.Windows.Forms.Button btnGravarLancamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdgProdutoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdProdutoEntrada;
    }
}