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
    public class CaixaDAO
    {

        MySqlConnection conexao { get; set; }
        public CaixaDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Caixa> selecionarTodosCaixa()
        {
            List<Caixa> ListaCaixas = new List<Caixa>();
            using (MySqlCommand cmd = new MySqlCommand("select * from caixa;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaCaixas.Add(new Caixa()
                    {
                        Id_Caixa = Convert.ToInt32(reader["Id_Caixa"]),
                        Date = Convert.ToDateTime(reader["date"])
                    });
                }
                conexao.Close();
                return ListaCaixas;
            }
        }
    }
}

