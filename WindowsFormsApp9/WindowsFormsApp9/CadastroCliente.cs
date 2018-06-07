using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp9
{

    class CadastroCliente
    {
            public string nome { get; set; }
            public string endereco { get; set; }
            public string telefone { get; set; }
            public string numero { get; set; }
            public string complemento { get; set; }
            public string cep { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }
            public string cpf { get; set; }
            public string celular { get; set; }
            public string email { get; set; }
            public DateTime aniversario { get; set; }


            /*
            var cliente = new
            {
                nomec = nome,
                sobrenome = "teste"
            };
            List<object> list = new List<object>()
            {
                cliente
            };
            */
            public void cadastro(/*string nome1, string endereco1, string telefone1, 
                string numero1, string complemento1, string cep1, string cidade1,
                string estado1, string cpf1,string celular1, string email1, string aniversario1, object sender*/)
            {
                /*var clientes = new
                {
                    nomeC = nome,
                    enderecoC = endereco,
                    telefoneC = telefone
                };
                List<object> lista = new List<object>()
                {
                    clientes
                };*/
                String str = @"server=localhost;database=inspire;userid=root;password=12345;";
                MySqlConnection conn = null;

                try
                {
                    //dataGridView1.DataSource = list;
                    conn = new MySqlConnection(str);
                    String query = "INSERT INTO cliente (nome,endereco,telefone,numero,complemento,cep,cidade,estado,cpf,celular,email,aniversario) VALUES (@nome,@endereco,@telefone,@numero,@complemento,@cep,@cidade,@estado,@cpf,@celular,@email,@aniversario);";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Add(new MySqlParameter("nome", nome));
                    cmd.Parameters.Add(new MySqlParameter("endereco", endereco));
                    cmd.Parameters.Add(new MySqlParameter("telefone", telefone));
                    cmd.Parameters.Add(new MySqlParameter("numero", numero));
                    cmd.Parameters.Add(new MySqlParameter("complemento", complemento));
                    cmd.Parameters.Add(new MySqlParameter("cep", cep));
                    cmd.Parameters.Add(new MySqlParameter("cidade", cidade));
                    cmd.Parameters.Add(new MySqlParameter("estado", estado));
                    cmd.Parameters.Add(new MySqlParameter("cpf", cpf));
                    cmd.Parameters.Add(new MySqlParameter("celular", celular));
                    cmd.Parameters.Add(new MySqlParameter("email", email));
                    cmd.Parameters.Add(new MySqlParameter("aniversario", aniversario /*DateTime.Now*/));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }

        }
}
