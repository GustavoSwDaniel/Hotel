namespace sistemaHoteleiro.views
{
    partial class CadastroDeQuartos
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
            this.title_cadastro = new System.Windows.Forms.Label();
            this.lbl_TipoQ = new System.Windows.Forms.Label();
            this.lbl_numQ = new System.Windows.Forms.Label();
            this.cb_TipoQuarto = new System.Windows.Forms.ComboBox();
            this.btnCadastraQuarto = new System.Windows.Forms.Button();
            this.btn_limparQ = new System.Windows.Forms.Button();
            this.txt_Quarto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title_cadastro
            // 
            this.title_cadastro.AutoSize = true;
            this.title_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_cadastro.Location = new System.Drawing.Point(360, 21);
            this.title_cadastro.Name = "title_cadastro";
            this.title_cadastro.Size = new System.Drawing.Size(350, 39);
            this.title_cadastro.TabIndex = 1;
            this.title_cadastro.Text = "Cadastro de Quartos";
            // 
            // lbl_TipoQ
            // 
            this.lbl_TipoQ.AutoSize = true;
            this.lbl_TipoQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoQ.Location = new System.Drawing.Point(366, 178);
            this.lbl_TipoQ.Name = "lbl_TipoQ";
            this.lbl_TipoQ.Size = new System.Drawing.Size(128, 20);
            this.lbl_TipoQ.TabIndex = 24;
            this.lbl_TipoQ.Text = "Tipo do Quarto";
            // 
            // lbl_numQ
            // 
            this.lbl_numQ.AutoSize = true;
            this.lbl_numQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numQ.Location = new System.Drawing.Point(366, 143);
            this.lbl_numQ.Name = "lbl_numQ";
            this.lbl_numQ.Size = new System.Drawing.Size(156, 20);
            this.lbl_numQ.TabIndex = 22;
            this.lbl_numQ.Text = "Numero do Quarto";
            // 
            // cb_TipoQuarto
            // 
            this.cb_TipoQuarto.FormattingEnabled = true;
            this.cb_TipoQuarto.Items.AddRange(new object[] {
            "Quarto solteiro",
            "Quarto duplo solteiro",
            "Quarto casal"});
            this.cb_TipoQuarto.Location = new System.Drawing.Point(568, 177);
            this.cb_TipoQuarto.Name = "cb_TipoQuarto";
            this.cb_TipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoQuarto.TabIndex = 26;
            // 
            // btnCadastraQuarto
            // 
            this.btnCadastraQuarto.Location = new System.Drawing.Point(460, 310);
            this.btnCadastraQuarto.Name = "btnCadastraQuarto";
            this.btnCadastraQuarto.Size = new System.Drawing.Size(153, 52);
            this.btnCadastraQuarto.TabIndex = 27;
            this.btnCadastraQuarto.Text = "Cadastrar Quarto";
            this.btnCadastraQuarto.UseVisualStyleBackColor = true;
            this.btnCadastraQuarto.Click += new System.EventHandler(this.btnCadastraQuarto_Click);
            // 
            // btn_limparQ
            // 
            this.btn_limparQ.Location = new System.Drawing.Point(460, 380);
            this.btn_limparQ.Name = "btn_limparQ";
            this.btn_limparQ.Size = new System.Drawing.Size(153, 52);
            this.btn_limparQ.TabIndex = 28;
            this.btn_limparQ.Text = "Limpar";
            this.btn_limparQ.UseVisualStyleBackColor = true;
            // 
            // txt_Quarto
            // 
            this.txt_Quarto.Location = new System.Drawing.Point(568, 142);
            this.txt_Quarto.Name = "txt_Quarto";
            this.txt_Quarto.Size = new System.Drawing.Size(121, 20);
            this.txt_Quarto.TabIndex = 29;
            // 
            // CadastroDeQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 482);
            this.Controls.Add(this.txt_Quarto);
            this.Controls.Add(this.btn_limparQ);
            this.Controls.Add(this.btnCadastraQuarto);
            this.Controls.Add(this.cb_TipoQuarto);
            this.Controls.Add(this.lbl_TipoQ);
            this.Controls.Add(this.lbl_numQ);
            this.Controls.Add(this.title_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroDeQuartos";
            this.Text = "CadastroDeQuartos";
            this.Load += new System.EventHandler(this.CadastroDeQuartos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_cadastro;
        private System.Windows.Forms.Label lbl_TipoQ;
        private System.Windows.Forms.Label lbl_numQ;
        private System.Windows.Forms.ComboBox cb_TipoQuarto;
        private System.Windows.Forms.Button btnCadastraQuarto;
        private System.Windows.Forms.Button btn_limparQ;
        private System.Windows.Forms.TextBox txt_Quarto;
    }
}