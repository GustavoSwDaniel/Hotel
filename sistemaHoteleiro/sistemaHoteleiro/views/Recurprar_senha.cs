using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro
{
    public partial class Recurprar_senha : MetroFramework.Forms.MetroForm
    {

        int tokens = 0;


        public Recurprar_senha()
        {
            InitializeComponent();
        }

        private void Recurprar_senha_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        public bool verifica()
        {
            string email = "";

            bool validacao = email.Contains("@") && email.Contains(".com");

            if (validacao == true)
            {
                return true;
            }               
            return false;
            
        }

        public void enviar_email()
        {
            
        }

        protected int  gerar_token()
        {
            Random randNum = new Random();
            int token = randNum.Next(1001);
            return token;

        }
        
        public void verificar_token()
        {
            
            try
            {
                int token_email = int.Parse(txt_code.Text);
                if (tokens == token_email)
                {
                    MessageBox.Show("Pode trocar de senha");
                    tokens = 0;
                }
                else
                {
                    MessageBox.Show("Codigo de verificação com esta incorreto");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error");
            }
          
        }
        


        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            bool emailValidado = false;
            emailValidado = verifica();
            if (emailValidado == true)
            {
                painel_recuperar_senha.Visible = false;
                enviar_email();
                panel_code.Visible = true;
                MessageBox.Show("Foi");
            }
            else
            {
                lbl_invalido.Text = "Email invalido!";
            }
            


        }

        private void btn_verificar_token_Click(object sender, EventArgs e)
        {
            verificar_token();
        }

        private void panel_code_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}