using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HSBC
{
    public partial class frmDepositar : Form
    {
        public frmDepositar()
        {
            InitializeComponent();
        }
        int id;
        string Numero;
        string Agencia;
        string Tipo;
        decimal Saldo;
        string Saldo1;

        DataTable dt = new DataTable();

       private void Depositar_Load(object sender, EventArgs e)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao;
            comando.CommandText = "Select *from Contas";
            SqlDataReader reader = comando.ExecuteReader();
            dt.Load(reader);

            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Numero";
            comboBox1.DataSource = dt;
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saldo1 = dt.Rows[Convert.ToInt32(comboBox1.SelectedIndex)]["Saldo"].ToString();
            int Id = Convert.ToInt32(comboBox1.SelectedValue);
            decimal valor = Convert.ToDecimal(textBox1.Text);
            Conta conta = new Conta();
            Saldo = (Convert.ToDecimal(Saldo1) + valor);
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao;
            comando.CommandText = "update Contas set Saldo = @Saldo where Id=@Id";
            comando.Parameters.Add("@Id", Id);
            comando.Parameters.Add("@Saldo", SqlDbType.NChar).Value = Saldo;

            try
            {
                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Deposito Concluido!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

            this.Hide();

        }
    }
}
