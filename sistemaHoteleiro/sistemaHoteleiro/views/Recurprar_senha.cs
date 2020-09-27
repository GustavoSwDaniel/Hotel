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
using sistemaHoteleiro.controlers;
using sistemaHoteleiro.Controllers;
using Validacao;

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

        public bool ValidaEmail(string email)
        {

            bool validacao = email.Contains("@") && email.Contains(".com");

            if (validacao == true)
            {
                return true;
            }               
            return false;
            
        }

        public void enviar_email(string email)
        {
            MailMessage mail = new MailMessage();
            tokens = gerar_token();

            mail.From = new MailAddress("hoteleirosistema@gmail.com");
            mail.To.Add(email); // para
            mail.Subject = "Teste"; // assunto
            mail.Body = "Codigo de verficação para troca de senha " + tokens + " Caso não tenha solicidade apenas ignore"; // mensagem
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
        

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            if (Validacao.ValidaCPF.IsCpf(cpf_txt.Text))
            {
                FuncionarioDAO funDao = new FuncionarioDAO();
                string email = funDao.RetornaEmail(cpf_txt.Text);
                enviar_email(email);
                painel_recuperar_senha.Visible = false;
                panel_code.Visible = true;

            }
            else
            {
                MessageBox.Show("CPF não cadastradado");
            }
            


        }

        public bool verificar_token(string txt_code)
        {
            MessageBox.Show(tokens.ToString() + txt_code);
           
            try
            {
                int token_email = int.Parse(txt_code);
                if (tokens == token_email)
                {
                    tokens = 0;
                    return true;
                }
                else
                {
                    MessageBox.Show("Codigo de verificação com esta incorreto");
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error");
                return false;
            }

        }

        private void btn_verificar_token_Click(object sender, EventArgs e)
        {
            bool validacao_token = verificar_token(txt_code.Text);

            if (validacao_token)
            {
                panel_code.Visible = false;
                panel_recuperacao.Visible = true;
            }
            else
            {
                MessageBox.Show("Codigo Invalido!!");
            }
        }

        private void panel_code_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painel_recuperar_senha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO funDao = new FuncionarioDAO();

            if (nova_senhaTxt.Text.Equals(confirma_novaSenhaTxt.Text))
            {
                bool response = funDao.trocaSenha(cpf_txt.Text, confirma_novaSenhaTxt.Text);
                if(response)
                {
                    MessageBox.Show("Senha alterada com sucesso");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            else
            {
                aviso.Visible = true;
            }
        }
    }
}