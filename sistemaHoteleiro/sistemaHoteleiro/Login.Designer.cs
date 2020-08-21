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
            this.label_user = new System.Windows.Forms.Label();
            this.label_passworld = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_esqueci_senha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(119, 316);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // User_text
            // 
            this.User_text.Location = new System.Drawing.Point(92, 241);
            this.User_text.Name = "User_text";
            this.User_text.Size = new System.Drawing.Size(135, 20);
            this.User_text.TabIndex = 1;
            // 
            // passworld_text
            // 
            this.passworld_text.Location = new System.Drawing.Point(92, 267);
            this.passworld_text.Name = "passworld_text";
            this.passworld_text.PasswordChar = '*';
            this.passworld_text.Size = new System.Drawing.Size(135, 20);
            this.passworld_text.TabIndex = 2;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(35, 248);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(43, 13);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "Usuario";
            // 
            // label_passworld
            // 
            this.label_passworld.AutoSize = true;
            this.label_passworld.Location = new System.Drawing.Point(35, 270);
            this.label_passworld.Name = "label_passworld";
            this.label_passworld.Size = new System.Drawing.Size(38, 13);
            this.label_passworld.TabIndex = 5;
            this.label_passworld.Text = "Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_esqueci_senha
            // 
            this.lbl_esqueci_senha.AutoSize = true;
            this.lbl_esqueci_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esqueci_senha.Location = new System.Drawing.Point(120, 290);
            this.lbl_esqueci_senha.Name = "lbl_esqueci_senha";
            this.lbl_esqueci_senha.Size = new System.Drawing.Size(107, 13);
            this.lbl_esqueci_senha.TabIndex = 7;
            this.lbl_esqueci_senha.Text = "Esqueci minha senha";
            this.lbl_esqueci_senha.Click += new System.EventHandler(this.lbl_esqueci_senha_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_esqueci_senha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_passworld);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.passworld_text);
            this.Controls.Add(this.User_text);
            this.Controls.Add(this.btn_Login);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Brown;
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
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_passworld;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_esqueci_senha;
        private System.Windows.Forms.Button button1;
    }
}

