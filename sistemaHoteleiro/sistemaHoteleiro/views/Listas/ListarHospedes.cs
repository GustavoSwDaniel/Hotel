using sistemaHoteleiro.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.views.Listas
{
    public partial class ListarHospedes : Form
    {
        string nomeDaColuna;
        string antigo;
        string novo;
        HospedeDAO hd = new HospedeDAO();
        public ListarHospedes()
        {
            InitializeComponent();
        }

        private void ListarHospedes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hospedeList.hospedes'. Você pode movê-la ou removê-la conforme necessário.
            this.hospedesTableAdapter.Fill(this.hospedeList.hospedes);
            // TODO: esta linha de código carrega dados na tabela 'listHospedes.checkOutView'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void dataGridHospede_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                hospedesBindingSource.EndEdit();
                hospedesTableAdapter.Update(this.hospedeList.hospedes);
                MessageBox.Show("Gool", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            if (nomeDaColuna == "numerodoquartoDataGridViewTextBoxColumn")
            {
                novo = dataGridHospede.CurrentRow.Cells[3].Value.ToString();
                MessageBox.Show(novo);
                MessageBox.Show("Entrou");
                hd.updade(Convert.ToInt32(antigo), Convert.ToInt32(novo));
            }
            else
            {
                MessageBox.Show("Não entrou");
            }
            this.hospedesTableAdapter.Fill(this.hospedeList.hospedes);
            

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dataGridHospede.ReadOnly = false;
        }

        private void dataGridHospede_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            antigo = dataGridHospede.CurrentRow.Cells[3].Value.ToString();
            nomeDaColuna = dataGridHospede.Columns[e.ColumnIndex].Name;

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
