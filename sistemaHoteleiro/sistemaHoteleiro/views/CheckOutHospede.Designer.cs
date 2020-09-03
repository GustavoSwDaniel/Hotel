namespace sistemaHoteleiro.views
{
    partial class CheckOutHospede
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
            this.components = new System.ComponentModel.Container();
            this.title_cadastro = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.ck_lblCpf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridQuartos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfhospedeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new sistemaHoteleiro.hotelDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_CheckOut = new System.Windows.Forms.Panel();
            this.quartosTableAdapter = new sistemaHoteleiro.hotelDataSetTableAdapters.quartosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_val = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbl_CheckIn = new System.Windows.Forms.Label();
            this.lbl_CheckOu = new System.Windows.Forms.Label();
            this.lbl_desconto = new System.Windows.Forms.Label();
            this.lblnumQ = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btn_Pagar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.pnl_CheckOut.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_cadastro
            // 
            this.title_cadastro.AutoSize = true;
            this.title_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_cadastro.Location = new System.Drawing.Point(431, 18);
            this.title_cadastro.Name = "title_cadastro";
            this.title_cadastro.Size = new System.Drawing.Size(134, 29);
            this.title_cadastro.TabIndex = 1;
            this.title_cadastro.Text = "Check Out";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(376, 51);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(285, 20);
            this.txt_cpf.TabIndex = 2;
            // 
            // ck_lblCpf
            // 
            this.ck_lblCpf.AutoSize = true;
            this.ck_lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_lblCpf.Location = new System.Drawing.Point(280, 52);
            this.ck_lblCpf.Name = "ck_lblCpf";
            this.ck_lblCpf.Size = new System.Drawing.Size(90, 17);
            this.ck_lblCpf.TabIndex = 3;
            this.ck_lblCpf.Text = "Infomer o cpf";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::sistemaHoteleiro.Properties.Resources.pngwing_com;
            this.button1.Location = new System.Drawing.Point(662, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 18);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridQuartos
            // 
            this.dataGridQuartos.AllowUserToAddRows = false;
            this.dataGridQuartos.AutoGenerateColumns = false;
            this.dataGridQuartos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cpfhospedeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridQuartos.DataSource = this.quartosBindingSource;
            this.dataGridQuartos.Location = new System.Drawing.Point(186, 77);
            this.dataGridQuartos.Name = "dataGridQuartos";
            this.dataGridQuartos.ReadOnly = true;
            this.dataGridQuartos.Size = new System.Drawing.Size(644, 180);
            this.dataGridQuartos.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_quarto";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_quarto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cpfhospedeDataGridViewTextBoxColumn
            // 
            this.cpfhospedeDataGridViewTextBoxColumn.DataPropertyName = "cpf_hospede";
            this.cpfhospedeDataGridViewTextBoxColumn.HeaderText = "cpf_hospede";
            this.cpfhospedeDataGridViewTextBoxColumn.Name = "cpfhospedeDataGridViewTextBoxColumn";
            this.cpfhospedeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_do_hospede";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_do_hospede";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo_do_quarto";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo_do_quarto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataEntrada";
            this.dataGridViewTextBoxColumn4.HeaderText = "dataEntrada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataSaida";
            this.dataGridViewTextBoxColumn5.HeaderText = "dataSaida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "quartos";
            this.quartosBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Check Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_CheckOut
            // 
            this.pnl_CheckOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_CheckOut.Controls.Add(this.panel1);
            this.pnl_CheckOut.Controls.Add(this.button2);
            this.pnl_CheckOut.Controls.Add(this.dataGridQuartos);
            this.pnl_CheckOut.Controls.Add(this.button1);
            this.pnl_CheckOut.Controls.Add(this.ck_lblCpf);
            this.pnl_CheckOut.Controls.Add(this.txt_cpf);
            this.pnl_CheckOut.Controls.Add(this.title_cadastro);
            this.pnl_CheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CheckOut.Location = new System.Drawing.Point(0, 0);
            this.pnl_CheckOut.Name = "pnl_CheckOut";
            this.pnl_CheckOut.Size = new System.Drawing.Size(1110, 602);
            this.pnl_CheckOut.TabIndex = 0;
            // 
            // quartosTableAdapter
            // 
            this.quartosTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_Pagar);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lbl_valor);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_cpf);
            this.panel1.Controls.Add(this.lblnumQ);
            this.panel1.Controls.Add(this.lbl_desconto);
            this.panel1.Controls.Add(this.lbl_CheckOu);
            this.panel1.Controls.Add(this.lbl_CheckIn);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lbl_val);
            this.panel1.Location = new System.Drawing.Point(69, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 178);
            this.panel1.TabIndex = 7;
            // 
            // lbl_val
            // 
            this.lbl_val.AutoSize = true;
            this.lbl_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_val.Location = new System.Drawing.Point(334, 1);
            this.lbl_val.Name = "lbl_val";
            this.lbl_val.Size = new System.Drawing.Size(219, 31);
            this.lbl_val.TabIndex = 0;
            this.lbl_val.Text = "Valores a pagar";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lbl_CheckIn
            // 
            this.lbl_CheckIn.AutoSize = true;
            this.lbl_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckIn.Location = new System.Drawing.Point(16, 84);
            this.lbl_CheckIn.Name = "lbl_CheckIn";
            this.lbl_CheckIn.Size = new System.Drawing.Size(66, 15);
            this.lbl_CheckIn.TabIndex = 2;
            this.lbl_CheckIn.Text = "Check In:";
            // 
            // lbl_CheckOu
            // 
            this.lbl_CheckOu.AutoSize = true;
            this.lbl_CheckOu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckOu.Location = new System.Drawing.Point(183, 84);
            this.lbl_CheckOu.Name = "lbl_CheckOu";
            this.lbl_CheckOu.Size = new System.Drawing.Size(76, 15);
            this.lbl_CheckOu.TabIndex = 3;
            this.lbl_CheckOu.Text = "Check Out:";
            // 
            // lbl_desconto
            // 
            this.lbl_desconto.AutoSize = true;
            this.lbl_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desconto.Location = new System.Drawing.Point(16, 114);
            this.lbl_desconto.Name = "lbl_desconto";
            this.lbl_desconto.Size = new System.Drawing.Size(97, 15);
            this.lbl_desconto.TabIndex = 4;
            this.lbl_desconto.Text = "Descondo(%):";
            // 
            // lblnumQ
            // 
            this.lblnumQ.AutoSize = true;
            this.lblnumQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumQ.Location = new System.Drawing.Point(640, 47);
            this.lblnumQ.Name = "lblnumQ";
            this.lblnumQ.Size = new System.Drawing.Size(136, 15);
            this.lblnumQ.TabIndex = 5;
            this.lblnumQ.Text = "Numero de Quartos:";
            this.lblnumQ.Click += new System.EventHandler(this.lblnumQ_Click);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(371, 47);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 15);
            this.lbl_cpf.TabIndex = 6;
            this.lbl_cpf.Text = "cpf:";
            this.lbl_cpf.Click += new System.EventHandler(this.lbl_cpf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(72, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(408, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "0";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(690, 115);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(92, 13);
            this.lbl_valor.TabIndex = 11;
            this.lbl_valor.Text = "VALOR TOTAL";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(782, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(31, 20);
            this.textBox4.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(88, 79);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(265, 80);
            this.maskedTextBox2.Mask = "00/00/0000 90:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 14;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Location = new System.Drawing.Point(365, 143);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pagar.TabIndex = 15;
            this.btn_Pagar.Text = "Pagar";
            this.btn_Pagar.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(447, 143);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // CheckOutHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 602);
            this.Controls.Add(this.pnl_CheckOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOutHospede";
            this.Text = "CheckOutHospede";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.pnl_CheckOut.ResumeLayout(false);
            this.pnl_CheckOut.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedohospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label title_cadastro;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label ck_lblCpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridQuartos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnl_CheckOut;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private hotelDataSetTableAdapters.quartosTableAdapter quartosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfhospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_desconto;
        private System.Windows.Forms.Label lbl_CheckOu;
        private System.Windows.Forms.Label lbl_CheckIn;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbl_val;
        private System.Windows.Forms.Label lblnumQ;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Pagar;
    }
}