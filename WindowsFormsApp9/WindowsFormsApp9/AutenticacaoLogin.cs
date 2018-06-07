using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    class AutenticacaoLogin
    {

        public string name { get; set; }
        public string password { get; set; }


        public void login(string name1, string password1)
        {
            name = name1;
            password = password1;
        }

        public void logout()
        {
            name = null;
            password = null;
            Application.Exit();
        }
    }
}
