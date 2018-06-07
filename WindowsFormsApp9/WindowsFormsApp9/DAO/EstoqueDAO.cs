using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Factory;
using WindowsFormsApp9.Models;

namespace WindowsFormsApp9.DAO
{
    public class EstoqueDAO
    {
        MySqlConnection conexao { get; set; }
        public EstoqueDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Estoque> selecionarTodosEstoque()
        {
            List<Estoque> ListaEstoques = new List<Estoque>();
            using (MySqlCommand cmd = new MySqlCommand("select * from Estoque;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaEstoques.Add(new Estoque()
                    {
                        Id_Estoque = Convert.ToInt32(reader["Id_Estoque"]),
                        Qtd = Convert.ToInt32(reader["Qtd"]),
                    });
                }
                conexao.Close();
                return ListaEstoques;
            }
        }
    }
}
