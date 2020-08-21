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
    public partial class Recurprar_senha : MetroFramework.Forms.MetroForm
    {

        int token = 0;


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
            string email = txt_email.Text;

            bool validacao = email.Contains("@") && email.Contains(".com");

            if (validacao == true)
            {
                enviar_email();
                return true;
            }               
            return false;
            
        }

        public void enviar_email()
        {
            string email = txt_email.Text;
            token = gerar_token();
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add(email);
            message.Subject = "Alteração de Senha";
            message.From = new System.Net.Mail.MailAddress("gustavodanieldetoledo@gmail.com");
            message.Body =
                "*Troca de senha*\n" +
                token + "Esse é seu codigo de verificação pra trocar a sua senha\n" +
                "Caso você não tenha feito essa solicitação por favor ignore esta mensagem";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("yoursmtphost");
            smtp.Send(message);
        }

        protected int gerar_token()
        {
            int token = 0;
            Random randNum = new Random();
            token = randNum.Next();

            return token;
        }
        
        public bool verificar_token()
        {
            int token_email = Convert.ToInt32(txt_code.Text);

            if(token == token_email)
            {
                MessageBox.Show("Pode trocar de senha");
            }
            else
            {
                MessageBox.Show("Codigo de verificação com esta correto");
            }

            return false;
        }
        


        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            bool emailValidado = false;
            emailValidado = verifica();
            if (emailValidado == true)
            {
                painel_recuperar_senha.Enabled = false;
                enviar_email();
            }
            else
            {
                lbl_invalido.Text = "Email invalido!";
            }
            


        }
    }
}