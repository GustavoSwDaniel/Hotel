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

        
        string uName = "Gustavo";
        string uSenha = "1234";

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
            //Compara se o email e a senha correspondem ao valor salvo nas variáveis no início da classe.
            if (User_text.Text.Equals(uName) && passworld_text.Text.Equals(uSenha))
            {
                //Cria um objeto da classe que apresenta o form principal.
                Hotel formPrinc = new Hotel();
                //Esconde a tela atual, ou seja, ela continua ativa na pilha de execução.
                this.Hide();
                //Abre a janela principal.
                formPrinc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciais de acesso inválidas!!!");
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
