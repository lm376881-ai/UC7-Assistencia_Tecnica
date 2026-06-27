using AssistenciaTec.Data;
using AssistenciaTec.View;

namespace AssistenciaTec
{
    public partial class FrmPrincipal : Form
    {
        private FrmClientes FrmClientes;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemConectar_Click(object sender, EventArgs e)
        {
            Conexao.GetConexao();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmClientes == null || FrmClientes.IsDisposed)
            {
                FrmClientes = new FrmClientes();
                FrmClientes.MdiParent = this;
                FrmClientes.Show();
            }
            else
            {
                if (FrmClientes.WindowState == FormWindowState.Minimized)
                {
                    FrmClientes.WindowState = FormWindowState.Normal;
                }

            }
        }
    }
}
    
