using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSBC
{
    public partial class FmrSelCadastro : Form

    { 

        public FmrSelCadastro()
        {
            
            InitializeComponent();
        }


        private void FmrSelCadastro_Load(object sender, EventArgs e)
        {
            CarregaGridView();
        }

        private void CarregaGridView() {

            ConexaoBD bd = new ConexaoBD();
            List<Conta> lstDados = new List<Conta>();
            lstDados = bd.Consultar();
            dataGridView1.DataSource = lstDados;
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            Conta linha = dataGridView1.SelectedRows[0].DataBoundItem as Conta;
            fmrCadastroConta fmrEdit = new fmrCadastroConta(linha);
            fmrEdit.RetornoConsulta();
            this.Hide();
            fmrEdit.Show();

            
        }


    }
}
