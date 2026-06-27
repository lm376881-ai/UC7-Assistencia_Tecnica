using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenciaTec.View
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            desabilitarBotoesSalvarCancelar();


        }

        private void desabilitarBotoesSalvarCancelar()
        {
            toolStripAdicionar.Enabled = true;
            toolStripEditar.Enabled = true;
            toolStripApagar.Enabled = true;
            toolStripSalvar.Enabled = false;
            toolStripCancelar.Enabled = false;
            groupBoxDadosCliente.Enabled = false;

        }

        private void habilitarBotoesSalvarCancelar()
        {
            toolStripAdicionar.Enabled = false;
            toolStripEditar.Enabled = false;
            toolStripApagar.Enabled = false;
            toolStripSalvar.Enabled = true;
            toolStripCancelar.Enabled = true;
            groupBoxDadosCliente.Enabled = true;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void toolStripAdicionar_Click(object sender, EventArgs e)
        {
            habilitarBotoesSalvarCancelar();
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripApagar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            desabilitarBotoesSalvarCancelar();
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            desabilitarBotoesSalvarCancelar();
        }
    }
}
