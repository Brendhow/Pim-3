using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.Factory
{
    public class ConnectionFactory
    {
        public MySqlConnection CriarConexao()
        {
            var conexao = new MySqlConnection("server=localhost;user id=root;password=;port=3306;database=pim;SslMode=none");
            return conexao;
        }

    }
}
