using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devPOO.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente menuCadastrarCliente = new frmCadastroCliente();

            menuCadastrarCliente.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja realmente sair?", 
                "Confirmar Saída.", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
