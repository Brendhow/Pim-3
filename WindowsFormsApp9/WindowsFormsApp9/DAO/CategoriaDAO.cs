using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Factory;

namespace WindowsFormsApp9.DAO
{
    public class CategoriaDAO
    {

        MySqlConnection conexao { get; set; }
        public CategoriaDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Models.Categoria> selecionarTodosCategorias()
        {
            List<Models.Categoria> ListaClientes = new List<Models.Categoria>();
            using (MySqlCommand cmd = new MySqlCommand("select * from caixa;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaClientes.Add(new Models.Categoria()
                    {
                        Id_Categoria = Convert.ToInt32(reader["id_categoria"]),
                        Nome = reader["nome"].ToString(),

                    });
                }
                conexao.Close();
                return ListaClientes;
            }
        }
    }
}

