namespace WindowsFormsApp9.Formularios
{
    partial class formCadastroFornecedor
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lvlEndereco = new System.Windows.Forms.Label();
            this.lvlTelefone = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.textBoxEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxNumeroFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxObsFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxCNPJFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxTelFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxCepFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxCelFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.textBoxEmailFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxComplementoFornecedor = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.pnlCadastroFornecedor = new System.Windows.Forms.Panel();
            this.dataGridFornecedor = new System.Windows.Forms.DataGridView();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.idFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCadastroFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(595, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Fornecedor";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(469, 163);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 18);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(465, 405);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 18);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email:";
            // 
            // lvlEndereco
            // 
            this.lvlEndereco.AutoSize = true;
            this.lvlEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lvlEndereco.Location = new System.Drawing.Point(465, 215);
            this.lvlEndereco.Name = "lvlEndereco";
            this.lvlEndereco.Size = new System.Drawing.Size(85, 18);
            this.lvlEndereco.TabIndex = 31;
            this.lvlEndereco.Text = "Endereço:";
            // 
            // lvlTelefone
            // 
            this.lvlTelefone.AutoSize = true;
            this.lvlTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lvlTelefone.Location = new System.Drawing.Point(465, 357);
            this.lvlTelefone.Name = "lvlTelefone";
            this.lvlTelefone.Size = new System.Drawing.Size(78, 18);
            this.lvlTelefone.TabIndex = 32;
            this.lvlTelefone.Text = "Telefone:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblObservacao.Location = new System.Drawing.Point(465, 471);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(113, 18);
            this.lblObservacao.TabIndex = 33;
            this.lblObservacao.Text = "Observações:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCpf.Location = new System.Drawing.Point(465, 309);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(51, 16);
            this.lblCpf.TabIndex = 34;
            this.lblCpf.Text = "CNPJ:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNro.Location = new System.Drawing.Point(873, 214);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(73, 18);
            this.lblNro.TabIndex = 35;
            this.lblNro.Text = "Número:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCelular.Location = new System.Drawing.Point(878, 357);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(66, 18);
            this.lblCelular.TabIndex = 36;
            this.lblCelular.Text = "Celular:";
            // 
            // textBoxEnderecoFornecedor
            // 
            this.textBoxEnderecoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEnderecoFornecedor.Location = new System.Drawing.Point(468, 235);
            this.textBoxEnderecoFornecedor.Name = "textBoxEnderecoFornecedor";
            this.textBoxEnderecoFornecedor.Size = new System.Drawing.Size(393, 26);
            this.textBoxEnderecoFornecedor.TabIndex = 3;
            // 
            // textBoxNumeroFornecedor
            // 
            this.textBoxNumeroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNumeroFornecedor.Location = new System.Drawing.Point(876, 235);
            this.textBoxNumeroFornecedor.Name = "textBoxNumeroFornecedor";
            this.textBoxNumeroFornecedor.Size = new System.Drawing.Size(114, 26);
            this.textBoxNumeroFornecedor.TabIndex = 4;
            // 
            // textBoxObsFornecedor
            // 
            this.textBoxObsFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxObsFornecedor.Location = new System.Drawing.Point(468, 502);
            this.textBoxObsFornecedor.MaximumSize = new System.Drawing.Size(800, 800);
            this.textBoxObsFornecedor.Name = "textBoxObsFornecedor";
            this.textBoxObsFornecedor.Size = new System.Drawing.Size(658, 26);
            this.textBoxObsFornecedor.TabIndex = 12;
            // 
            // textBoxCNPJFornecedor
            // 
            this.textBoxCNPJFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCNPJFornecedor.Location = new System.Drawing.Point(468, 330);
            this.textBoxCNPJFornecedor.Name = "textBoxCNPJFornecedor";
            this.textBoxCNPJFornecedor.Size = new System.Drawing.Size(273, 26);
            this.textBoxCNPJFornecedor.TabIndex = 1;
            // 
            // textBoxTelFornecedor
            // 
            this.textBoxTelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTelFornecedor.Location = new System.Drawing.Point(468, 378);
            this.textBoxTelFornecedor.Name = "textBoxTelFornecedor";
            this.textBoxTelFornecedor.Size = new System.Drawing.Size(273, 26);
            this.textBoxTelFornecedor.TabIndex = 9;
            // 
            // textBoxCepFornecedor
            // 
            this.textBoxCepFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCepFornecedor.Location = new System.Drawing.Point(468, 282);
            this.textBoxCepFornecedor.Name = "textBoxCepFornecedor";
            this.textBoxCepFornecedor.Size = new System.Drawing.Size(228, 26);
            this.textBoxCepFornecedor.TabIndex = 6;
            // 
            // textBoxCelFornecedor
            // 
            this.textBoxCelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCelFornecedor.Location = new System.Drawing.Point(876, 378);
            this.textBoxCelFornecedor.Name = "textBoxCelFornecedor";
            this.textBoxCelFornecedor.Size = new System.Drawing.Size(250, 26);
            this.textBoxCelFornecedor.TabIndex = 10;
            // 
            // textBoxNomeFornecedor
            // 
            this.textBoxNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNomeFornecedor.Location = new System.Drawing.Point(468, 184);
            this.textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            this.textBoxNomeFornecedor.Size = new System.Drawing.Size(658, 26);
            this.textBoxNomeFornecedor.TabIndex = 2;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCep.Location = new System.Drawing.Point(465, 262);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(40, 16);
            this.lblCep.TabIndex = 47;
            this.lblCep.Text = "Cep:";
            // 
            // textBoxEmailFornecedor
            // 
            this.textBoxEmailFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmailFornecedor.Location = new System.Drawing.Point(468, 426);
            this.textBoxEmailFornecedor.Name = "textBoxEmailFornecedor";
            this.textBoxEmailFornecedor.Size = new System.Drawing.Size(314, 26);
            this.textBoxEmailFornecedor.TabIndex = 12;
            // 
            // textBoxComplementoFornecedor
            // 
            this.textBoxComplementoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxComplementoFornecedor.Location = new System.Drawing.Point(1007, 235);
            this.textBoxComplementoFornecedor.Name = "textBoxComplementoFornecedor";
            this.textBoxComplementoFornecedor.Size = new System.Drawing.Size(114, 26);
            this.textBoxComplementoFornecedor.TabIndex = 5;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblComplemento.Location = new System.Drawing.Point(1004, 213);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(113, 18);
            this.lblComplemento.TabIndex = 60;
            this.lblComplemento.Text = "Complemento";
            // 
            // pnlCadastroFornecedor
            // 
            this.pnlCadastroFornecedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCadastroFornecedor.Controls.Add(this.dataGridFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.btnConsultarCliente);
            this.pnlCadastroFornecedor.Controls.Add(this.btnSalvarCliente);
            this.pnlCadastroFornecedor.Controls.Add(this.btnCancelarCadastro);
            this.pnlCadastroFornecedor.Controls.Add(this.lblComplemento);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxComplementoFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxEmailFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.lblCep);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxNomeFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxCelFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxCepFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxTelFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxCNPJFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxObsFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxNumeroFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.textBoxEnderecoFornecedor);
            this.pnlCadastroFornecedor.Controls.Add(this.lblCelular);
            this.pnlCadastroFornecedor.Controls.Add(this.lblNro);
            this.pnlCadastroFornecedor.Controls.Add(this.lblCpf);
            this.pnlCadastroFornecedor.Controls.Add(this.lblObservacao);
            this.pnlCadastroFornecedor.Controls.Add(this.lvlTelefone);
            this.pnlCadastroFornecedor.Controls.Add(this.lvlEndereco);
            this.pnlCadastroFornecedor.Controls.Add(this.lblEmail);
            this.pnlCadastroFornecedor.Controls.Add(this.lblNome);
            this.pnlCadastroFornecedor.Controls.Add(this.label1);
            this.pnlCadastroFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlCadastroFornecedor.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroFornecedor.Name = "pnlCadastroFornecedor";
            this.pnlCadastroFornecedor.Size = new System.Drawing.Size(1264, 681);
            this.pnlCadastroFornecedor.TabIndex = 15;
            this.pnlCadastroFornecedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastroFornecedor_Paint);
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
            this.idFornecedor,
            this.Nome,
            this.Telefone,
            this.Cnpj});
            this.dataGridFornecedor.Location = new System.Drawing.Point(28, 163);
            this.dataGridFornecedor.MultiSelect = false;
            this.dataGridFornecedor.Name = "dataGridFornecedor";
            this.dataGridFornecedor.ReadOnly = true;
            this.dataGridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFornecedor.Size = new System.Drawing.Size(431, 434);
            this.dataGridFornecedor.TabIndex = 63;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(869, 589);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 57);
            this.btnConsultarCliente.TabIndex = 15;
            this.btnConsultarCliente.Text = "Consultar Fornecedor";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(1091, 589);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(75, 57);
            this.btnSalvarCliente.TabIndex = 13;
            this.btnSalvarCliente.Text = "Salvar Cadastro";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.BtnSalvarCliente_Click);
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.Location = new System.Drawing.Point(977, 589);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(75, 57);
            this.btnCancelarCadastro.TabIndex = 14;
            this.btnCancelarCadastro.Text = "Cancelar Cadastro";
            this.btnCancelarCadastro.UseVisualStyleBackColor = true;
            // 
            // idFornecedor
            // 
            this.idFornecedor.DataPropertyName = "Id_Fornecedor";
            this.idFornecedor.HeaderText = "Código";
            this.idFornecedor.Name = "idFornecedor";
            this.idFornecedor.ReadOnly = true;
            this.idFornecedor.Width = 70;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 70;
            // 
            // Cnpj
            // 
            this.Cnpj.DataPropertyName = "Cnpj";
            this.Cnpj.HeaderText = "Cnpj";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.ReadOnly = true;
            // 
            // formCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 681);
            this.Controls.Add(this.pnlCadastroFornecedor);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCadastroFornecedor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formCadastroFornecedor_Load);
            this.pnlCadastroFornecedor.ResumeLayout(false);
            this.pnlCadastroFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lvlEndereco;
        private System.Windows.Forms.Label lvlTelefone;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox textBoxEnderecoFornecedor;
        private System.Windows.Forms.TextBox textBoxNumeroFornecedor;
        private System.Windows.Forms.TextBox textBoxObsFornecedor;
        private System.Windows.Forms.TextBox textBoxCNPJFornecedor;
        private System.Windows.Forms.TextBox textBoxTelFornecedor;
        private System.Windows.Forms.TextBox textBoxCepFornecedor;
        private System.Windows.Forms.TextBox textBoxCelFornecedor;
        private System.Windows.Forms.TextBox textBoxNomeFornecedor;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox textBoxEmailFornecedor;
        private System.Windows.Forms.TextBox textBoxComplementoFornecedor;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Panel pnlCadastroFornecedor;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.DataGridView dataGridFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
    }
}