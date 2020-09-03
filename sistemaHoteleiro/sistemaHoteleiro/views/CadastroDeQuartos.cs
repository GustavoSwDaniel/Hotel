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

        }

        private void btnCadastraQuarto_Click(object sender, EventArgs e)
        {
            bool resp = !string.IsNullOrWhiteSpace(txt_Quarto.Text) &&
                      !string.IsNullOrWhiteSpace(cb_TipoQuarto.Text);

            if (resp == true)
            {
                string nomeDoQuarto = txt_Quarto.Text;
                string tipoDeQuarto = cb_TipoQuarto.Text;


                Quarto qt = new Quarto(nomeDoQuarto, tipoDeQuarto);
                QuartoController qh = new QuartoController();
                if (qh.CadastrarQuarto(qt))
                {

                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
