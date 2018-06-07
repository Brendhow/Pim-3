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
    public class FornecedorDAO
    {
        MySqlConnection conexao { get; set; }
        public FornecedorDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Fornecedor> selecionarTodosFornecedores()
        {
            List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
            using (MySqlCommand cmd = new MySqlCommand("select * from fornecedor;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaFornecedores.Add(new Fornecedor()
                    {
                        Celular = reader["celular"].ToString(),
                        Cep = reader["cep"].ToString(),
                        Cnpj = reader["cnpj"].ToString(),
                        Complemento = reader["complemento"].ToString(),
                        Email = reader["email"].ToString(),
                        endereco = reader["Endereco"].ToString(),
                        Id_Fornecedor = Convert.ToInt32(reader["id_fornecedor"]),
                        Nome = reader["nome"].ToString(),
                        Numero = reader["numero"].ToString(),
                        Telefone = reader["telefone"].ToString()
                    });
                }
                conexao.Close();
                return ListaFornecedores;
            }
        }

        internal object selecionarTodosClientes()
        {
            throw new NotImplementedException();
        }

        public void salvar(Fornecedor fornecedor)
        {
            if (fornecedor.Id_Fornecedor == 0)
            {
                using (MySqlCommand cmd = new MySqlCommand(@"INSERT INTO fornecedor (nome,endereco,telefone,numero,complemento,cep,cnpj,celular,email,observacoes) VALUES (@nome,@endereco,@telefone,@numero,@complemento,@cep,@cnpj,@celular,@email,@observacoes);", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("nome", fornecedor.Nome));
                    cmd.Parameters.Add(new MySqlParameter("endereco", fornecedor.endereco));
                    cmd.Parameters.Add(new MySqlParameter("telefone", fornecedor.Telefone));
                    cmd.Parameters.Add(new MySqlParameter("numero", fornecedor.Numero));
                    cmd.Parameters.Add(new MySqlParameter("complemento", fornecedor.Complemento));
                    cmd.Parameters.Add(new MySqlParameter("cep", fornecedor.Cep));
                    cmd.Parameters.Add(new MySqlParameter("cnpj", fornecedor.Cnpj));
                    cmd.Parameters.Add(new MySqlParameter("celular", fornecedor.Celular));
                    cmd.Parameters.Add(new MySqlParameter("email", fornecedor.Email));
                    cmd.Parameters.Add(new MySqlParameter("observacoes", fornecedor.Observacoes));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (MySqlCommand cmd = new MySqlCommand(@"update cliente set nome = @nome, endereco = @endereco, numero = @numero, complemento = @complemento, cep= @cep, cnpj = @cnpj,
                        telefone = @telefone, celular = @celular, email = @email,  observacao = @observacao where id_fornecedor = @id_fornecedor;", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("nome", fornecedor.Nome));
                    cmd.Parameters.Add(new MySqlParameter("endereco", fornecedor.endereco));
                    cmd.Parameters.Add(new MySqlParameter("telefone", fornecedor.Telefone));
                    cmd.Parameters.Add(new MySqlParameter("numero", fornecedor.Numero));
                    cmd.Parameters.Add(new MySqlParameter("complemento", fornecedor.Complemento));
                    cmd.Parameters.Add(new MySqlParameter("cep", fornecedor.Cep));
                    cmd.Parameters.Add(new MySqlParameter("cnpj", fornecedor.Cnpj));
                    cmd.Parameters.Add(new MySqlParameter("celular", fornecedor.Celular));
                    cmd.Parameters.Add(new MySqlParameter("email", fornecedor.Email));
                    cmd.Parameters.Add(new MySqlParameter("observacoes", fornecedor.Observacoes));
                    cmd.Parameters.Add(new MySqlParameter("id_fornecedor", fornecedor.Id_Fornecedor));

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                }
            }
        }
    }
}
