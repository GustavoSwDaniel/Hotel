using sistemaHoteleiro.views.Listas;
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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        public void AbrirFormaInPainel(object Formi)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = Formi as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
        private void btn_ListaHospede_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new ListarHospedes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new ListarQuartos());
        }
    }
}
