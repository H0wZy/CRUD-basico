using devPOO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using devPOO.Utilidades;

namespace devPOO.Forms
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public void radioCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCPF.Checked)
            {
                maskTipoDocumento.Mask = @"000\.000\.000\-00";
                labelTipoDocumento.Text = "CPF:";
                radioCNPJ.Checked = false;
            }
        }

        public void radioCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCNPJ.Checked)
            {
                maskTipoDocumento.Mask = @"00\.000\.000\/0000\-00";
                labelTipoDocumento.Text = "CNPJ:";
                radioCPF.Checked = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string retorno = "";
            Cliente cliente = new Cliente();

            cliente.IdCliente = Convert.ToInt64(numIdCliente.Value);
            cliente.Nome = txtNomeCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.Renda = numRendaCliente.Value;
            cliente.TipoDocumento = labelTipoDocumento.Text;
            cliente.NumDocumento = maskTipoDocumento.Text;

            if (radioCPF.Checked)
            {
                cliente.TipoDocumento = "CPF";
                maskTipoDocumento.Mask = @"000\.000\.000\-00";
                labelTipoDocumento.Text = "CPF:";
                radioCNPJ.Checked = false;
            }


            else
            {
                cliente.TipoDocumento = "CNPJ";
                maskTipoDocumento.Mask = @"00\.000\.000\/0000\-00";
                labelTipoDocumento.Text = "CNPJ:";
                radioCPF.Checked = false;
            }
     

            retorno = cliente.Create();

            if (retorno == "")
            {
                MessageBox.Show("Dados incluídos com sucesso!");
            }
            else
            {
                MessageBox.Show(retorno);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();



            cliente.IdCliente = Convert.ToInt64(numIdCliente.Value);

            string retorno = cliente.Read();

            numIdCliente.Value = Convert.ToInt64(cliente.IdCliente);
            txtNomeCliente.Text = cliente.Nome;
            txtEnderecoCliente.Text = cliente.Endereco;
            numRendaCliente.Value = cliente.Renda;
            labelTipoDocumento.Text = cliente.TipoDocumento;
            maskTipoDocumento.Text = cliente.NumDocumento;


            if (labelTipoDocumento.Text == "CPF")
            {
                cliente.TipoDocumento = "CPF";
                maskTipoDocumento.Mask = @"000\.000\.000\-00";
                radioCPF.Checked = true;
            }
            else if (labelTipoDocumento.Text == "CNPJ")
            {
                cliente.TipoDocumento = "CNPJ";
                maskTipoDocumento.Mask = @"00\.000\.000\/0000\-00";
                radioCNPJ.Checked = true;
            }



            if (retorno == "")
            {
                MessageBox.Show("Dados lidos com sucesso!");
            }
            else
            {
                MessageBox.Show(retorno);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string retorno = "";
            Cliente cliente = new Cliente();

            cliente.IdCliente = Convert.ToInt64(numIdCliente.Value);
            cliente.Nome = txtNomeCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.Renda = numRendaCliente.Value;
            cliente.TipoDocumento = labelTipoDocumento.Text;
            cliente.NumDocumento = maskTipoDocumento.Text;

            retorno = cliente.Update();

            if (retorno == "")
            {
                MessageBox.Show("Dados alterados com sucesso!");
            }
            else
            {
                MessageBox.Show(retorno);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string retorno = "";
            Cliente cliente = new Cliente();

            cliente.IdCliente = Convert.ToInt64(numIdCliente.Value);
            cliente.Nome = txtNomeCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.Renda = numRendaCliente.Value;
            cliente.TipoDocumento = labelTipoDocumento.Text;
            cliente.NumDocumento = maskTipoDocumento.Text;

            retorno = cliente.Delete();
            numIdCliente.Value = 0;
            txtNomeCliente.Text = "";
            txtEnderecoCliente.Text = "";
            numRendaCliente.Value = 0;
            maskTipoDocumento.Text = "";

            if (retorno == "")
            {
                MessageBox.Show("Dados deletados com sucesso!");
            }
            else
            {
                MessageBox.Show(retorno);
            }
        }

        private void frmCadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja realmente sair?\nQualquer alteração não salva será perdida.",
                "Confirmar Saída.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
