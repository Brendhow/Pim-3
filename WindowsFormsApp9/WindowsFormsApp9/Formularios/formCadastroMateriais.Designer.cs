namespace WindowsFormsApp9.Formularios
{
    partial class formCadastroMateriais
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
            this.pnlCadastroMateriais = new System.Windows.Forms.Panel();
            this.btnConfirmarProduto = new System.Windows.Forms.Button();
            this.dataGridProdutoCad = new System.Windows.Forms.DataGridView();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoNcm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoDeCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoDeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCaracteristica = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.grpBoxDescricao = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblGrupoMaterial = new System.Windows.Forms.Label();
            this.lblNcm = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCadProduto = new System.Windows.Forms.Label();
            this.pnlCadastroMateriais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutoCad)).BeginInit();
            this.grpCaracteristica.SuspendLayout();
            this.grpBoxDescricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroMateriais
            // 
            this.pnlCadastroMateriais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCadastroMateriais.Controls.Add(this.btnConfirmarProduto);
            this.pnlCadastroMateriais.Controls.Add(this.dataGridProdutoCad);
            this.pnlCadastroMateriais.Controls.Add(this.grpCaracteristica);
            this.pnlCadastroMateriais.Controls.Add(this.grpBoxDescricao);
            this.pnlCadastroMateriais.Controls.Add(this.lblCep);
            this.pnlCadastroMateriais.Controls.Add(this.lblCadProduto);
            this.pnlCadastroMateriais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastroMateriais.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroMateriais.Name = "pnlCadastroMateriais";
            this.pnlCadastroMateriais.Size = new System.Drawing.Size(1248, 613);
            this.pnlCadastroMateriais.TabIndex = 2;
            this.pnlCadastroMateriais.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastroMateriais_Paint);
            // 
            // btnConfirmarProduto
            // 
            this.btnConfirmarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarProduto.Location = new System.Drawing.Point(1103, 536);
            this.btnConfirmarProduto.Name = "btnConfirmarProduto";
            this.btnConfirmarProduto.Size = new System.Drawing.Size(75, 65);
            this.btnConfirmarProduto.TabIndex = 92;
            this.btnConfirmarProduto.Text = "Salvar";
            this.btnConfirmarProduto.UseVisualStyleBackColor = false;
            // 
            // dataGridProdutoCad
            // 
            this.dataGridProdutoCad.AllowUserToAddRows = false;
            this.dataGridProdutoCad.AllowUserToDeleteRows = false;
            this.dataGridProdutoCad.AllowUserToResizeColumns = false;
            this.dataGridProdutoCad.AllowUserToResizeRows = false;
            this.dataGridProdutoCad.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProdutoCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutoCad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Produto,
            this.Nome,
            this.Descricao,
            this.CodigoNcm,
            this.grpMaterial,
            this.PrecoDeCusto,
            this.PrecoDeVenda});
            this.dataGridProdutoCad.Location = new System.Drawing.Point(95, 313);
            this.dataGridProdutoCad.MultiSelect = false;
            this.dataGridProdutoCad.Name = "dataGridProdutoCad";
            this.dataGridProdutoCad.ReadOnly = true;
            this.dataGridProdutoCad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdutoCad.Size = new System.Drawing.Size(1083, 217);
            this.dataGridProdutoCad.TabIndex = 91;
            this.dataGridProdutoCad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutoCad_CellContentClick);
            // 
            // Id_Produto
            // 
            this.Id_Produto.DataPropertyName = "Id_Produto";
            this.Id_Produto.HeaderText = "Código";
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            this.Id_Produto.Width = 60;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 190;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 350;
            // 
            // CodigoNcm
            // 
            this.CodigoNcm.DataPropertyName = "CodigoNcm";
            this.CodigoNcm.HeaderText = "Código Ncm";
            this.CodigoNcm.Name = "CodigoNcm";
            this.CodigoNcm.ReadOnly = true;
            this.CodigoNcm.Width = 80;
            // 
            // grpMaterial
            // 
            this.grpMaterial.DataPropertyName = "grpMaterial";
            this.grpMaterial.HeaderText = "Grupo de Material";
            this.grpMaterial.Name = "grpMaterial";
            this.grpMaterial.ReadOnly = true;
            // 
            // PrecoDeCusto
            // 
            this.PrecoDeCusto.DataPropertyName = "PrecoDeCusto";
            this.PrecoDeCusto.HeaderText = "Preço de Custo";
            this.PrecoDeCusto.Name = "PrecoDeCusto";
            this.PrecoDeCusto.ReadOnly = true;
            this.PrecoDeCusto.Width = 130;
            // 
            // PrecoDeVenda
            // 
            this.PrecoDeVenda.DataPropertyName = "PrecoDeVenda";
            this.PrecoDeVenda.HeaderText = "Preço de Venda";
            this.PrecoDeVenda.Name = "PrecoDeVenda";
            this.PrecoDeVenda.ReadOnly = true;
            this.PrecoDeVenda.Width = 130;
            // 
            // grpCaracteristica
            // 
            this.grpCaracteristica.Controls.Add(this.textBox6);
            this.grpCaracteristica.Controls.Add(this.lblMarca);
            this.grpCaracteristica.Controls.Add(this.textBox4);
            this.grpCaracteristica.Controls.Add(this.comboBox1);
            this.grpCaracteristica.Controls.Add(this.lblTamanho);
            this.grpCaracteristica.Controls.Add(this.lblCor);
            this.grpCaracteristica.Controls.Add(this.textBox8);
            this.grpCaracteristica.Controls.Add(this.lblPrecoCusto);
            this.grpCaracteristica.Location = new System.Drawing.Point(95, 184);
            this.grpCaracteristica.Name = "grpCaracteristica";
            this.grpCaracteristica.Size = new System.Drawing.Size(1083, 100);
            this.grpCaracteristica.TabIndex = 90;
            this.grpCaracteristica.TabStop = false;
            this.grpCaracteristica.Text = "Caracteristicas";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox6.Location = new System.Drawing.Point(16, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(302, 26);
            this.textBox6.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(13, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 67;
            this.lblMarca.Text = "Marca";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox4.Location = new System.Drawing.Point(590, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 26);
            this.textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(385, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTamanho.Location = new System.Drawing.Point(587, 28);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(78, 18);
            this.lblTamanho.TabIndex = 80;
            this.lblTamanho.Text = "Tamanho";
            this.lblTamanho.Click += new System.EventHandler(this.lblTamanho_Click);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCor.Location = new System.Drawing.Point(382, 26);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(36, 18);
            this.lblCor.TabIndex = 64;
            this.lblCor.Text = "Cor";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox8.Location = new System.Drawing.Point(890, 47);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 26);
            this.textBox8.TabIndex = 8;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecoCusto.Location = new System.Drawing.Point(887, 28);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(126, 18);
            this.lblPrecoCusto.TabIndex = 65;
            this.lblPrecoCusto.Text = "Preço de Custo";
            this.lblPrecoCusto.Click += new System.EventHandler(this.lblPrecoCusto_Click);
            // 
            // grpBoxDescricao
            // 
            this.grpBoxDescricao.Controls.Add(this.textBox9);
            this.grpBoxDescricao.Controls.Add(this.lblPrecoVenda);
            this.grpBoxDescricao.Controls.Add(this.lblNome);
            this.grpBoxDescricao.Controls.Add(this.textBox7);
            this.grpBoxDescricao.Controls.Add(this.textBox12);
            this.grpBoxDescricao.Controls.Add(this.lblCódigo);
            this.grpBoxDescricao.Controls.Add(this.textBox2);
            this.grpBoxDescricao.Controls.Add(this.lblGrupoMaterial);
            this.grpBoxDescricao.Controls.Add(this.lblNcm);
            this.grpBoxDescricao.Controls.Add(this.textBox13);
            this.grpBoxDescricao.Location = new System.Drawing.Point(95, 66);
            this.grpBoxDescricao.Name = "grpBoxDescricao";
            this.grpBoxDescricao.Size = new System.Drawing.Size(1083, 100);
            this.grpBoxDescricao.TabIndex = 89;
            this.grpBoxDescricao.TabStop = false;
            this.grpBoxDescricao.Text = "Descrição do produto";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox9.Location = new System.Drawing.Point(97, 49);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(265, 26);
            this.textBox9.TabIndex = 1;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecoVenda.Location = new System.Drawing.Point(887, 28);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(127, 18);
            this.lblPrecoVenda.TabIndex = 88;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(94, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 18);
            this.lblNome.TabIndex = 62;
            this.lblNome.Text = "Nome:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox7.Location = new System.Drawing.Point(890, 49);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(129, 26);
            this.textBox7.TabIndex = 4;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox12.Location = new System.Drawing.Point(16, 49);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(66, 26);
            this.textBox12.TabIndex = 0;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCódigo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCódigo.Location = new System.Drawing.Point(13, 28);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(62, 18);
            this.lblCódigo.TabIndex = 69;
            this.lblCódigo.Text = "Código";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(385, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 26);
            this.textBox2.TabIndex = 2;
            // 
            // lblGrupoMaterial
            // 
            this.lblGrupoMaterial.AutoSize = true;
            this.lblGrupoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGrupoMaterial.Location = new System.Drawing.Point(587, 28);
            this.lblGrupoMaterial.Name = "lblGrupoMaterial";
            this.lblGrupoMaterial.Size = new System.Drawing.Size(143, 18);
            this.lblGrupoMaterial.TabIndex = 84;
            this.lblGrupoMaterial.Text = "Grupo de Material";
            // 
            // lblNcm
            // 
            this.lblNcm.AutoSize = true;
            this.lblNcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNcm.Location = new System.Drawing.Point(382, 28);
            this.lblNcm.Name = "lblNcm";
            this.lblNcm.Size = new System.Drawing.Size(105, 18);
            this.lblNcm.TabIndex = 68;
            this.lblNcm.Text = "Código NCM";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox13.Location = new System.Drawing.Point(590, 49);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(250, 26);
            this.textBox13.TabIndex = 3;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCep.Location = new System.Drawing.Point(522, 268);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(40, 16);
            this.lblCep.TabIndex = 79;
            this.lblCep.Text = "Cep:";
            // 
            // lblCadProduto
            // 
            this.lblCadProduto.AutoSize = true;
            this.lblCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProduto.Location = new System.Drawing.Point(493, 29);
            this.lblCadProduto.Name = "lblCadProduto";
            this.lblCadProduto.Size = new System.Drawing.Size(241, 25);
            this.lblCadProduto.TabIndex = 5;
            this.lblCadProduto.Text = "Cadastro de Produtos";
            // 
            // formCadastroMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 613);
            this.Controls.Add(this.pnlCadastroMateriais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCadastroMateriais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCadastroMateriais.ResumeLayout(false);
            this.pnlCadastroMateriais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutoCad)).EndInit();
            this.grpCaracteristica.ResumeLayout(false);
            this.grpCaracteristica.PerformLayout();
            this.grpBoxDescricao.ResumeLayout(false);
            this.grpBoxDescricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroMateriais;
        private System.Windows.Forms.Label lblCadProduto;
        private System.Windows.Forms.GroupBox grpCaracteristica;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.GroupBox grpBoxDescricao;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblGrupoMaterial;
        private System.Windows.Forms.Label lblNcm;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.DataGridView dataGridProdutoCad;
        private System.Windows.Forms.Button btnConfirmarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoNcm;
        private System.Windows.Forms.DataGridViewTextBoxColumn grpMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoDeCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoDeVenda;
    }
}