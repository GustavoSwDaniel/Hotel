namespace sistemaHoteleiro.views
{
    partial class Listar
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ListaHospede = new System.Windows.Forms.Button();
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
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(2, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 480);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_ListaHospede);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 82);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::sistemaHoteleiro.Properties.Resources.quarto;
            this.button2.Location = new System.Drawing.Point(139, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "Lista de Quartos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ListaHospede
            // 
            this.btn_ListaHospede.FlatAppearance.BorderSize = 0;
            this.btn_ListaHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListaHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListaHospede.Image = global::sistemaHoteleiro.Properties.Resources.guest;
            this.btn_ListaHospede.Location = new System.Drawing.Point(5, 8);
            this.btn_ListaHospede.Name = "btn_ListaHospede";
            this.btn_ListaHospede.Size = new System.Drawing.Size(128, 65);
            this.btn_ListaHospede.TabIndex = 0;
            this.btn_ListaHospede.Text = "Lista Hospede";
            this.btn_ListaHospede.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ListaHospede.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ListaHospede.UseVisualStyleBackColor = true;
            this.btn_ListaHospede.Click += new System.EventHandler(this.btn_ListaHospede_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 563);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listar";
            this.Text = "Listar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ListaHospede;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
    }
}