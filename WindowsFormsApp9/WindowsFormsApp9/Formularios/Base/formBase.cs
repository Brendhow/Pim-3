using System;
using System.Windows.Forms;

namespace WindowsFormsApp9.Formularios.Base
{
    public partial class formBase : Form
    {
        public formBase()
        {
            InitializeComponent();
        }

        private void relatóriosDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama formulario de relatórios
            var formRelatorio = new formRelatorio();
            formRelatorio.MdiParent = this;
            formRelatorio.WindowState = FormWindowState.Maximized;
            formRelatorio.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // funcao de logout do usuario

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formBase_Load(object sender, EventArgs e)
        {

        }
    }
}