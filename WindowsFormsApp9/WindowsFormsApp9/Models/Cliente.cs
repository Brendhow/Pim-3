using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.Models
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public DateTime aniversario { get; set; }
        public string obs { get; set; }
    }
}
