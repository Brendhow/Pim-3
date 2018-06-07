using System.Windows.Forms;

namespace WindowsFormsApp9.Formularios
{
    public partial class formRelatorio : Form
    {
        public formRelatorio()
        {
            InitializeComponent();
        }

        private void formRelatorio_Load(object sender, System.EventArgs e)
        {
            Opacity = 0;
            WindowState = FormWindowState.Maximized;
            Opacity = 100;
        }
    }
}
