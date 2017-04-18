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
    public partial class fmrTransferencia : Form
    {
        public fmrTransferencia()
        {
            InitializeComponent();
        }
        int id;
        string Numero;
        string Agencia;
        string Tipo;
        decimal Saldo;
        string Saldo1;
        string Saldo2;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();

        private void Tranferencia_Load(object sender, EventArgs e)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao;
            comando.CommandText = "Select *from Contas";
            SqlDataReader reader = comando.ExecuteReader();
            dt1.Load(reader);
            
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Numero";
            comboBox1.DataSource = dt1;
            comboBox1.SelectedIndex = -1;

            SqlConnection Conexao2 = new SqlConnection();
            Conexao2.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Conexao2.Open();
            SqlCommand comando2 = new SqlCommand();
            comando2.Connection = Conexao2;
            comando2.CommandText = "Select *from Contas";
            SqlDataReader reader2 = comando.ExecuteReader();

            dt2.Load(reader2);
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Numero";
            comboBox2.DataSource = dt2;
            comboBox2.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saldo1 = dt1.Rows[Convert.ToInt32(comboBox1.SelectedIndex)]["Saldo"].ToString();
            int Id = Convert.ToInt32(comboBox1.SelectedValue);
            decimal valor = Convert.ToDecimal(textBox1.Text);
            Conta conta = new Conta();
            Saldo = (Convert.ToDecimal(Saldo1) - valor);
            
            
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
               // MessageBox.Show("Transferencia Concluida!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }



            Saldo2 = dt2.Rows[Convert.ToInt32(comboBox2.SelectedIndex)]["Saldo"].ToString();
            int Id2 = Convert.ToInt32(comboBox2.SelectedValue);
            decimal valor2 = Convert.ToDecimal(textBox1.Text);
            Saldo = (Convert.ToDecimal(Saldo2) + valor);
            Id = Id2;
            SqlConnection Conexao2 = new SqlConnection();
            Conexao2.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand comando2 = new SqlCommand();
            comando2.Connection = Conexao2;

            comando2.CommandText = "update Contas set Saldo = @Saldo where Id=@Id";
            comando2.Parameters.Add("@Id", Id);
            comando2.Parameters.Add("@Saldo", SqlDbType.NChar).Value = Saldo;



            try
            {
                Conexao2.Open();
                comando2.ExecuteNonQuery();
                MessageBox.Show("Transferencia Concluida!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao2.Close();
            }

            this.Hide();
        }
    }
}
