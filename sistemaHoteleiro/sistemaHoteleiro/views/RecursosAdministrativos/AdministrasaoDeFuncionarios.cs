using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.views.RecursosAdministrativos
{
    public partial class AdministrasaoDeFuncionarios : Form
    {
        public AdministrasaoDeFuncionarios()
        {
            InitializeComponent();
        }

        private void AdministrasaoDeFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'funcio.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.funcio.funcionario);


        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                funcionarioBindingSource.EndEdit();
                funcionarioTableAdapter.Update(this.funcio.funcionario);
                MessageBox.Show("Gool", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            this.funcionarioTableAdapter.Fill(this.funcio.funcionario);
        }

        private void dataGridFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Você tem certeza que quer deletar esse quarto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    funcionarioBindingSource.RemoveCurrent();

            }
        }
    }
}
