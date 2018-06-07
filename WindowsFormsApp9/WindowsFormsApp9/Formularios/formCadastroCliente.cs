using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp9.Models;
using WindowsFormsApp9.DAO;

namespace WindowsFormsApp9.Formularios
{
    public partial class formCadastroCliente : Formularios.Base.formBase
    {
        List<CadastroCliente> teste { get; set; }
        Cliente cliente;

        public formCadastroCliente()
        {
            InitializeComponent();
        }

        private void formCadastroCliente_Load(object sender, EventArgs e)
        {
            MontarDataGrid();
        }

        private void MontarDataGrid()
        {
            dataGridView1.DataSource = SelecionarTodosClientes();
        }

        private List<Cliente> SelecionarTodosClientes()
        {
            var dao = new ClienteDAO();
            var clientes = dao.selecionarTodosClientes();
            return clientes;
        }

        private void formCadastroClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MontarDataGrid();
        }

        private void lblSobrenome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textId.Clear();
            txtNomeCliente.Clear(); textEnderecoCliente.Clear(); textNumeroEnderecoCliente.Clear(); textComplementoEnderecoCliente.Clear(); textCepCliente.Clear();
            textCPFCliente.Clear(); textTelefoneCliente.Clear(); textCelularCliente.Clear(); textEmailCliente.Clear(); dateTimePickerAniversarioCliente.Text = DateTime.Now.ToShortDateString();
            textOBSCliente.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCliente.Text))
                MessageBox.Show("Nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var dao = new ClienteDAO();
                dao.salvar(new Cliente()
                {
                    id_cliente = textId.Text == "" ? 0 : Convert.ToInt16(textId.Text),
                    nome = txtNomeCliente.Text,
                    endereco = textEnderecoCliente.Text,
                    numero = textNumeroEnderecoCliente.Text,
                    complemento = textComplementoEnderecoCliente.Text,
                    cep = textCepCliente.Text,
                    cpf = textCPFCliente.Text,
                    telefone = textTelefoneCliente.Text,
                    celular = textCelularCliente.Text,
                    email = textEmailCliente.Text,
                    aniversario = Convert.ToDateTime(dateTimePickerAniversarioCliente.Text),
                    obs = textOBSCliente.Text
                });
                MessageBox.Show("Salvo com sucesso.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MontarDataGrid();
            }
            

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Convert.ToDateTime(textAniversarioCliente);
        }

        private void textCPFCliente_TextChanged(object sender, EventArgs e)
        {
            textCPFCliente.MaxLength = 11;
        }

        private void listCadCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            //listCadCliente.Columns[0].Text = "coluna1";
            //listCadCliente.Columns[1].Text = "coluna2";
            //listCadCliente.Items.Add("List item text", 3);
            //listCadCliente.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            //listCadCliente.Columns.Add("Column 4", -2, HorizontalAlignment.Center);
            listCadCliente.Items.Add("List item 1", 1);
            //listCadCliente.ListViewItemSorter
            //listCadCliente.Columns[0].Name = "ata";
            //listCadCliente.Columns.Add(clmNome)
            //listCadCliente.Columns[1].Name = "boi";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePickerAniversarioCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                cliente = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;
                MontarFormulario();
            }
        }

        private void MontarFormulario()
        {
            txtNomeCliente.Text = cliente.nome;
            textEnderecoCliente.Text = cliente.endereco;
            textNumeroEnderecoCliente.Text = cliente.numero.ToString();
            textComplementoEnderecoCliente.Text = cliente.complemento;
            textCepCliente.Text = cliente.cep;
            textCPFCliente.Text = cliente.cpf;
            textTelefoneCliente.Text = cliente.telefone;
            textCelularCliente.Text = cliente.celular;
            textEmailCliente.Text = cliente.email;
            dateTimePickerAniversarioCliente.Text = cliente.aniversario.ToShortDateString();
            textOBSCliente.Text = cliente.obs;
            textId.Text = cliente.id_cliente.ToString();
        }
    }
}
