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
            this.idQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomehospedeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdepagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teste2DataSet = new sistemaHoteleiro.teste2DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl_statusQ = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Pagar = new System.Windows.Forms.Button();
            this.mskCheckInOut = new System.Windows.Forms.MaskedTextBox();
            this.mskCheckIn = new System.Windows.Forms.MaskedTextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lblnumQ = new System.Windows.Forms.Label();
            this.lbl_desconto = new System.Windows.Forms.Label();
            this.lbl_CheckOu = new System.Windows.Forms.Label();
            this.lbl_CheckIn = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbl_val = new System.Windows.Forms.Label();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.pnl_CheckOut = new System.Windows.Forms.Panel();
            this.buscaTableAdapter = new sistemaHoteleiro.teste2DataSetTableAdapters.BuscaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_CheckOut.SuspendLayout();
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
            this.dataGridQuartos.AllowUserToDeleteRows = false;
            this.dataGridQuartos.AutoGenerateColumns = false;
            this.dataGridQuartos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idQuartoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.numeroquartoDataGridViewTextBoxColumn,
            this.nomehospedeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.statusdepagamentoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataentradaDataGridViewTextBoxColumn,
            this.datasaidaDataGridViewTextBoxColumn});
            this.dataGridQuartos.DataSource = this.buscaBindingSource1;
            this.dataGridQuartos.Location = new System.Drawing.Point(28, 77);
            this.dataGridQuartos.Name = "dataGridQuartos";
            this.dataGridQuartos.ReadOnly = true;
            this.dataGridQuartos.Size = new System.Drawing.Size(1044, 180);
            this.dataGridQuartos.TabIndex = 5;
            // 
            // idQuartoDataGridViewTextBoxColumn
            // 
            this.idQuartoDataGridViewTextBoxColumn.DataPropertyName = "idQuarto";
            this.idQuartoDataGridViewTextBoxColumn.HeaderText = "idQuarto";
            this.idQuartoDataGridViewTextBoxColumn.Name = "idQuartoDataGridViewTextBoxColumn";
            this.idQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idHospede";
            this.dataGridViewTextBoxColumn1.HeaderText = "idHospede";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numeroquartoDataGridViewTextBoxColumn
            // 
            this.numeroquartoDataGridViewTextBoxColumn.DataPropertyName = "numero_quarto";
            this.numeroquartoDataGridViewTextBoxColumn.HeaderText = "numero_quarto";
            this.numeroquartoDataGridViewTextBoxColumn.Name = "numeroquartoDataGridViewTextBoxColumn";
            this.numeroquartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomehospedeDataGridViewTextBoxColumn
            // 
            this.nomehospedeDataGridViewTextBoxColumn.DataPropertyName = "nome_hospede";
            this.nomehospedeDataGridViewTextBoxColumn.HeaderText = "nome_hospede";
            this.nomehospedeDataGridViewTextBoxColumn.Name = "nomehospedeDataGridViewTextBoxColumn";
            this.nomehospedeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cpf";
            this.dataGridViewTextBoxColumn8.HeaderText = "cpf";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // statusdepagamentoDataGridViewTextBoxColumn
            // 
            this.statusdepagamentoDataGridViewTextBoxColumn.DataPropertyName = "status_de_pagamento";
            this.statusdepagamentoDataGridViewTextBoxColumn.HeaderText = "status_de_pagamento";
            this.statusdepagamentoDataGridViewTextBoxColumn.Name = "statusdepagamentoDataGridViewTextBoxColumn";
            this.statusdepagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tipo_de_quarto";
            this.dataGridViewTextBoxColumn9.HeaderText = "tipo_de_quarto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "status_quarto";
            this.dataGridViewTextBoxColumn10.HeaderText = "status_quarto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            this.dataentradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            this.datasaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buscaBindingSource1
            // 
            this.buscaBindingSource1.DataMember = "Busca";
            this.buscaBindingSource1.DataSource = this.teste2DataSet;
            // 
            // teste2DataSet
            // 
            this.teste2DataSet.DataSetName = "teste2DataSet";
            this.teste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.lbl_statusQ);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_Pagar);
            this.panel1.Controls.Add(this.mskCheckInOut);
            this.panel1.Controls.Add(this.mskCheckIn);
            this.panel1.Controls.Add(this.txt_num);
            this.panel1.Controls.Add(this.lbl_valor);
            this.panel1.Controls.Add(this.txt_desconto);
            this.panel1.Controls.Add(this.txtCpf);
            this.panel1.Controls.Add(this.txt_nome);
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
            this.panel1.Size = new System.Drawing.Size(876, 264);
            this.panel1.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(318, 234);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl_statusQ
            // 
            this.lbl_statusQ.AutoSize = true;
            this.lbl_statusQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statusQ.Location = new System.Drawing.Point(371, 149);
            this.lbl_statusQ.Name = "lbl_statusQ";
            this.lbl_statusQ.Size = new System.Drawing.Size(0, 13);
            this.lbl_statusQ.TabIndex = 18;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(272, 149);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(84, 15);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Pagamento:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(480, 234);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Location = new System.Drawing.Point(399, 234);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pagar.TabIndex = 15;
            this.btn_Pagar.Text = "Pagar";
            this.btn_Pagar.UseVisualStyleBackColor = true;
            // 
            // mskCheckInOut
            // 
            this.mskCheckInOut.Location = new System.Drawing.Point(453, 79);
            this.mskCheckInOut.Mask = "00/00/0000 90:00";
            this.mskCheckInOut.Name = "mskCheckInOut";
            this.mskCheckInOut.Size = new System.Drawing.Size(100, 20);
            this.mskCheckInOut.TabIndex = 14;
            this.mskCheckInOut.ValidatingType = typeof(System.DateTime);
            // 
            // mskCheckIn
            // 
            this.mskCheckIn.Location = new System.Drawing.Point(88, 79);
            this.mskCheckIn.Mask = "00/00/0000";
            this.mskCheckIn.Name = "mskCheckIn";
            this.mskCheckIn.Size = new System.Drawing.Size(77, 20);
            this.mskCheckIn.TabIndex = 13;
            this.mskCheckIn.ValidatingType = typeof(System.DateTime);
            // 
            // txt_num
            // 
            this.txt_num.Enabled = false;
            this.txt_num.Location = new System.Drawing.Point(813, 43);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(31, 20);
            this.txt_num.TabIndex = 12;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(85, 190);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(0, 13);
            this.lbl_valor.TabIndex = 11;
            // 
            // txt_desconto
            // 
            this.txt_desconto.Location = new System.Drawing.Point(119, 148);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(35, 20);
            this.txt_desconto.TabIndex = 10;
            this.txt_desconto.Text = "0";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(408, 45);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(145, 20);
            this.txtCpf.TabIndex = 9;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(72, 45);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(284, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total:";
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
            // 
            // lblnumQ
            // 
            this.lblnumQ.AutoSize = true;
            this.lblnumQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumQ.Location = new System.Drawing.Point(689, 46);
            this.lblnumQ.Name = "lblnumQ";
            this.lblnumQ.Size = new System.Drawing.Size(107, 15);
            this.lblnumQ.TabIndex = 5;
            this.lblnumQ.Text = "Dias de estadia";
            // 
            // lbl_desconto
            // 
            this.lbl_desconto.AutoSize = true;
            this.lbl_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desconto.Location = new System.Drawing.Point(16, 151);
            this.lbl_desconto.Name = "lbl_desconto";
            this.lbl_desconto.Size = new System.Drawing.Size(97, 15);
            this.lbl_desconto.TabIndex = 4;
            this.lbl_desconto.Text = "Descondo(%):";
            // 
            // lbl_CheckOu
            // 
            this.lbl_CheckOu.AutoSize = true;
            this.lbl_CheckOu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckOu.Location = new System.Drawing.Point(371, 84);
            this.lbl_CheckOu.Name = "lbl_CheckOu";
            this.lbl_CheckOu.Size = new System.Drawing.Size(76, 15);
            this.lbl_CheckOu.TabIndex = 3;
            this.lbl_CheckOu.Text = "Check Out:";
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
            // lbl_aviso
            // 
            this.lbl_aviso.AutoSize = true;
            this.lbl_aviso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviso.ForeColor = System.Drawing.Color.Red;
            this.lbl_aviso.Location = new System.Drawing.Point(701, 54);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(168, 13);
            this.lbl_aviso.TabIndex = 8;
            this.lbl_aviso.Text = "O cpf pesquisado não existe";
            this.lbl_aviso.Visible = false;
            // 
            // pnl_CheckOut
            // 
            this.pnl_CheckOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_CheckOut.Controls.Add(this.lbl_aviso);
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
            // buscaTableAdapter
            // 
            this.buscaTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.buscaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_CheckOut.ResumeLayout(false);
            this.pnl_CheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title_cadastro;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label ck_lblCpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridQuartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodequartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl_statusQ;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.MaskedTextBox mskCheckInOut;
        private System.Windows.Forms.MaskedTextBox mskCheckIn;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lblnumQ;
        private System.Windows.Forms.Label lbl_desconto;
        private System.Windows.Forms.Label lbl_CheckOu;
        private System.Windows.Forms.Label lbl_CheckIn;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbl_val;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Panel pnl_CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomehospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdepagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buscaBindingSource1;
        private teste2DataSet teste2DataSet;
        private teste2DataSetTableAdapters.BuscaTableAdapter buscaTableAdapter;
    }
}