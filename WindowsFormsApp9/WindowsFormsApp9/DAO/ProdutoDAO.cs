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
    public class ProdutoDAO
    {
        MySqlConnection conexao { get; set; }
        public ProdutoDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Models.Produto> selecionarTodosProdutos()
        {
            List<Models.Produto> ListaProdutos = new List<Models.Produto>();
            using (MySqlCommand cmd = new MySqlCommand("select * from produto;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaProdutos.Add(new Models.Produto()
                    {

                        CodigoNcm = reader["CodigoNcm"].ToString(),
                        Descricao = reader["Descricao"].ToString(),
                        Id_Produto = Convert.ToInt32(reader["id_produto"]),
                        Marca = reader["Marca"].ToString(),
                        Nome = reader["nome"].ToString(),
                        PrecoDeCusto = Convert.ToInt32(reader["PrecoDeCusto"]),
                        PrecoDeVenda = Convert.ToInt32(reader["PrecoDeVenda"]),

                    });
                }
                conexao.Close();
                return ListaProdutos;
            }
        }
        public void salvar(Produto produto)
        {
            if (produto.Id_Produto == 0)
            {
                using (MySqlCommand cmd = new MySqlCommand(@"insert into produto(nome, codigoNcm, precoDeVenda, Marca, precoDeCusto) values
	                    (@nome, @codigoNcm, @precoDeVenda, @Marca, @precoDeCusto);", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("nome", produto.Nome));
                    cmd.Parameters.Add(new MySqlParameter("codigoNcm", produto.CodigoNcm));
                    cmd.Parameters.Add(new MySqlParameter("precoDeVenda", produto.PrecoDeVenda));
                    cmd.Parameters.Add(new MySqlParameter("precoDeCusto", produto.PrecoDeCusto));
                    cmd.Parameters.Add(new MySqlParameter("Marca", produto.Marca));

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                }
            }
            else
            {
                using (MySqlCommand cmd = new MySqlCommand(@"update produto set nome = @nome, codigoNcm = @codigoNcm, precoDeVenda = @precoDeVenda, precoDeCusto = @precoDeCusto, Marca= @Marca where id_produto = @id_produto;", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("nome", produto.Nome));
                    cmd.Parameters.Add(new MySqlParameter("codigoNcm", produto.CodigoNcm));
                    cmd.Parameters.Add(new MySqlParameter("precoDeVenda", produto.PrecoDeVenda));
                    cmd.Parameters.Add(new MySqlParameter("precoDeCusto", produto.PrecoDeCusto));
                    cmd.Parameters.Add(new MySqlParameter("Marca", produto.Marca));
                    cmd.Parameters.Add(new MySqlParameter("id_produto", produto.Id_Produto));

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                }
            }
        }
    }
}
