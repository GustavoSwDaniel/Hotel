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
            this.components = new System.ComponentModel.Container();
            this.title_cadastro = new System.Windows.Forms.Label();
            this.lbl_TipoQ = new System.Windows.Forms.Label();
            this.lbl_numQ = new System.Windows.Forms.Label();
            this.cb_TipoQuarto = new System.Windows.Forms.ComboBox();
            this.btnCadastraQuarto = new System.Windows.Forms.Button();
            this.btn_limparQ = new System.Windows.Forms.Button();
            this.txt_Quarto = new System.Windows.Forms.TextBox();
            this.lbl_valorDiaria = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.dataGridQuartos = new System.Windows.Forms.DataGridView();
            this.numerodoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodequartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrosQuartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartos = new sistemaHoteleiro.Quartos();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.registrosQuartosTableAdapter = new sistemaHoteleiro.QuartosTableAdapters.registrosQuartosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosQuartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartos)).BeginInit();
            this.SuspendLayout();
            // 
            // title_cadastro
            // 
            this.title_cadastro.AutoSize = true;
            this.title_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_cadastro.Location = new System.Drawing.Point(360, 21);
            this.title_cadastro.Name = "title_cadastro";
            this.title_cadastro.Size = new System.Drawing.Size(262, 30);
            this.title_cadastro.TabIndex = 1;
            this.title_cadastro.Text = "Controle de Quartos";
            // 
            // lbl_TipoQ
            // 
            this.lbl_TipoQ.AutoSize = true;
            this.lbl_TipoQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoQ.Location = new System.Drawing.Point(52, 107);
            this.lbl_TipoQ.Name = "lbl_TipoQ";
            this.lbl_TipoQ.Size = new System.Drawing.Size(118, 17);
            this.lbl_TipoQ.TabIndex = 24;
            this.lbl_TipoQ.Text = "Tipo do Quarto";
            // 
            // lbl_numQ
            // 
            this.lbl_numQ.AutoSize = true;
            this.lbl_numQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numQ.Location = new System.Drawing.Point(52, 72);
            this.lbl_numQ.Name = "lbl_numQ";
            this.lbl_numQ.Size = new System.Drawing.Size(142, 17);
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
            this.cb_TipoQuarto.Location = new System.Drawing.Point(200, 106);
            this.cb_TipoQuarto.Name = "cb_TipoQuarto";
            this.cb_TipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoQuarto.TabIndex = 26;
            // 
            // btnCadastraQuarto
            // 
            this.btnCadastraQuarto.Location = new System.Drawing.Point(84, 169);
            this.btnCadastraQuarto.Name = "btnCadastraQuarto";
            this.btnCadastraQuarto.Size = new System.Drawing.Size(110, 23);
            this.btnCadastraQuarto.TabIndex = 27;
            this.btnCadastraQuarto.Text = "Cadastrar Quarto";
            this.btnCadastraQuarto.UseVisualStyleBackColor = true;
            this.btnCadastraQuarto.Click += new System.EventHandler(this.btnCadastraQuarto_Click);
            // 
            // btn_limparQ
            // 
            this.btn_limparQ.Location = new System.Drawing.Point(200, 169);
            this.btn_limparQ.Name = "btn_limparQ";
            this.btn_limparQ.Size = new System.Drawing.Size(110, 23);
            this.btn_limparQ.TabIndex = 28;
            this.btn_limparQ.Text = "Limpar";
            this.btn_limparQ.UseVisualStyleBackColor = true;
            // 
            // txt_Quarto
            // 
            this.txt_Quarto.Location = new System.Drawing.Point(200, 71);
            this.txt_Quarto.Name = "txt_Quarto";
            this.txt_Quarto.Size = new System.Drawing.Size(121, 20);
            this.txt_Quarto.TabIndex = 29;
            // 
            // lbl_valorDiaria
            // 
            this.lbl_valorDiaria.AutoSize = true;
            this.lbl_valorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorDiaria.Location = new System.Drawing.Point(52, 143);
            this.lbl_valorDiaria.Name = "lbl_valorDiaria";
            this.lbl_valorDiaria.Size = new System.Drawing.Size(117, 17);
            this.lbl_valorDiaria.TabIndex = 30;
            this.lbl_valorDiaria.Text = "Valor da Diaria";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(200, 143);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(121, 20);
            this.txtValorDiaria.TabIndex = 31;
            // 
            // dataGridQuartos
            // 
            this.dataGridQuartos.AllowUserToAddRows = false;
            this.dataGridQuartos.AllowUserToOrderColumns = true;
            this.dataGridQuartos.AutoGenerateColumns = false;
            this.dataGridQuartos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerodoquartoDataGridViewTextBoxColumn,
            this.tipodequartoDataGridViewTextBoxColumn,
            this.valordoquartoDataGridViewTextBoxColumn,
            this.statusquartoDataGridViewTextBoxColumn});
            this.dataGridQuartos.DataSource = this.registrosQuartosBindingSource;
            this.dataGridQuartos.Location = new System.Drawing.Point(378, 68);
            this.dataGridQuartos.Name = "dataGridQuartos";
            this.dataGridQuartos.Size = new System.Drawing.Size(525, 232);
            this.dataGridQuartos.TabIndex = 32;
            this.dataGridQuartos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridQuartos_KeyDown);
            // 
            // numerodoquartoDataGridViewTextBoxColumn
            // 
            this.numerodoquartoDataGridViewTextBoxColumn.DataPropertyName = "numero_do_quarto";
            this.numerodoquartoDataGridViewTextBoxColumn.HeaderText = "numero_do_quarto";
            this.numerodoquartoDataGridViewTextBoxColumn.Name = "numerodoquartoDataGridViewTextBoxColumn";
            // 
            // tipodequartoDataGridViewTextBoxColumn
            // 
            this.tipodequartoDataGridViewTextBoxColumn.DataPropertyName = "tipo_de_quarto";
            this.tipodequartoDataGridViewTextBoxColumn.HeaderText = "tipo_de_quarto";
            this.tipodequartoDataGridViewTextBoxColumn.Name = "tipodequartoDataGridViewTextBoxColumn";
            // 
            // valordoquartoDataGridViewTextBoxColumn
            // 
            this.valordoquartoDataGridViewTextBoxColumn.DataPropertyName = "valor_do_quarto";
            this.valordoquartoDataGridViewTextBoxColumn.HeaderText = "valor_do_quarto";
            this.valordoquartoDataGridViewTextBoxColumn.Name = "valordoquartoDataGridViewTextBoxColumn";
            // 
            // statusquartoDataGridViewTextBoxColumn
            // 
            this.statusquartoDataGridViewTextBoxColumn.DataPropertyName = "status_quarto";
            this.statusquartoDataGridViewTextBoxColumn.HeaderText = "status_quarto";
            this.statusquartoDataGridViewTextBoxColumn.Name = "statusquartoDataGridViewTextBoxColumn";
            // 
            // registrosQuartosBindingSource
            // 
            this.registrosQuartosBindingSource.DataMember = "registrosQuartos";
            this.registrosQuartosBindingSource.DataSource = this.quartos;
            // 
            // quartos
            // 
            this.quartos.DataSetName = "Quartos";
            this.quartos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(819, 306);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 33;
            this.btn_Salvar.Text = "Salva";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // registrosQuartosTableAdapter
            // 
            this.registrosQuartosTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroDeQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 482);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.dataGridQuartos);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.lbl_valorDiaria);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosQuartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartos)).EndInit();
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
        private System.Windows.Forms.Label lbl_valorDiaria;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.DataGridView dataGridQuartos;
        private System.Windows.Forms.Button btn_Salvar;
        private Quartos quartos;
        private System.Windows.Forms.BindingSource registrosQuartosBindingSource;
        private QuartosTableAdapters.registrosQuartosTableAdapter registrosQuartosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodequartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusquartoDataGridViewTextBoxColumn;
    }
}