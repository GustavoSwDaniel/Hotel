namespace sistemaHoteleiro
{
    partial class Recurprar_senha
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_invalido = new System.Windows.Forms.Label();
            this.painel_recuperar_senha = new System.Windows.Forms.Panel();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.btn_Enviar = new MetroFramework.Controls.MetroButton();
            this.panel_code = new System.Windows.Forms.Panel();
            this.lbl_code = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.painel_recuperar_senha.SuspendLayout();
            this.panel_code.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(76, 8);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(242, 20);
            this.txt_email.TabIndex = 0;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // lbl_invalido
            // 
            this.lbl_invalido.AutoSize = true;
            this.lbl_invalido.Location = new System.Drawing.Point(248, 31);
            this.lbl_invalido.Name = "lbl_invalido";
            this.lbl_invalido.Size = new System.Drawing.Size(0, 13);
            this.lbl_invalido.TabIndex = 3;
            // 
            // painel_recuperar_senha
            // 
            this.painel_recuperar_senha.Controls.Add(this.lbl_Email);
            this.painel_recuperar_senha.Controls.Add(this.lbl_invalido);
            this.painel_recuperar_senha.Controls.Add(this.btn_Enviar);
            this.painel_recuperar_senha.Controls.Add(this.txt_email);
            this.painel_recuperar_senha.Location = new System.Drawing.Point(3, 63);
            this.painel_recuperar_senha.Name = "painel_recuperar_senha";
            this.painel_recuperar_senha.Size = new System.Drawing.Size(404, 76);
            this.painel_recuperar_senha.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(25, 9);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 16);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email ";
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(155, 34);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 6;
            this.btn_Enviar.Text = "Enviar";
            // 
            // panel_code
            // 
            this.panel_code.Controls.Add(this.txt_code);
            this.panel_code.Controls.Add(this.lbl_code);
            this.panel_code.Enabled = false;
            this.panel_code.Location = new System.Drawing.Point(3, 63);
            this.panel_code.Name = "panel_code";
            this.panel_code.Size = new System.Drawing.Size(404, 76);
            this.panel_code.TabIndex = 7;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(69, 25);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(102, 13);
            this.lbl_code.TabIndex = 0;
            this.lbl_code.Text = "Code de verificação";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(177, 22);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 1;
            // 
            // Recurprar_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 137);
            this.Controls.Add(this.panel_code);
            this.Controls.Add(this.painel_recuperar_senha);
            this.Name = "Recurprar_senha";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Tag = "";
            this.Text = "Recuperar Senha";
            this.Load += new System.EventHandler(this.Recurprar_senha_Load);
            this.painel_recuperar_senha.ResumeLayout(false);
            this.painel_recuperar_senha.PerformLayout();
            this.panel_code.ResumeLayout(false);
            this.panel_code.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_invalido;
        private System.Windows.Forms.Panel painel_recuperar_senha;
        private System.Windows.Forms.Label lbl_Email;
        private MetroFramework.Controls.MetroButton btn_Enviar;
        private System.Windows.Forms.Panel panel_code;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label lbl_code;
    }
}