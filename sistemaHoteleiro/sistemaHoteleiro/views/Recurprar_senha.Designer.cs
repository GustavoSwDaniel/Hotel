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
            this.cpf_txt = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.btn_Enviar = new MetroFramework.Controls.MetroButton();
            this.panel_code = new System.Windows.Forms.Panel();
            this.btn_verificar_token = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.panel_recuperacao = new System.Windows.Forms.Panel();
            this.aviso = new System.Windows.Forms.Label();
            this.confirma_novaSenhaTxt = new System.Windows.Forms.TextBox();
            this.confirmado_nova = new System.Windows.Forms.Label();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.nova_senhaTxt = new System.Windows.Forms.TextBox();
            this.novaSenha = new System.Windows.Forms.Label();
            this.painel_recuperar_senha.SuspendLayout();
            this.panel_code.SuspendLayout();
            this.panel_recuperacao.SuspendLayout();
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
            this.painel_recuperar_senha.Controls.Add(this.cpf_txt);
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
            // cpf_txt
            // 
            this.cpf_txt.Location = new System.Drawing.Point(189, 48);
            this.cpf_txt.Mask = "000,000,000-00";
            this.cpf_txt.Name = "cpf_txt";
            this.cpf_txt.Size = new System.Drawing.Size(100, 20);
            this.cpf_txt.TabIndex = 7;
            this.cpf_txt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.panel_code.Location = new System.Drawing.Point(1, 61);
            this.panel_code.Name = "panel_code";
            this.panel_code.Size = new System.Drawing.Size(459, 103);
            this.panel_code.TabIndex = 7;
            this.panel_code.Visible = false;
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
            // panel_recuperacao
            // 
            this.panel_recuperacao.Controls.Add(this.aviso);
            this.panel_recuperacao.Controls.Add(this.confirma_novaSenhaTxt);
            this.panel_recuperacao.Controls.Add(this.confirmado_nova);
            this.panel_recuperacao.Controls.Add(this.btn_atualizar);
            this.panel_recuperacao.Controls.Add(this.nova_senhaTxt);
            this.panel_recuperacao.Controls.Add(this.novaSenha);
            this.panel_recuperacao.Location = new System.Drawing.Point(1, 64);
            this.panel_recuperacao.Name = "panel_recuperacao";
            this.panel_recuperacao.Size = new System.Drawing.Size(459, 103);
            this.panel_recuperacao.TabIndex = 8;
            this.panel_recuperacao.Visible = false;
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.ForeColor = System.Drawing.Color.Red;
            this.aviso.Location = new System.Drawing.Point(298, 47);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(119, 13);
            this.aviso.TabIndex = 5;
            this.aviso.Text = "As senha não conferem";
            this.aviso.Visible = false;
            // 
            // confirma_novaSenhaTxt
            // 
            this.confirma_novaSenhaTxt.Location = new System.Drawing.Point(192, 41);
            this.confirma_novaSenhaTxt.Name = "confirma_novaSenhaTxt";
            this.confirma_novaSenhaTxt.Size = new System.Drawing.Size(100, 20);
            this.confirma_novaSenhaTxt.TabIndex = 4;
            this.confirma_novaSenhaTxt.UseSystemPasswordChar = true;
            // 
            // confirmado_nova
            // 
            this.confirmado_nova.AutoSize = true;
            this.confirmado_nova.Location = new System.Drawing.Point(59, 47);
            this.confirmado_nova.Name = "confirmado_nova";
            this.confirmado_nova.Size = new System.Drawing.Size(112, 13);
            this.confirmado_nova.TabIndex = 3;
            this.confirmado_nova.Text = "Confirmar nova Senha";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(200, 72);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 2;
            this.btn_atualizar.Text = "Atualizar ";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // nova_senhaTxt
            // 
            this.nova_senhaTxt.Location = new System.Drawing.Point(192, 15);
            this.nova_senhaTxt.Name = "nova_senhaTxt";
            this.nova_senhaTxt.Size = new System.Drawing.Size(100, 20);
            this.nova_senhaTxt.TabIndex = 1;
            this.nova_senhaTxt.UseSystemPasswordChar = true;
            // 
            // novaSenha
            // 
            this.novaSenha.AutoSize = true;
            this.novaSenha.Location = new System.Drawing.Point(104, 18);
            this.novaSenha.Name = "novaSenha";
            this.novaSenha.Size = new System.Drawing.Size(67, 13);
            this.novaSenha.TabIndex = 0;
            this.novaSenha.Text = "Nova Senha";
            // 
            // Recurprar_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 167);
            this.Controls.Add(this.panel_recuperacao);
            this.Controls.Add(this.panel_code);
            this.Controls.Add(this.painel_recuperar_senha);
            this.Name = "Recurprar_senha";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Tag = "";
            this.Text = "Recuperar Senha";
            this.painel_recuperar_senha.ResumeLayout(false);
            this.painel_recuperar_senha.PerformLayout();
            this.panel_code.ResumeLayout(false);
            this.panel_code.PerformLayout();
            this.panel_recuperacao.ResumeLayout(false);
            this.panel_recuperacao.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox cpf_txt;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Panel panel_recuperacao;
        private System.Windows.Forms.TextBox confirma_novaSenhaTxt;
        private System.Windows.Forms.Label confirmado_nova;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.TextBox nova_senhaTxt;
        private System.Windows.Forms.Label novaSenha;
        private System.Windows.Forms.Label aviso;
    }
}