using sistemaHoteleiro.Controllers;
using sistemaHoteleiro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.views
{
    public partial class CadastroDeQuartos : Form
    {
        public CadastroDeQuartos()
        {
            InitializeComponent();
        }

        private void CadastroDeQuartos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'quartos.registrosQuartos'. Você pode movê-la ou removê-la conforme necessário.
            this.registrosQuartosTableAdapter.Fill(this.quartos.registrosQuartos);
            

        }

        private void btnCadastraQuarto_Click(object sender, EventArgs e)
        {
            bool resp = !string.IsNullOrWhiteSpace(txt_Quarto.Text) &&
                      !string.IsNullOrWhiteSpace(cb_TipoQuarto.Text);

            if (resp == true)
            {
                string nomeDoQuarto = txt_Quarto.Text;
                string tipoDeQuarto = cb_TipoQuarto.Text;
                float valorDaDiaria = float.Parse(txtValorDiaria.Text);


                Quarto qt = new Quarto(nomeDoQuarto, tipoDeQuarto, valorDaDiaria);
                QuartoController qh = new QuartoController();
                if (qh.CadastrarQuarto(qt))
                {
                    this.registrosQuartosTableAdapter.Fill(this.quartos.registrosQuartos);
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                registrosQuartosBindingSource.EndEdit();
                registrosQuartosTableAdapter.Update(this.quartos.registrosQuartos);
                MessageBox.Show("Gool", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dataGridQuartos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Você tem certeza que quer deletar esse quarto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    registrosQuartosBindingSource.RemoveCurrent();
            
            }
        }
    }
}
