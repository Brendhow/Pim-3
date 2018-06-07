using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    class CadastroFornecedor
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cnpj { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        public void cadastro()
        {
           
            String str = @"server=localhost;database=inspire;userid=root;password=12345;";
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(str);
                String query = "INSERT INTO fornecedor (nome,endereco,telefone,numero,complemento,cep,cidade,estado,cnpj,celular,email) VALUES (@nome,@endereco,@telefone,@numero,@complemento,@cep,@cidade,@estado,@cnpj,@celular,@email);";
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
                cmd.Parameters.Add(new MySqlParameter("cnpj", cnpj));
                cmd.Parameters.Add(new MySqlParameter("celular", celular));
                cmd.Parameters.Add(new MySqlParameter("email", email));
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
