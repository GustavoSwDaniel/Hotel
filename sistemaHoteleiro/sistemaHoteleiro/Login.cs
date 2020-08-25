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

namespace sistemaHoteleiro
{


    public partial class Login : MetroFramework.Forms.MetroForm
    {


        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(User_text.Text, passworld_text.Text);
            if(controle.tem)
            {
                Hotel formPrinc = new Hotel();
                this.Hide();
                formPrinc.ShowDialog();

            }
            else
            {
                lbl_login_invalido.Visible = true;
                User_text.Clear();
                passworld_text.Clear();
                User_text.Focus();
            }
        }

        

        private void lbl_esqueci_senha_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recurprar_senha Recurprar_senha = new Recurprar_senha();
            Recurprar_senha.Show();
            this.Hide();

        }
    }
}
