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
            this.lbl_invalido = new System.Windows.Forms.Label();
            this.painel_recuperar_senha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.btn_Enviar = new MetroFramework.Controls.MetroButton();
            this.panel_code = new System.Windows.Forms.Panel();
            this.btn_verificar_token = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.painel_recuperar_senha.SuspendLayout();
            this.panel_code.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_invalido
            // 
            this.lbl_invalido.AutoSize = true;
            this.lbl_invalido.Location = new System.Drawing.Point(292, 55);
            this.lbl_invalido.Name = "lbl_invalido";
            this.lbl_invalido.Size = new System.Drawing.Size(0, 13);
            this.lbl_invalido.TabIndex = 3;
            // 
            // painel_recuperar_senha
            // 
            this.painel_recuperar_senha.Controls.Add(this.label1);
            this.painel_recuperar_senha.Controls.Add(this.maskedTextBox1);
            this.painel_recuperar_senha.Controls.Add(this.lbl_Email);
            this.painel_recuperar_senha.Controls.Add(this.lbl_invalido);
            this.painel_recuperar_senha.Controls.Add(this.btn_Enviar);
            this.painel_recuperar_senha.Location = new System.Drawing.Point(0, 63);
            this.painel_recuperar_senha.Name = "painel_recuperar_senha";
            this.painel_recuperar_senha.Size = new System.Drawing.Size(459, 103);
            this.painel_recuperar_senha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sera enviado um codigo para o seu email";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(189, 48);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(140, 50);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(34, 16);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "CPF";
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(200, 73);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 6;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // panel_code
            // 
            this.panel_code.Controls.Add(this.btn_verificar_token);
            this.panel_code.Controls.Add(this.txt_code);
            this.panel_code.Controls.Add(this.lbl_code);
            this.panel_code.Location = new System.Drawing.Point(0, 64);
            this.panel_code.Name = "panel_code";
            this.panel_code.Size = new System.Drawing.Size(459, 103);
            this.panel_code.TabIndex = 7;
            this.panel_code.Visible = false;
            this.panel_code.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_code_Paint);
            // 
            // btn_verificar_token
            // 
            this.btn_verificar_token.Location = new System.Drawing.Point(187, 48);
            this.btn_verificar_token.Name = "btn_verificar_token";
            this.btn_verificar_token.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar_token.TabIndex = 2;
            this.btn_verificar_token.Text = "Verificar";
            this.btn_verificar_token.UseVisualStyleBackColor = true;
            this.btn_verificar_token.Click += new System.EventHandler(this.btn_verificar_token_Click);
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(177, 22);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 1;
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
            // Recurprar_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 167);
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
        private System.Windows.Forms.Label lbl_invalido;
        private System.Windows.Forms.Panel painel_recuperar_senha;
        private System.Windows.Forms.Label lbl_Email;
        private MetroFramework.Controls.MetroButton btn_Enviar;
        private System.Windows.Forms.Panel panel_code;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Button btn_verificar_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txt_code;
    }
}