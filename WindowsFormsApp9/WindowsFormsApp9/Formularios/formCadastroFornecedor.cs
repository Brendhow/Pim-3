using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.DAO;
using WindowsFormsApp9.Models;

namespace WindowsFormsApp9.Formularios
{
    public partial class formCadastroFornecedor : Formularios.Base.formBase
    {
        public formCadastroFornecedor()
        {
            InitializeComponent();
        }

        //montar
        private void MontarDataGrid()
        {
            dataGridFornecedor.DataSource = SelecionarTodosFornecedores();
        }

        //esse
        private List<Fornecedor> SelecionarTodosFornecedores()
        {
            var dao = new FornecedorDAO();
            var fornecedores = dao.selecionarTodosFornecedores();
            return fornecedores;
        }

        private void formCadastroFornecedor_Load(object sender, EventArgs e)
        {
            dataGridFornecedor.AutoGenerateColumns = false;
            MontarDataGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlCadastroFornecedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalvarCliente_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cadastroFornecedorcs = new CadastroFornecedor();
            cadastroFornecedorcs.nome = textBoxNomeFornecedor.Text;
            cadastroFornecedorcs.endereco = textBoxEnderecoFornecedor.Text;
            cadastroFornecedorcs.telefone = textBoxTelFornecedor.Text;
            cadastroFornecedorcs.numero = textBoxNumeroFornecedor.Text;
            cadastroFornecedorcs.complemento = textBoxEnderecoFornecedor.Text;
            cadastroFornecedorcs.cep = textBoxCepFornecedor.Text;
            cadastroFornecedorcs.cnpj = textBoxCNPJFornecedor.Text;
            cadastroFornecedorcs.celular = textBoxCelFornecedor.Text;
            cadastroFornecedorcs.email = textBoxEmailFornecedor.Text;
            cadastroFornecedorcs.cadastro();
        }
    }
}