using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;
using sistemaHoteleiro.pages;
using Validacao;
using BCrypt.Net;
using sistemaHoteleiro.views;

namespace sistemaHoteleiro
{
    public partial class Hotel : MetroFramework.Forms.MetroForm
    {


        
        public Hotel()
        {
            InitializeComponent();
            AbrirFormaInPainel(new TelaInicial());
        }

        

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btn_exite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AbrirFormaInPainel(object Formi)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = Formi as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }




        private void btn_cadastroH_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new CadastrarHospedes());
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new TelaInicial());
        }

        private void btn_checkOu_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new CheckOutHospede());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {

            AbrirFormaInPainel(new Administrativo());
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ListarHospede_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new Listar());
        }
    }
}
