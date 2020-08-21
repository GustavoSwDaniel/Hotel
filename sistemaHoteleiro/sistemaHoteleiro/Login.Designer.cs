namespace sistemaHoteleiro
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Login = new System.Windows.Forms.Button();
            this.User_text = new System.Windows.Forms.TextBox();
            this.passworld_text = new System.Windows.Forms.TextBox();
            this.btn_firtAss = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label_passworld = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(117, 300);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // User_text
            // 
            this.User_text.Location = new System.Drawing.Point(92, 216);
            this.User_text.Name = "User_text";
            this.User_text.Size = new System.Drawing.Size(135, 20);
            this.User_text.TabIndex = 1;
            // 
            // passworld_text
            // 
            this.passworld_text.Location = new System.Drawing.Point(92, 252);
            this.passworld_text.Name = "passworld_text";
            this.passworld_text.PasswordChar = '*';
            this.passworld_text.Size = new System.Drawing.Size(135, 20);
            this.passworld_text.TabIndex = 2;
            // 
            // btn_firtAss
            // 
            this.btn_firtAss.Location = new System.Drawing.Point(101, 339);
            this.btn_firtAss.Name = "btn_firtAss";
            this.btn_firtAss.Size = new System.Drawing.Size(106, 23);
            this.btn_firtAss.TabIndex = 3;
            this.btn_firtAss.Text = "Primeiro Acesso";
            this.btn_firtAss.UseVisualStyleBackColor = true;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(47, 219);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(29, 13);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "User";
            // 
            // label_passworld
            // 
            this.label_passworld.AutoSize = true;
            this.label_passworld.Location = new System.Drawing.Point(26, 255);
            this.label_passworld.Name = "label_passworld";
            this.label_passworld.Size = new System.Drawing.Size(55, 13);
            this.label_passworld.TabIndex = 5;
            this.label_passworld.Text = "Passworld";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_passworld);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.btn_firtAss);
            this.Controls.Add(this.passworld_text);
            this.Controls.Add(this.User_text);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login Hotel Matilha";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox User_text;
        private System.Windows.Forms.TextBox passworld_text;
        private System.Windows.Forms.Button btn_firtAss;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_passworld;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

