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
    public partial class ListarQuartos : Form
    {
        public ListarQuartos()
        {
            InitializeComponent();
        }

        private void ListarQuartos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'listQuartos.registrosQuartos'. Você pode movê-la ou removê-la conforme necessário.
            this.registrosQuartosTableAdapter.Fill(this.listQuartos.registrosQuartos);

        }
    }
}
