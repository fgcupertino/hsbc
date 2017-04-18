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
    public partial class fmrCadastroConta : Form
    {
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNovo;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbSalvar;
        private ToolStripButton tsbAlterar;
        private ToolStripButton tsbExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private Label lblNumero;
        private Label lblAgencia;
        private Label lblTipo;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private RadioButton rbtPoupanca;
        private RadioButton rbtCorrente;
        private MaskedTextBox mtbAgencia;
        private MaskedTextBox mtbNumero;
        private PictureBox pictureBox1;
        private ToolStripButton tsbBuscar;

        public Conta Conta { get; set; }

        int Id;
        

        public fmrCadastroConta()
        {
            InitializeComponent();
        }

        public fmrCadastroConta(Conta conta)
        {
            Conta = conta;
            InitializeComponent();
            
        }



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCadastroConta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.rbtPoupanca = new System.Windows.Forms.RadioButton();
            this.rbtCorrente = new System.Windows.Forms.RadioButton();
            this.mtbAgencia = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbSalvar,
            this.tsbAlterar,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(416, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbAlterar
            // 
            this.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterar.Image")));
            this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterar.Name = "tsbAlterar";
            this.tsbAlterar.Size = new System.Drawing.Size(23, 22);
            this.tsbAlterar.Text = "Alterar";
            this.tsbAlterar.Click += new System.EventHandler(this.tsbAlterar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click_1);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 65);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(20, 109);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(46, 13);
            this.lblAgencia.TabIndex = 1;
            this.lblAgencia.Text = "Agencia";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 146);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(20, 173);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(161, 173);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // rbtPoupanca
            // 
            this.rbtPoupanca.AutoSize = true;
            this.rbtPoupanca.Checked = true;
            this.rbtPoupanca.Location = new System.Drawing.Point(142, 146);
            this.rbtPoupanca.Name = "rbtPoupanca";
            this.rbtPoupanca.Size = new System.Drawing.Size(74, 17);
            this.rbtPoupanca.TabIndex = 3;
            this.rbtPoupanca.TabStop = true;
            this.rbtPoupanca.Text = "Poupança";
            this.rbtPoupanca.UseVisualStyleBackColor = true;
            // 
            // rbtCorrente
            // 
            this.rbtCorrente.AutoSize = true;
            this.rbtCorrente.Location = new System.Drawing.Point(236, 146);
            this.rbtCorrente.Name = "rbtCorrente";
            this.rbtCorrente.Size = new System.Drawing.Size(65, 17);
            this.rbtCorrente.TabIndex = 3;
            this.rbtCorrente.Text = "Corrente";
            this.rbtCorrente.UseVisualStyleBackColor = true;
            // 
            // mtbAgencia
            // 
            this.mtbAgencia.Location = new System.Drawing.Point(161, 106);
            this.mtbAgencia.Mask = "0000-0";
            this.mtbAgencia.Name = "mtbAgencia";
            this.mtbAgencia.Size = new System.Drawing.Size(55, 20);
            this.mtbAgencia.TabIndex = 4;
            // 
            // mtbNumero
            // 
            this.mtbNumero.Location = new System.Drawing.Point(161, 62);
            this.mtbNumero.Mask = "00.000-0";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(55, 20);
            this.mtbNumero.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(270, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fmrCadastroConta
            // 
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(416, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.mtbAgencia);
            this.Controls.Add(this.rbtCorrente);
            this.Controls.Add(this.rbtPoupanca);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmrCadastroConta";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.fmrCadastroConta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void fmrCadastroConta_Load(object sender, EventArgs e)
        {
            
        }

        public void RetornoConsulta()
        {
            Id = Conta.id;
            mtbNumero.Text = Conta.Numero;
            mtbAgencia.Text = Conta.Agencia;

            if (Conta.Tipo.Equals("Poupança"))
            {
                rbtPoupanca.Checked = true;
            }
            else
            {
                rbtCorrente.Checked = true;
            }
            txtSaldo.Text = Conta.Saldo.ToString();
            
        }

        SqlConnection SqlCon = null;
        private string strConexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBanco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string strSql = string.Empty;
        

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            /*strSql = "insert into Contas (Numero, Agencia, Tipo, Saldo) values (@Numero, @Agencia, @Tipo, @Saldo)";
            SqlCon = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(strSql, SqlCon);

            comando.Parameters.Add("@Numero", SqlDbType.NChar).Value = mtbNumero.Text;
            comando.Parameters.Add("@Agencia", SqlDbType.NChar).Value = mtbAgencia.Text;
            if (rbtCorrente.Checked)
            {
                comando.Parameters.Add("@Tipo", SqlDbType.NChar).Value = rbtCorrente.Text;
            }
            else
            {
                comando.Parameters.Add("@Tipo", SqlDbType.NChar).Value = rbtPoupanca.Text;
            }

            comando.Parameters.Add("@Saldo", SqlDbType.NChar).Value = txtSaldo.Text;

            try
                {
                    SqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Concluido!!!");
                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            finally
                {
                    SqlCon.Close();

            }

    */
            string Numero = Convert.ToString(mtbNumero);
            string Agencia = Convert.ToString(mtbAgencia);
            string Tipo;
            if (rbtCorrente.Checked)
            {
                Tipo =  rbtCorrente.Text;
            }
            else
            {
               Tipo = rbtPoupanca.Text;
            }
            decimal Saldo = Convert.ToDecimal(txtSaldo.Text);

            ConexaoBD bd = new ConexaoBD();
            bd.Inserir(Numero, Agencia,Tipo, Saldo);
              
            tsbNovo.Enabled = true;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbSalvar.Enabled = true;
            mtbNumero.Text = "";
            mtbAgencia.Text = "";
            txtSaldo.Text = " ";
        }

               
        /*public List<Conta> Consultar()
        {
            List<Conta> lstContas = new List<Conta>();
            strSql = "select *from Contas";
            SqlCon = new SqlConnection(strConexao);

            SqlCommand comando = new SqlCommand(strSql, SqlCon);
            {
                SqlCon.Open();
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



                SqlCon.Close();
            }

          return lstContas;
        }*/

        private void tsbBuscar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FmrSelCadastro fmrSelecao = new FmrSelCadastro();
            fmrSelecao.Show();

            tsbNovo.Enabled = false;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbSalvar.Enabled = false;
            mtbNumero.Text = "";
            mtbAgencia.Text = "";
            txtSaldo.Text = " ";

        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {


            string Numero = Convert.ToString(mtbNumero);
            string Agencia = Convert.ToString(mtbAgencia);
            string Tipo;
            if (rbtCorrente.Checked)
            {
                Tipo = rbtCorrente.Text;
            }
            else
            {
                Tipo = rbtPoupanca.Text;
            }
            decimal Saldo = Convert.ToDecimal(txtSaldo.Text);

            ConexaoBD bd = new ConexaoBD();
            bd.Alterar(Conta.id, Numero, Agencia, Tipo, Saldo);

            /*

            strSql = "update Contas set Numero=@Numero, Agencia=@Agencia, Tipo=@Tipo, Saldo=@Saldo where Id=@Id";
            SqlCon = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(strSql, SqlCon);

            comando.Parameters.Add("@Id", Conta.id);
            comando.Parameters.Add("@Numero", Conta.Numero);
            comando.Parameters.Add("@Agencia", Conta.Agencia);
            if (rbtCorrente.Checked)
            {
                comando.Parameters.Add("@Tipo", SqlDbType.NChar).Value = rbtCorrente.Text;
            }
            else
            {
                comando.Parameters.Add("@Tipo", SqlDbType.NChar).Value = rbtPoupanca.Text;
            }

            comando.Parameters.Add("@Saldo", SqlDbType.NChar).Value = txtSaldo.Text;
            

            try
            {
                SqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Alteração Concluida!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlCon.Close();
            }

            */
            tsbNovo.Enabled = true;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbSalvar.Enabled = false;
            mtbNumero.Text = "";
            mtbAgencia.Text = "";
            txtSaldo.Text = " ";
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            ConexaoBD bd = new ConexaoBD();
            bd.Deletar(Conta.id);
            /*if (MessageBox.Show("Deseja realmente Excluir essa Conta?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!!!");

            }
            else
            {
                strSql = "delete from Contas where Id=@Id";
                SqlCon = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, SqlCon);

                comando.Parameters.Add("@Id", Conta.id);
                try
                {
                    SqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Conta Deletada com Sucesso!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally {

                    SqlCon.Close();
                }
            }
            */
            
            tsbNovo.Enabled = true;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbSalvar.Enabled = true;
            mtbNumero.Text = "";
            mtbAgencia.Text = "";
            txtSaldo.Text = " ";
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {

            tsbNovo.Enabled = false;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = false;
            tsbSalvar.Enabled = true;
            mtbNumero.Text = "";
            mtbAgencia.Text = "";
            txtSaldo.Text = " ";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbSalvar.Enabled = true;
            mtbNumero.Text = "";
            mtbAgencia.Text = "";
            txtSaldo.Text = " ";
        }
    }
}
    

