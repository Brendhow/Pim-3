using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Factory;

namespace WindowsFormsApp9.DAO
{
    public class VendaDAO
    {
        MySqlConnection conexao { get; set; }
        public VendaDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Models.Venda> selecionarTodosVendas()
        {
            List<Models.Venda> ListaClientes = new List<Models.Venda>();
            using (MySqlCommand cmd = new MySqlCommand("select * from Venda;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaClientes.Add(new Models.Venda()
                    {
                        Data = Convert.ToDateTime(reader["Data"]),
                        Id_Venda = Convert.ToInt32(reader["Id_venda"]),

                    });
                }
                conexao.Close();
                return ListaClientes;
            }
        }
    }
}
