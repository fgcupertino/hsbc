namespace HSBC
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saque";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Transferencia";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Deposito";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Saldo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(1, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cadastro";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 281);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}