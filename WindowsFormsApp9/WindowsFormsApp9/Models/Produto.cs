using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.Models
{
    public class Produto
    {
        public int Id_Produto { get; set; }
        public string Nome { get; set; }
        public string CodigoNcm { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoDeVenda { get; set; }
        public string Marca { get; set; }
        public decimal PrecoDeCusto { get; set; }

    }
}