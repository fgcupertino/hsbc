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
    public partial class fmrSaque : Form
    {
        public fmrSaque()
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
        private void fmrSaque_Load_1(object sender, EventArgs e)
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
            Tipo = dt.Rows[Convert.ToInt32(comboBox1.SelectedIndex)]["Tipo"].ToString();
            int Id = Convert.ToInt32(comboBox1.SelectedValue);
            decimal valor = Convert.ToDecimal(textBox1.Text);
            decimal retorno=0;
            if (Tipo == "Poupança")
            {
                Conta c = new ContaPoupanca();
                retorno = c.Sacar(valor);
            }
            else
            {
                Conta c = new ContaCorrente();
             retorno =  c.Sacar(valor);
            }
                Saldo = (Convert.ToDecimal(Saldo1)- retorno);
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao;
            comando.CommandText = "update Contas set Saldo = @Saldo where Id=@Id";
            comando.Parameters.Add("@Id", Id);
            comando.Parameters.Add("@Saldo", Saldo);

            try
            {    
                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Saque Concluido!!!");
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
