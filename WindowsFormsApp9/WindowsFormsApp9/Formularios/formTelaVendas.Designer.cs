namespace WindowsFormsApp9.Formularios
{
    partial class formVendas
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
            this.grpBoxVenda = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lvlValorTotal = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lvlValorPago = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblDescriProdutoVenda = new System.Windows.Forms.Label();
            this.lvlValorUnitarioVenda = new System.Windows.Forms.Label();
            this.lblQntdProdutoVenda = new System.Windows.Forms.Label();
            this.lblCodigoProdutoInsert = new System.Windows.Forms.Label();
            this.dataGridFornecedor = new System.Windows.Forms.DataGridView();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.pnlTelaVendas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnSalvarVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.IdProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prcUnitarioVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxVenda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).BeginInit();
            this.pnlTelaVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxVenda
            // 
            this.grpBoxVenda.Controls.Add(this.textBox7);
            this.grpBoxVenda.Controls.Add(this.lblSubTotal);
            this.grpBoxVenda.Controls.Add(this.textBox4);
            this.grpBoxVenda.Controls.Add(this.textBox2);
            this.grpBoxVenda.Controls.Add(this.lvlValorTotal);
            this.grpBoxVenda.Controls.Add(this.lblTroco);
            this.grpBoxVenda.Controls.Add(this.textBox5);
            this.grpBoxVenda.Controls.Add(this.lvlValorPago);
            this.grpBoxVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxVenda.Location = new System.Drawing.Point(84, 132);
            this.grpBoxVenda.Name = "grpBoxVenda";
            this.grpBoxVenda.Size = new System.Drawing.Size(651, 125);
            this.grpBoxVenda.TabIndex = 28;
            this.grpBoxVenda.TabStop = false;
            this.grpBoxVenda.Text = "Venda";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(-448, 38);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(123, 29);
            this.textBox7.TabIndex = 30;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(-400, 16);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(75, 16);
            this.lblSubTotal.TabIndex = 31;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(462, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(170, 29);
            this.textBox4.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(286, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 29);
            this.textBox2.TabIndex = 5;
            // 
            // lvlValorTotal
            // 
            this.lvlValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvlValorTotal.AutoSize = true;
            this.lvlValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lvlValorTotal.Location = new System.Drawing.Point(11, 37);
            this.lvlValorTotal.Name = "lvlValorTotal";
            this.lvlValorTotal.Size = new System.Drawing.Size(85, 16);
            this.lvlValorTotal.TabIndex = 3;
            this.lvlValorTotal.Text = "Valor Total";
            this.lvlValorTotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTroco
            // 
            this.lblTroco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(459, 37);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(48, 18);
            this.lblTroco.TabIndex = 9;
            this.lblTroco.Text = "Troco";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(14, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(266, 31);
            this.textBox5.TabIndex = 13;
            // 
            // lvlValorPago
            // 
            this.lvlValorPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvlValorPago.AutoSize = true;
            this.lvlValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlValorPago.Location = new System.Drawing.Point(288, 37);
            this.lvlValorPago.Name = "lvlValorPago";
            this.lvlValorPago.Size = new System.Drawing.Size(81, 18);
            this.lvlValorPago.TabIndex = 10;
            this.lvlValorPago.Text = "Valor Pago";
            this.lvlValorPago.Click += new System.EventHandler(this.lvlValorPago_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.btnIncluirProduto);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.lblDescriProdutoVenda);
            this.groupBox2.Controls.Add(this.lvlValorUnitarioVenda);
            this.groupBox2.Controls.Add(this.lblQntdProdutoVenda);
            this.groupBox2.Controls.Add(this.lblCodigoProdutoInsert);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(84, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 362);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens Venda";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 32);
            this.comboBox1.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(14, 38);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(240, 29);
            this.textBox8.TabIndex = 1;
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIncluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirProduto.Location = new System.Drawing.Point(14, 286);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(61, 56);
            this.btnIncluirProduto.TabIndex = 3;
            this.btnIncluirProduto.Text = "Incluir Produto ";
            this.btnIncluirProduto.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(14, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 29);
            this.textBox3.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(14, 179);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(240, 29);
            this.textBox6.TabIndex = 2;
            // 
            // lblDescriProdutoVenda
            // 
            this.lblDescriProdutoVenda.AutoSize = true;
            this.lblDescriProdutoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriProdutoVenda.Location = new System.Drawing.Point(11, 87);
            this.lblDescriProdutoVenda.Name = "lblDescriProdutoVenda";
            this.lblDescriProdutoVenda.Size = new System.Drawing.Size(154, 18);
            this.lblDescriProdutoVenda.TabIndex = 25;
            this.lblDescriProdutoVenda.Text = "Descrição do Produto";
            // 
            // lvlValorUnitarioVenda
            // 
            this.lvlValorUnitarioVenda.AutoSize = true;
            this.lvlValorUnitarioVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlValorUnitarioVenda.Location = new System.Drawing.Point(11, 221);
            this.lvlValorUnitarioVenda.Name = "lvlValorUnitarioVenda";
            this.lvlValorUnitarioVenda.Size = new System.Drawing.Size(97, 18);
            this.lvlValorUnitarioVenda.TabIndex = 20;
            this.lvlValorUnitarioVenda.Text = "Valor Unitário";
            this.lvlValorUnitarioVenda.Click += new System.EventHandler(this.lvlValorUnitarioVenda_Click);
            // 
            // lblQntdProdutoVenda
            // 
            this.lblQntdProdutoVenda.AutoSize = true;
            this.lblQntdProdutoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntdProdutoVenda.Location = new System.Drawing.Point(11, 158);
            this.lblQntdProdutoVenda.Name = "lblQntdProdutoVenda";
            this.lblQntdProdutoVenda.Size = new System.Drawing.Size(83, 18);
            this.lblQntdProdutoVenda.TabIndex = 24;
            this.lblQntdProdutoVenda.Text = "Quantidade";
            // 
            // lblCodigoProdutoInsert
            // 
            this.lblCodigoProdutoInsert.AutoSize = true;
            this.lblCodigoProdutoInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProdutoInsert.Location = new System.Drawing.Point(11, 17);
            this.lblCodigoProdutoInsert.Name = "lblCodigoProdutoInsert";
            this.lblCodigoProdutoInsert.Size = new System.Drawing.Size(113, 18);
            this.lblCodigoProdutoInsert.TabIndex = 23;
            this.lblCodigoProdutoInsert.Text = "Código Produto";
            // 
            // dataGridFornecedor
            // 
            this.dataGridFornecedor.AllowUserToAddRows = false;
            this.dataGridFornecedor.AllowUserToDeleteRows = false;
            this.dataGridFornecedor.AllowUserToResizeColumns = false;
            this.dataGridFornecedor.AllowUserToResizeRows = false;
            this.dataGridFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProdutoVenda,
            this.descricaoProdutoVenda,
            this.qtdProdutoVenda,
            this.prcUnitarioVenda});
            this.dataGridFornecedor.Location = new System.Drawing.Point(771, 62);
            this.dataGridFornecedor.MultiSelect = false;
            this.dataGridFornecedor.Name = "dataGridFornecedor";
            this.dataGridFornecedor.ReadOnly = true;
            this.dataGridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFornecedor.Size = new System.Drawing.Size(441, 502);
            this.dataGridFornecedor.TabIndex = 64;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.Location = new System.Drawing.Point(874, 570);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(68, 58);
            this.btnExcluirProduto.TabIndex = 15;
            this.btnExcluirProduto.Text = "Excluir Produto ";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // pnlTelaVendas
            // 
            this.pnlTelaVendas.AutoSize = true;
            this.pnlTelaVendas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTelaVendas.Controls.Add(this.dataGridFornecedor);
            this.pnlTelaVendas.Controls.Add(this.button1);
            this.pnlTelaVendas.Controls.Add(this.btnCancelarVenda);
            this.pnlTelaVendas.Controls.Add(this.btnSalvarVenda);
            this.pnlTelaVendas.Controls.Add(this.btnExcluirProduto);
            this.pnlTelaVendas.Controls.Add(this.label1);
            this.pnlTelaVendas.Controls.Add(this.textBox9);
            this.pnlTelaVendas.Controls.Add(this.groupBox2);
            this.pnlTelaVendas.Controls.Add(this.grpBoxVenda);
            this.pnlTelaVendas.Location = new System.Drawing.Point(2, 1);
            this.pnlTelaVendas.Name = "pnlTelaVendas";
            this.pnlTelaVendas.Size = new System.Drawing.Size(33001, 687);
            this.pnlTelaVendas.TabIndex = 2;
            this.pnlTelaVendas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTelaVendas_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cadastrar Novo Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(976, 570);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(75, 58);
            this.btnCancelarVenda.TabIndex = 33;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            // 
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvarVenda.Location = new System.Drawing.Point(1108, 570);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.Size = new System.Drawing.Size(75, 58);
            this.btnSalvarVenda.TabIndex = 32;
            this.btnSalvarVenda.Text = "Salvar Venda";
            this.btnSalvarVenda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox9.Location = new System.Drawing.Point(98, 83);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(225, 29);
            this.textBox9.TabIndex = 0;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // IdProdutoVenda
            // 
            this.IdProdutoVenda.HeaderText = "Código ";
            this.IdProdutoVenda.Name = "IdProdutoVenda";
            this.IdProdutoVenda.ReadOnly = true;
            this.IdProdutoVenda.Width = 70;
            // 
            // descricaoProdutoVenda
            // 
            this.descricaoProdutoVenda.HeaderText = "Descrição Produto";
            this.descricaoProdutoVenda.Name = "descricaoProdutoVenda";
            this.descricaoProdutoVenda.ReadOnly = true;
            this.descricaoProdutoVenda.Width = 150;
            // 
            // qtdProdutoVenda
            // 
            this.qtdProdutoVenda.HeaderText = "Quantidade";
            this.qtdProdutoVenda.Name = "qtdProdutoVenda";
            this.qtdProdutoVenda.ReadOnly = true;
            // 
            // prcUnitarioVenda
            // 
            this.prcUnitarioVenda.HeaderText = "Preço UN";
            this.prcUnitarioVenda.Name = "prcUnitarioVenda";
            this.prcUnitarioVenda.ReadOnly = true;
            // 
            // formVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 752);
            this.Controls.Add(this.pnlTelaVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.formVendas_Load);
            this.grpBoxVenda.ResumeLayout(false);
            this.grpBoxVenda.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).EndInit();
            this.pnlTelaVendas.ResumeLayout(false);
            this.pnlTelaVendas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxVenda;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lvlValorTotal;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lvlValorPago;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblDescriProdutoVenda;
        private System.Windows.Forms.Label lvlValorUnitarioVenda;
        private System.Windows.Forms.Label lblQntdProdutoVenda;
        private System.Windows.Forms.Label lblCodigoProdutoInsert;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Panel pnlTelaVendas;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnSalvarVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn prcUnitarioVenda;
    }
}