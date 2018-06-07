using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Factory;
using WindowsFormsApp9.Models;
using System.Windows.Forms;

namespace WindowsFormsApp9.DAO
{
    public class ClienteDAO
    {
        MySqlConnection conexao { get; set; }
        public ClienteDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }

        public List<Cliente> selecionarTodosClientes()
        {
            List<Cliente> ListaClientes = new List<Cliente>();
            using (MySqlCommand cmd = new MySqlCommand("select * from cliente;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListaClientes.Add(new Cliente()
                    {
                        id_cliente = Convert.ToInt32(reader["id_cliente"]),
                        nome = reader["nome"].ToString(),
                        endereco = reader["endereco"].ToString(),
                        numero = reader["numero"].ToString(),
                        complemento = reader["complemento"].ToString(),
                        cep = reader["cep"].ToString(),
                        celular = reader["celular"].ToString(),
                        telefone = reader["telefone"].ToString(),
                        email = reader["email"].ToString(),
                        //aniversario = reader["aniversario"].(),
                        aniversario = Convert.ToDateTime(reader["aniversario"]),
                        cpf = reader["cpf"].ToString(),
                        obs = reader["observacoes"].ToString()
                    });
                }
                conexao.Close();
                return ListaClientes;
            }
        }

        public void salvar(Cliente cliente)
        {
            if (cliente.id_cliente == 0)
            {
                using (MySqlCommand cmd = new MySqlCommand(@"insert into cliente(nome, endereco, numero, complemento, cep, cpf,telefone, celular, email, aniversario, observacoes) values
	                    (@nome, @endereco, @numero, @complemento, @cep, @cpf,@telefone, @celular, @email, @aniversario, @observacoes);", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("nome", cliente.nome));
                    cmd.Parameters.Add(new MySqlParameter("endereco", cliente.endereco));
                    cmd.Parameters.Add(new MySqlParameter("numero", cliente.numero));
                    cmd.Parameters.Add(new MySqlParameter("complemento", cliente.complemento));
                    cmd.Parameters.Add(new MySqlParameter("cep", cliente.cep));
                    cmd.Parameters.Add(new MySqlParameter("cpf", cliente.cpf));
                    cmd.Parameters.Add(new MySqlParameter("telefone", cliente.telefone));
                    cmd.Parameters.Add(new MySqlParameter("celular", cliente.celular));
                    cmd.Parameters.Add(new MySqlParameter("email", cliente.email));
                    cmd.Parameters.Add(new MySqlParameter("aniversario", cliente.aniversario));
                    cmd.Parameters.Add(new MySqlParameter("observacoes", cliente.obs));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            else
            {
                using (MySqlCommand cmd = new MySqlCommand(@"update cliente set nome = @nome, endereco = @endereco, numero = @numero, complemento = @complemento, cep= @cep, cpf = @cpf,
                    telefone = @telefone, celular = @celular, email = @email, aniversario = @aniversario, observacoes = @observacoes where id_cliente = @id_cliente;", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("nome", cliente.nome));
                    cmd.Parameters.Add(new MySqlParameter("endereco", cliente.endereco));
                    cmd.Parameters.Add(new MySqlParameter("numero", cliente.numero));
                    cmd.Parameters.Add(new MySqlParameter("complemento", cliente.complemento));
                    cmd.Parameters.Add(new MySqlParameter("cep", cliente.cep));
                    cmd.Parameters.Add(new MySqlParameter("cpf", cliente.cpf));
                    cmd.Parameters.Add(new MySqlParameter("telefone", cliente.telefone));
                    cmd.Parameters.Add(new MySqlParameter("celular", cliente.celular));
                    cmd.Parameters.Add(new MySqlParameter("email", cliente.email));
                    cmd.Parameters.Add(new MySqlParameter("aniversario", cliente.aniversario));
                    cmd.Parameters.Add(new MySqlParameter("observacoes", cliente.obs));
                    cmd.Parameters.Add(new MySqlParameter("id_cliente", cliente.id_cliente));

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                }
            }
        }
    }
}
