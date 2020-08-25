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
            string email = txt_email.Text;

            bool validacao = email.Contains("@") && email.Contains(".com");

            if (validacao == true)
            {
                return true;
            }               
            return false;
            
        }

        public void enviar_email()
        {
            string email = txt_email.Text;
            MailMessage mail = new MailMessage();
            tokens = gerar_token();

            mail.From = new MailAddress("hoteleirosistema@gmail.com");
            mail.To.Add(email); // para
            mail.Subject = "Teste"; // assunto
            mail.Body = "Codigo de verficação para troca de senha" + tokens + "Caso não tenha solicidade apenas ignore"; // mensagem
            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true; // GMail requer SSL
                smtp.Port = 587;       // porta para SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                smtp.Credentials = new System.Net.NetworkCredential("hoteleirosistema@gmail.com", "852456as8");
                // envia o e-mail
                smtp.Send(mail);
            }
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

        private void panel_code_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_verificar_token_Click(object sender, EventArgs e)
        {
            verificar_token();
        }
    }
}