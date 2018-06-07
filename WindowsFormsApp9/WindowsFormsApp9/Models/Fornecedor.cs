using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.Models
{
    public class Fornecedor
    {
        public int Id_Fornecedor { get; set; }
        public string Nome { get; set; }
        public string endereco { get; set; }
        public string Telefone { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cnpj { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }
    }
}
