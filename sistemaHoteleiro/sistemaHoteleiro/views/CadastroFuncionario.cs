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
using sistemaHoteleiro.Controllers;
using sistemaHoteleiro.models;
using sistemaHoteleiro.pages;

namespace sistemaHoteleiro
{
    public partial class CadastroFuncionario : Form
    {

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

       

        private void txt_csenha_Leave(object sender, EventArgs e)
        {
            if (txt_senha.Text.Equals(txt_csenha.Text))
                lbl_senhaI.Visible = false;
            else
                lbl_senhaI.Visible = true;
        }

        private void txt_cep_Leave(object sender, EventArgs e)
        {
            if ((txt_cep.TextLength == 8) && !string.IsNullOrEmpty(txt_cep.Text))
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(txt_cep.Text);

                    txt_cidade.Text = retorno.cidade;
                    txt_estado.Text = retorno.uf;

                    lbl_vazio.Visible = false;
                    

                }
                catch(Exception )
                {
                    lbl_vazio.Visible = true;
                    txt_cep.Clear();
                }
            }
            else
            {
                lbl_vazio.Visible = true;
            }
        }

      

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            Hash hs = new Hash();

            bool resp = !string.IsNullOrWhiteSpace(txt_nome.Text) &&
                      !string.IsNullOrWhiteSpace(txt_email.Text) &&
                      !string.IsNullOrWhiteSpace(mtxt_cpf.Text) &&
                      !string.IsNullOrWhiteSpace(mtxt_celular.Text) &&
                      !string.IsNullOrWhiteSpace(txt_cep.Text) &&
                      !string.IsNullOrWhiteSpace(txt_cidade.Text) &&
                      !string.IsNullOrWhiteSpace(txt_estado.Text) &&
                      !string.IsNullOrWhiteSpace(txt_rua.Text) &&
                      !string.IsNullOrWhiteSpace(txt_salario.Text) &&
                      !string.IsNullOrWhiteSpace(cb_cargo.Text) &&
                      !string.IsNullOrWhiteSpace(dataN.Text);

            if(resp == true)
            {
                string nomeCompleto = txt_nome.Text;
                string email = txt_email.Text;
                string tell = mtxt_telefone.Text;
                string senha = hs.BhashPassword(txt_senha.Text);
                string cell = mtxt_celular.Text;
                string cpf = mtxt_cpf.Text;
                string cep = txt_cep.Text;
                string cidade = txt_cidade.Text;
                string estado = txt_estado.Text;
                string rua = txt_rua.Text;
                float salario;
                float.TryParse(txt_salario.Text, out salario);
                string cargo = cb_cargo.Text;
                DateTime dataNas = dataN.Value;
                DateTime DataAd = DateTime.Now;

                Funcionarios fn = new Funcionarios(nomeCompleto, email, senha, tell, cell, cpf, cep, cidade, estado, rua, salario, cargo, dataNas, DataAd);
                FuncionarioController fc = new FuncionarioController();
                if(fc.InseirFuncionario(fn))
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso", "Sucesso");
                }
            
            }
            else
            {
                lbl_aviso.Visible = false;
            }


        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            bool teste = Validacao.ValidaCPF.ValidarEmail(txt_email.Text);
            if (teste)
                lbl_avisoE.Visible = true;
            else
                lbl_avisoE.Visible = false;
        }
    }
}
/*Hash hs = new Hash();
           string hash = hs.BhashPassword(txt_senha.Text);
           bool teste = hs.BhashVerify(txt_csenha.Text, hash);
           if (teste)
               MessageBox.Show("Senhas são iguais");
           else
               MessageBox.Show("Senhas são difrentes");*/