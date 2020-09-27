using sistemaHoteleiro.views.RecursosAdministrativos;
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
    public partial class Administrativo : Form
    {
        public Administrativo()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
        private void btn_CadastroF_Click_1(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new CadastroFuncionario());
        }

        private void btn_cadastrarQuarto_Click_1(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new CadastroDeQuartos());
        }

        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new AdministrasaoDeFuncionarios());
        }
    }
}
