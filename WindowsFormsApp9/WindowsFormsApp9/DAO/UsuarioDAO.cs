using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Factory;

namespace WindowsFormsApp9.DAO
{
    public class UsuarioDAO
    {
        MySqlConnection conexao { get; set; }
        public UsuarioDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<UsuarioDAO> selecionarTodosClientes()
        {
            List<UsuarioDAO> ListaClientes = new List<UsuarioDAO>();
            using (MySqlCommand cmd = new MySqlCommand("select * from cliente;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaClientes.Add(new UsuarioDAO()
                    {



                    });
                }
                conexao.Close();
                return ListaClientes;
            }
        }
    }
}
