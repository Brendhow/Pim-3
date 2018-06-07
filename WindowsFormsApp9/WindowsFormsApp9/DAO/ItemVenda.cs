using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Factory;

namespace WindowsFormsApp9.DAO
{
    public class ItemVenda
    {

        MySqlConnection conexao { get; set; }
        public ItemVenda()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<ItemVenda> selecionarTodosClientes()
        {
            List<ItemVenda> ListaClientes = new List<ItemVenda>();
            using (MySqlCommand cmd = new MySqlCommand("select * from cliente;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaClientes.Add(new ItemVenda()
                    {

                    });
                }
                conexao.Close();
                return ListaClientes;
            }
        }
    }
}
