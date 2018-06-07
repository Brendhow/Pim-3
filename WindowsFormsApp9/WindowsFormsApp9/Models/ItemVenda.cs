using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.Models
{
    public class ItemVenda
    {
        public int Id_ItemVenda { get; set; }
        public int Id_Venda { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}