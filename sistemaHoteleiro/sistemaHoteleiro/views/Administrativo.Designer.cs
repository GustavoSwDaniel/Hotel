namespace sistemaHoteleiro.views
{
    partial class Administrativo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_CadastroF = new System.Windows.Forms.Button();
            this.btn_cadastrarQuarto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 563);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btn_CadastroF);
            this.panel2.Controls.Add(this.btn_cadastrarQuarto);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 82);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 482);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_CadastroF
            // 
            this.btn_CadastroF.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadastroF.FlatAppearance.BorderSize = 0;
            this.btn_CadastroF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroF.ForeColor = System.Drawing.Color.Black;
            this.btn_CadastroF.Image = global::sistemaHoteleiro.Properties.Resources.user1;
            this.btn_CadastroF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadastroF.Location = new System.Drawing.Point(1, 8);
            this.btn_CadastroF.Name = "btn_CadastroF";
            this.btn_CadastroF.Size = new System.Drawing.Size(128, 65);
            this.btn_CadastroF.TabIndex = 10;
            this.btn_CadastroF.Text = "   Cadastrar Funcionario";
            this.btn_CadastroF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CadastroF.UseVisualStyleBackColor = true;
            this.btn_CadastroF.Click += new System.EventHandler(this.btn_CadastroF_Click_1);
            // 
            // btn_cadastrarQuarto
            // 
            this.btn_cadastrarQuarto.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrarQuarto.FlatAppearance.BorderSize = 0;
            this.btn_cadastrarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrarQuarto.ForeColor = System.Drawing.Color.Black;
            this.btn_cadastrarQuarto.Image = global::sistemaHoteleiro.Properties.Resources.bed_bed_room_sleep_furniture_icon_124423_2_;
            this.btn_cadastrarQuarto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrarQuarto.Location = new System.Drawing.Point(135, 8);
            this.btn_cadastrarQuarto.Name = "btn_cadastrarQuarto";
            this.btn_cadastrarQuarto.Size = new System.Drawing.Size(108, 65);
            this.btn_cadastrarQuarto.TabIndex = 9;
            this.btn_cadastrarQuarto.Text = "Cadastrar Quarto";
            this.btn_cadastrarQuarto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrarQuarto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cadastrarQuarto.UseCompatibleTextRendering = true;
            this.btn_cadastrarQuarto.UseVisualStyleBackColor = false;
            this.btn_cadastrarQuarto.Click += new System.EventHandler(this.btn_cadastrarQuarto_Click_1);
            // 
            // Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 563);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrativo";
            this.Text = "Administrativo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastrarQuarto;
        private System.Windows.Forms.Button btn_CadastroF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}