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
            this.components = new System.ComponentModel.Container();
            this.btn_Login = new System.Windows.Forms.Button();
            this.User_text = new System.Windows.Forms.TextBox();
            this.passworld_text = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_passworld = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_login_invalido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exite = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(91)))), ((int)(((byte)(38)))));
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(493, 143);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(154, 33);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // User_text
            // 
            this.User_text.Location = new System.Drawing.Point(466, 73);
            this.User_text.Name = "User_text";
            this.User_text.Size = new System.Drawing.Size(219, 20);
            this.User_text.TabIndex = 1;
            // 
            // passworld_text
            // 
            this.passworld_text.Location = new System.Drawing.Point(466, 99);
            this.passworld_text.Name = "passworld_text";
            this.passworld_text.PasswordChar = '*';
            this.passworld_text.Size = new System.Drawing.Size(219, 20);
            this.passworld_text.TabIndex = 2;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(403, 78);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(57, 15);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "Usuario";
            // 
            // label_passworld
            // 
            this.label_passworld.AutoSize = true;
            this.label_passworld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label_passworld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passworld.Location = new System.Drawing.Point(412, 102);
            this.label_passworld.Name = "label_passworld";
            this.label_passworld.Size = new System.Drawing.Size(48, 15);
            this.label_passworld.TabIndex = 5;
            this.label_passworld.Text = "Senha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(91)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(493, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Esqueci minha senha";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_login_invalido
            // 
            this.lbl_login_invalido.AutoSize = true;
            this.lbl_login_invalido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.lbl_login_invalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_invalido.ForeColor = System.Drawing.Color.Red;
            this.lbl_login_invalido.Location = new System.Drawing.Point(463, 122);
            this.lbl_login_invalido.Name = "lbl_login_invalido";
            this.lbl_login_invalido.Size = new System.Drawing.Size(112, 13);
            this.lbl_login_invalido.TabIndex = 9;
            this.lbl_login_invalido.Text = "Senha ou cpf invalido!";
            this.lbl_login_invalido.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_exite);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 24);
            this.panel1.TabIndex = 10;
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(774, 0);
            this.btn_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(28, 24);
            this.btn_min.TabIndex = 11;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_exite
            // 
            this.btn_exite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_exite.FlatAppearance.BorderSize = 0;
            this.btn_exite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exite.ForeColor = System.Drawing.Color.White;
            this.btn_exite.Location = new System.Drawing.Point(802, 0);
            this.btn_exite.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exite.Name = "btn_exite";
            this.btn_exite.Size = new System.Drawing.Size(20, 24);
            this.btn_exite.TabIndex = 11;
            this.btn_exite.Text = "X";
            this.btn_exite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exite.UseVisualStyleBackColor = true;
            this.btn_exite.Click += new System.EventHandler(this.btn_exite_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaHoteleiro.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 260);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.circularProgressBar1.InnerMargin = 0;
            this.circularProgressBar1.InnerWidth = 0;
            this.circularProgressBar1.Location = new System.Drawing.Point(541, 177);
            this.circularProgressBar1.MarqueeAnimationSpeed = 3800;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(91)))), ((int)(((byte)(38)))));
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.RightToLeftLayout = true;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.circularProgressBar1.Size = new System.Drawing.Size(60, 60);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 500;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.SystemColors.ControlText;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(3, -14, 0, 0);
            this.circularProgressBar1.SubscriptText = "%";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 12;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.circularProgressBar1.Visible = false;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_passworld);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_login_invalido);
            this.Controls.Add(this.passworld_text);
            this.Controls.Add(this.User_text);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_login_invalido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exite;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label1;
    }
}

