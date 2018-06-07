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
    public class EnderecoDAO
    {
        MySqlConnection conexao { get; set; }
        public EnderecoDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Models.Endereco> SelecionarTodosEndereco()
        {
            List<Models.Endereco> ListaClientes = new List<Models.Endereco>();
            using (MySqlCommand cmd = new MySqlCommand("select * from endereco;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaClientes.Add(new Models.Endereco()
                    {
                        Id_Endereco = Convert.ToInt32(reader["id_endereco"]),
                        Rua = reader["rua"].ToString(),
                        Bairro = reader["bairro"].ToString(),
                        Numero = Convert.ToInt32(reader["numero"]),


                    });
                }
                conexao.Close();
                return ListaClientes;
            }
        }

        public void salvar(Endereco endereco)
        {
            if (endereco.Id_Endereco == 0)
            {
                using (MySqlCommand cmd = new MySqlCommand(@"insert into endereco(nome, endereco, numero) values
	                    (@rua, @bairro, @numero);", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("rua", endereco.Rua));
                    cmd.Parameters.Add(new MySqlParameter("bairro", endereco.Bairro));
                    cmd.Parameters.Add(new MySqlParameter("numero", endereco.Numero));
                    cmd.Parameters.Add(new MySqlParameter("cep", endereco.Cep));

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                }
            }
            else
            {
                using (MySqlCommand cmd = new MySqlCommand(@"update cliente set nome = @nome, endereco = @endereco, numero = @numero, complemento = @complemento, cep= @cep, cpf = @cpf,
                    telefone = @telefone, celular = @celular, email = @email, aniversario = @aniversario, observacao = @observacao where idCliente = @idCliente;", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("id_endereco", endereco.Id_Endereco));
                    cmd.Parameters.Add(new MySqlParameter("rua", endereco.Rua));
                    cmd.Parameters.Add(new MySqlParameter("bairro", endereco.Bairro));
                    cmd.Parameters.Add(new MySqlParameter("numero", endereco.Numero));
                    cmd.Parameters.Add(new MySqlParameter("cep", endereco.Cep));


                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                }
            }
        }
    }
}
