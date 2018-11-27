using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes
{
    public partial class FormPessoa : Form
    {
        public FormPessoa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            //verificar radio button
            if (rbFeminino.Checked)
            {
                mensagem = "Olá Senhora, " + txtNome.Text;
            }else if (rbMasculino.Checked)
            {
                mensagem = "Olá Senhor, " + txtNome.Text;
            }

            mensagem = mensagem + "Seu estado civil é " + cbEstadoCivil.Text;

            mensagem = mensagem + " voce curte: ";
            if (cbPagode.Checked)
            {
                mensagem = mensagem + " Pagode ";
            }
            if (cbRock.Checked)
            {
                mensagem = mensagem + " Rock ";

            }if(cbSertanejo.Checked)
            {
                mensagem = mensagem + "Sertanejo";
            }
            


            txtResultado.Text = mensagem;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNome.Clear();
            txtResultado.Clear();
            cbSertanejo.Checked = false;
            cbRock.Checked = false;
            cbPagode.Checked = false;
            cbEstadoCivil.SelectedIndex = 0;

        }
    }
}
