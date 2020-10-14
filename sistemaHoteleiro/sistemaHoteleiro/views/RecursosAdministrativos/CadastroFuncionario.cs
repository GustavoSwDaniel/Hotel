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
using Correios.CorreiosServiceReference;
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
            try
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var retorno = correiosApi.consultaCEP(txt_cep.Text);

                txt_estado.Text = retorno.uf;
                txt_cidade.Text = retorno.cidade;

                lbl_vazio.Visible = false;
            }
            catch (System.Exception)
            {
                lbl_vazio.Visible = true;
                txt_cep.Clear();
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

            bool verifica = Validacao.ValidaCPF.IsCpf(mtxt_cpf.Text);

            if (resp && verifica)
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

        private void txt_email_Leave(object sender, EventArgs e)
        {
            bool teste = Validacao.ValidaCPF.ValidarEmail(txt_email.Text);
            if (teste)
                lbl_avisoE.Visible = true;
            else
                lbl_avisoE.Visible = false;
        }

        private void mtxt_cpf_Leave(object sender, EventArgs e)
        {
            string cpf = mtxt_cpf.Text;


            if (!Validacao.ValidaCPF.IsCpf(cpf))
            {
                lbl_cpfInvalido.Visible = true;
                mtxt_cpf.Clear();
            }
            else
            {
                lbl_cpfInvalido.Visible = false;
            }
        }
        private void limpar()
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
            mtxt_telefone.Clear();
            mtxt_celular.Clear();
            mtxt_cpf.Clear();
            txt_cep.Clear();
            txt_cidade.Clear();
            txt_estado.Clear();
            txt_rua.Clear();
            txt_salario.Clear();
            txt_nome.Focus();
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}