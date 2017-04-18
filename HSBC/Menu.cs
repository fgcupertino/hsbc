using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSBC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrSaque saque = new fmrSaque();
            saque.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDepositar deposito = new frmDepositar();
            deposito.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmrCadastroConta cadastro = new fmrCadastroConta();
            cadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmrTransferencia transferencia = new fmrTransferencia();
            transferencia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FmrSelCadastro saldo = new FmrSelCadastro();
            saldo.Show();
        }
    }
}
