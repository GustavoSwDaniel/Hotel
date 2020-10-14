using sistemaHoteleiro.Controllers;
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

namespace sistemaHoteleiro.views.RecursosAdministrativos
{
    public partial class ExcluirFuncionario : Form
    {
        public ExcluirFuncionario()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {
            HospedeDAO hd = new HospedeDAO();
            SqlDataReader read = hd.PesquisarFuncionario(txt_cpf.Text);
            txt_nome.Text = read[1].ToString();
            txt_email.Text = read[2].ToString();
            mtxt_cpf.Text = read[3].ToString();
            txt_salario.Text = read[5].ToString();
            mtxt_telefone.Text = read[6].ToString(); 
            mtxt_celular.Text = read[7].ToString();
            txt_cidade.Text = read[8].ToString();
            txt_uf.Text = read[9].ToString();
            txt_ender.Text = read[10].ToString();
            txt_cargo.Text = read[11].ToString();
            mtxt_DataN.Text = read[12].ToString();
            mtxt_DataA.Text = read[13].ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            HospedeDAO hd = new HospedeDAO();
            bool response = hd.ExcluirFuncionario(txt_cpf.Text);
            if(response)
            {
                MessageBox.Show("Funcionario excluido com sucesso!");
            }
        }
    }
}
