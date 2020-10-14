namespace sistemaHoteleiro.views.Listas
{
    partial class ListarQuartos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listQuartos = new sistemaHoteleiro.ListQuartos();
            this.registrosQuartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrosQuartosTableAdapter = new sistemaHoteleiro.ListQuartosTableAdapters.registrosQuartosTableAdapter();
            this.numerodoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodequartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosQuartosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // title_cadastro
            // 
            this.title_cadastro.AutoSize = true;
            this.title_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_cadastro.Location = new System.Drawing.Point(355, 9);
            this.title_cadastro.Name = "title_cadastro";
            this.title_cadastro.Size = new System.Drawing.Size(216, 30);
            this.title_cadastro.TabIndex = 7;
            this.title_cadastro.Text = "Lista de Quartos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerodoquartoDataGridViewTextBoxColumn,
            this.tipodequartoDataGridViewTextBoxColumn,
            this.valordoquartoDataGridViewTextBoxColumn,
            this.statusquartoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrosQuartosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(186, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 304);
            this.dataGridView1.TabIndex = 8;
            // 
            // listQuartos
            // 
            this.listQuartos.DataSetName = "ListQuartos";
            this.listQuartos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrosQuartosBindingSource
            // 
            this.registrosQuartosBindingSource.DataMember = "registrosQuartos";
            this.registrosQuartosBindingSource.DataSource = this.listQuartos;
            // 
            // registrosQuartosTableAdapter
            // 
            this.registrosQuartosTableAdapter.ClearBeforeFill = true;
            // 
            // numerodoquartoDataGridViewTextBoxColumn
            // 
            this.numerodoquartoDataGridViewTextBoxColumn.DataPropertyName = "numero_do_quarto";
            this.numerodoquartoDataGridViewTextBoxColumn.HeaderText = "numero_do_quarto";
            this.numerodoquartoDataGridViewTextBoxColumn.Name = "numerodoquartoDataGridViewTextBoxColumn";
            this.numerodoquartoDataGridViewTextBoxColumn.Width = 140;
            // 
            // tipodequartoDataGridViewTextBoxColumn
            // 
            this.tipodequartoDataGridViewTextBoxColumn.DataPropertyName = "tipo_de_quarto";
            this.tipodequartoDataGridViewTextBoxColumn.HeaderText = "tipo_de_quarto";
            this.tipodequartoDataGridViewTextBoxColumn.Name = "tipodequartoDataGridViewTextBoxColumn";
            this.tipodequartoDataGridViewTextBoxColumn.Width = 140;
            // 
            // valordoquartoDataGridViewTextBoxColumn
            // 
            this.valordoquartoDataGridViewTextBoxColumn.DataPropertyName = "valor_do_quarto";
            this.valordoquartoDataGridViewTextBoxColumn.HeaderText = "valor_do_quarto";
            this.valordoquartoDataGridViewTextBoxColumn.Name = "valordoquartoDataGridViewTextBoxColumn";
            this.valordoquartoDataGridViewTextBoxColumn.Width = 140;
            // 
            // statusquartoDataGridViewTextBoxColumn
            // 
            this.statusquartoDataGridViewTextBoxColumn.DataPropertyName = "status_quarto";
            this.statusquartoDataGridViewTextBoxColumn.HeaderText = "status_quarto";
            this.statusquartoDataGridViewTextBoxColumn.Name = "statusquartoDataGridViewTextBoxColumn";
            this.statusquartoDataGridViewTextBoxColumn.Width = 140;
            // 
            // ListarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarQuartos";
            this.Text = "ListarQuartos";
            this.Load += new System.EventHandler(this.ListarQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosQuartosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_cadastro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ListQuartos listQuartos;
        private System.Windows.Forms.BindingSource registrosQuartosBindingSource;
        private ListQuartosTableAdapters.registrosQuartosTableAdapter registrosQuartosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodequartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusquartoDataGridViewTextBoxColumn;
    }
}