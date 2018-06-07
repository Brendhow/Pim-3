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
    public class EntradaMercadoriaDAO
    {
        MySqlConnection conexao { get; set; }
        public EntradaMercadoriaDAO()
        {
            conexao = new ConnectionFactory().CriarConexao();
        }
        public List<EntradaMercadoria> selecionarTodosClientes()
        {
            List<EntradaMercadoria> ListaClientes = new List<EntradaMercadoria>();
            using (MySqlCommand cmd = new MySqlCommand("select * from entradaMercadorias;", conexao))
            {
                conexao.Open();
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var fornecedor = new Fornecedor()
                    {

                    };

                    ListaClientes.Add(new EntradaMercadoria()
                    {
                        Id_EntradaMercadoria = Convert.ToInt32(reader["Id_EntradaMercadoria"]),
                        Data = Convert.ToDateTime(reader["dataMerc"]),
                        fornecedor = reader["fornecedor"].ToString(),
                        codigoCupom = reader["codigoCupom"].ToString()
                    });
                }
                conexao.Close();
                return ListaClientes;
            }
        }
        public void salvar(EntradaMercadoria entradaMercadoria)
        {
            if (entradaMercadoria.Id_EntradaMercadoria == 0)
            {
                using (MySqlCommand cmd = new MySqlCommand(@"insert into cliente(nome, endereco, numero, complemento, cep, cpf,telefone, celular, email, aniversario, observacoes) values
	                    (@nome, @endereco, @numero, @complemento, @cep, @cpf,@telefone, @celular, @email, @aniversario, @observacoes);", conexao))
                {
                    conexao.Open();
                    cmd.Parameters.Add(new MySqlParameter("fornecedor", entradaMercadoria.fornecedor));
                    cmd.Parameters.Add(new MySqlParameter("codigoCupom", entradaMercadoria.codigoCupom));
                    cmd.Parameters.Add(new MySqlParameter("dataMerc", entradaMercadoria.Data));
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
                    //conexao.Open();
                    //cmd.Parameters.Add(new MySqlParameter("nome", cliente.nome));
                    //cmd.Parameters.Add(new MySqlParameter("endereco", cliente.endereco));
                    //cmd.Parameters.Add(new MySqlParameter("numero", cliente.numero));
                    //cmd.Parameters.Add(new MySqlParameter("complemento", cliente.complemento));
                    //cmd.Parameters.Add(new MySqlParameter("cep", cliente.cep));
                    //cmd.Parameters.Add(new MySqlParameter("cpf", cliente.cpf));
                    //cmd.Parameters.Add(new MySqlParameter("telefone", cliente.telefone));
                    //cmd.Parameters.Add(new MySqlParameter("celular", cliente.celular));
                    //cmd.Parameters.Add(new MySqlParameter("email", cliente.email));
                    //cmd.Parameters.Add(new MySqlParameter("aniversario", cliente.aniversario));
                    //cmd.Parameters.Add(new MySqlParameter("observacoes", cliente.obs));
                    //cmd.Parameters.Add(new MySqlParameter("id_cliente", cliente.id_cliente));

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conexao.Close();
                }
            }
        }
    }
}
