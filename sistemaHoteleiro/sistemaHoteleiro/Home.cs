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

      

        private void panel_cadastroH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {
            
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

        private void btn_CadastroF_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new CadastroFuncionario());
        }

        private void btn_cadastroH_Click(object sender, EventArgs e)
        {
            AbrirFormaInPainel(new CadastrarHospedes());
        }

       

      
    }
}
