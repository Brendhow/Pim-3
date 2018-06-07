using System.Windows.Forms;

namespace WindowsFormsApp9.Formulários
{
    
    public partial class formTelaPrincipal : Formularios.Base.formBase
    {

        Formularios.formCadastroMateriais frmCadastroMateriais = new Formularios.formCadastroMateriais();
        Formularios.formRelatorio frmRelatorio = new Formularios.formRelatorio();
        Formularios.formVendas frmVendas = new Formularios.formVendas();
        Formularios.formCadastroFornecedor frmCadastroFornecedor = new Formularios.formCadastroFornecedor();
        Formularios.formCadastroCliente frmCadastroCliente = new Formularios.formCadastroCliente();
        Formularios.formLancamentoNotas frmLancamentoNota = new Formularios.formLancamentoNotas();


        public void openTela(Form formAdd/*, Form formRemove*/)
        {
            formAdd.TopLevel = false;
            formAdd.AutoScroll = false;
            //formRemove?.Hide();
            //panelForms.Controls.Remove(formRemove);
            frmCadastroMateriais.Hide();
            panelForms.Controls.Remove(frmCadastroMateriais);
            frmRelatorio.Hide();
            panelForms.Controls.Remove(frmRelatorio);
            frmVendas.Hide();
            panelForms.Controls.Remove(frmVendas);
            frmCadastroFornecedor.Hide();
            panelForms.Controls.Remove(frmCadastroFornecedor);
            frmCadastroCliente.Hide();
            panelForms.Controls.Remove(frmCadastroCliente);
            panelForms.Controls.Add(formAdd);            
            formAdd.StartPosition = FormStartPosition.CenterParent;
            formAdd.Show();

            //if(formAdd.FormClosed() == true)
            //{
            //    Show();
            //}
            //formAdd.Show();
        }

        public formTelaPrincipal()
        {
            InitializeComponent();
        }

        private void formTelaPrincipal_Load(object sender, System.EventArgs e)
        {
            
        }

        private void button3_Click(object sender, System.EventArgs e)
        {

        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void pnlBotoes_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.openTela(frmCadastroCliente);
            
        }

        private void backupToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void panelForms_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
                
        }

        private void fornecedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            this.openTela(frmCadastroFornecedor);
            
        }

        private void vendasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
            this.openTela(frmVendas);
       
        }

        private void entradaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.openTela(frmVendas);
        }

        private void toolStripButton5_Click(object sender, System.EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void materiaisToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.openTela(frmCadastroMateriais);
        }

        private void entMercadoriasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.openTela(frmLancamentoNota);
        }

        private void btnRelatórioDeVendaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.openTela(frmRelatorio);
        }

        private void btnRelatórioDeEstoqueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            this.openTela(frmRelatorio);
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            this.openTela(frmVendas);
        }

        private void toolStripButton7_Click(object sender, System.EventArgs e)
        {
            this.openTela(frmLancamentoNota);
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            this.openTela(frmCadastroCliente);
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
