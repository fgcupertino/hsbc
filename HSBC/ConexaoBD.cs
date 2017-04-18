using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSBC
{


    public class ConexaoBD
    {
       
        SqlConnection conexao = new SqlConnection();
        public ConexaoBD()
        {

            var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conexao = new SqlConnection(caminho);
            //conexao.Open();


        }


       
        public List<Conta> Consultar()
        {
           
            List<Conta> lstContas = new List<Conta>();
            var sql = "select * from Contas";
            var comando = new SqlCommand(sql, conexao);
            conexao.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Conta conta = new Conta();
                    conta.id = Convert.ToInt32(reader["Id"].ToString());
                    conta.Numero = reader["Numero"].ToString();
                    conta.Agencia = reader["Agencia"].ToString();
                    conta.Tipo = reader["Tipo"].ToString();
                    conta.Saldo = Convert.ToDecimal(reader["Saldo"].ToString());
                    lstContas.Add(conta);
                }

                reader.Close();
            }



            conexao.Close();


            return lstContas;
        }


        public void Inserir(string Numero, string Tipo, string Agencia, decimal Saldo)
        {
            conexao.Open();
            SqlTransaction transacao = conexao.BeginTransaction();
            SqlCommand comando = conexao.CreateCommand();
            comando.Transaction = transacao;
            //var sql = "insert into Contas (Numero, Agencia, Tipo, Saldo) values (@Numero, @Agencia, @Tipo, @Saldo)";

            try
            {
                comando.CommandText= "insert into Contas (Numero, Agencia, Tipo, Saldo) values (@Numero, @Agencia, @Tipo, @Saldo)";
                comando.Parameters.Add("@Numero", Numero);
                comando.Parameters.Add("@Agencia", Agencia);
                comando.Parameters.Add("@Tipo", Tipo);
                comando.Parameters.Add("@Saldo", Saldo);
                comando.ExecuteNonQuery();
                transacao.Commit();
                MessageBox.Show("Cadastro Concluido!!!");

            }
            catch (Exception)
            {
                transacao.Rollback();
            }
            /*var comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.Add("@Numero", Numero);
            comando.Parameters.Add("@Agencia", Agencia);
            comando.Parameters.Add("@Tipo", Tipo);
            comando.Parameters.Add("@Saldo", Saldo);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Concluido!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
                */
        }

        public void Alterar(int Id, String Numero, String Agencia, String Tipo, decimal Saldo)
        {
            var sql = "update Contas set Numero=@Numero, Agencia=@Agencia, Tipo=@Tipo, Saldo=@Saldo where Id=@Id";
            var comando = new SqlCommand(sql, conexao);
            
            comando.Parameters.Add("@Id", Id);
            comando.Parameters.Add("@Numero", Numero);
            comando.Parameters.Add("@Agencia", Agencia);
            comando.Parameters.Add("@Tipo", Tipo);
            comando.Parameters.Add("@Saldo", Saldo);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Alteração Concluida!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Deletar(int Id)
        {
            if (MessageBox.Show("Deseja realmente Excluir essa Conta?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!!!");

            }
            else
            {
                var sql = "delete from Contas where Id=@Id";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.Add("@Id", Id);
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Conta Deletada com Sucesso!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {

                    conexao.Close();
                }
            }

        }


    }
}

