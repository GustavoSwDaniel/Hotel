namespace sistemaHoteleiro
{
    partial class Hotel
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_checkOu = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_cadastroH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(170, 84);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1110, 636);
            this.panelPrincipal.TabIndex = 5;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.BackgroundImage = global::sistemaHoteleiro.Properties.Resources.Header;
            this.Header.Controls.Add(this.btn_voltar);
            this.Header.Controls.Add(this.btn_min);
            this.Header.Controls.Add(this.btn_exite);
            this.Header.Location = new System.Drawing.Point(170, 3);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1110, 80);
            this.Header.TabIndex = 4;
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Image = global::sistemaHoteleiro.Properties.Resources.icons8_back_25;
            this.btn_voltar.Location = new System.Drawing.Point(3, 39);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(32, 41);
            this.btn_voltar.TabIndex = 36;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(1053, 3);
            this.btn_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(28, 27);
            this.btn_min.TabIndex = 2;
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
            this.btn_exite.Location = new System.Drawing.Point(1081, 3);
            this.btn_exite.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exite.Name = "btn_exite";
            this.btn_exite.Size = new System.Drawing.Size(20, 27);
            this.btn_exite.TabIndex = 0;
            this.btn_exite.Text = "X";
            this.btn_exite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exite.UseVisualStyleBackColor = true;
            this.btn_exite.Click += new System.EventHandler(this.btn_exite_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::sistemaHoteleiro.Properties.Resources.menu;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel_buttons);
            this.panel1.Controls.Add(this.lbl_cargo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 747);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::sistemaHoteleiro.Properties.Resources.logo1;
            this.panel3.Location = new System.Drawing.Point(20, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_Admin);
            this.panel_buttons.Controls.Add(this.btn_checkOu);
            this.panel_buttons.Controls.Add(this.btn_logout);
            this.panel_buttons.Controls.Add(this.btn_cadastroH);
            this.panel_buttons.Controls.Add(this.button1);
            this.panel_buttons.Location = new System.Drawing.Point(11, 238);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(148, 463);
            this.panel_buttons.TabIndex = 5;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Image = global::sistemaHoteleiro.Properties.Resources.administracao_2;
            this.btn_Admin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Admin.Location = new System.Drawing.Point(3, 199);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(143, 65);
            this.btn_Admin.TabIndex = 7;
            this.btn_Admin.Text = "Administrativo";
            this.btn_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_checkOu
            // 
            this.btn_checkOu.BackColor = System.Drawing.Color.Transparent;
            this.btn_checkOu.FlatAppearance.BorderSize = 0;
            this.btn_checkOu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkOu.ForeColor = System.Drawing.Color.White;
            this.btn_checkOu.Image = global::sistemaHoteleiro.Properties.Resources.check_out;
            this.btn_checkOu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_checkOu.Location = new System.Drawing.Point(3, 66);
            this.btn_checkOu.Name = "btn_checkOu";
            this.btn_checkOu.Size = new System.Drawing.Size(143, 65);
            this.btn_checkOu.TabIndex = 6;
            this.btn_checkOu.Text = "Check Out";
            this.btn_checkOu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_checkOu.UseVisualStyleBackColor = false;
            this.btn_checkOu.Click += new System.EventHandler(this.btn_checkOu_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::sistemaHoteleiro.Properties.Resources.sair__3_1;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(7, 421);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(133, 37);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_cadastroH
            // 
            this.btn_cadastroH.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastroH.FlatAppearance.BorderSize = 0;
            this.btn_cadastroH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastroH.ForeColor = System.Drawing.Color.White;
            this.btn_cadastroH.Image = global::sistemaHoteleiro.Properties.Resources.cadastro_hospedes1;
            this.btn_cadastroH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastroH.Location = new System.Drawing.Point(3, 4);
            this.btn_cadastroH.Name = "btn_cadastroH";
            this.btn_cadastroH.Size = new System.Drawing.Size(143, 65);
            this.btn_cadastroH.TabIndex = 3;
            this.btn_cadastroH.Text = "Check In";
            this.btn_cadastroH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cadastroH.UseVisualStyleBackColor = false;
            this.btn_cadastroH.Click += new System.EventHandler(this.btn_cadastroH_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::sistemaHoteleiro.Properties.Resources.Cadastro_empresa;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(2, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "   Cadastrar Empresa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.Color.White;
            this.lbl_cargo.Location = new System.Drawing.Point(17, 178);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(43, 15);
            this.lbl_cargo.TabIndex = 1;
            this.lbl_cargo.Text = "Cargo:";
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.Name = "Hotel";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Button btn_cadastroH;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_checkOu;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exite;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_Admin;
    }
}