using sistemaHoteleiro.controlers;
using sistemaHoteleiro.Dal;
using sistemaHoteleiro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro
{


    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private Conexao Con { get; set; }

        private SqlCommand cmd { get; set; }

        int cont = 0;

        public Login()
        {
            InitializeComponent();

            Con = new Conexao();
            cmd = new SqlCommand("dbo.create_default_user");
            cmd.Connection = Con.Conectar();

            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Con.desconectar();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error" + ex);
                cmd.Dispose();
                Con.desconectar();
            }
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(User_text.Text, passworld_text.Text);
            LoginDaoComandos lc = new LoginDaoComandos();
            string privilegio =lc.privilegio(User_text.Text);
          
            if (controle.tem)
            {
                if (privilegio != null)
                {
                    button1.Visible = false;
                    circularProgressBar1.Visible = true;
                    progressBar();
                    timer2.Start();

                    await Task.Delay(3800);
                    
                    Hotel formPrinc = new Hotel();
                    formPrinc.cargo = privilegio;
                    Hide();
                    formPrinc.ShowDialog();
                }
                
            }
            else
            {
                lbl_login_invalido.Visible = true;
                User_text.Clear();
                passworld_text.Clear();
                User_text.Focus();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recurprar_senha Recurprar_senha = new Recurprar_senha();
            Recurprar_senha.Show();
            this.Hide();

        }

        private void btn_exite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if(cont == 100)
            {
                timer1.Stop();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void progressBar()
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer2.Stop();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
