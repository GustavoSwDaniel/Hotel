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

namespace sistemaHoteleiro.pages
{
    public partial class CadastrarHospedes : Form
    {
        public CadastrarHospedes()
        {
            InitializeComponent();
            QuartoDAO qd = new QuartoDAO();
            DataTable quartos = qd.CarregarQuartosNoComboBox();
            numDoQuarto.DisplayMember = "quarto_completo";
            numDoQuarto.DataSource = quartos;
          

        }

        private void txt_cep_Leave(object sender, EventArgs e)
        {
            try
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var retorno = correiosApi.consultaCEP(txt_cep.Text);

                txt_estado.Text = retorno.cidade;
                txt_cidade.Text = retorno.uf;

                lbl_vazio.Visible = false;
            }
            catch (Exception)
            {
                lbl_vazio.Visible = true;
                txt_cep.Clear();
            }
        }

        private void numDeQuartos_Leave(object sender, EventArgs e)
        {
            bool resp = Validacao.ValidaCPF.ValidarEntradaInt(numDeQuartos.Text);
            if (resp)
                lbl_avisoN.Visible = false;
            else
                lbl_avisoN.Visible = true;
        }


        private void txt_email_Leave(object sender, EventArgs e)
        {
            bool teste = Validacao.ValidaCPF.ValidarEmail(txt_email.Text);
            if (teste)
                lbl_avisoE.Visible = true;
            else
                lbl_avisoE.Visible = false;
        }


        private void ck_empresa_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_empresa.Checked == true)
            {
                cb_cpnj.Visible = true;
            }
            else
            {
                cb_cpnj.Visible = false;
            }
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


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            bool status_pagamento;

            if (cbPagamentos.Checked)
            {
                status_pagamento = true;
            }
            else
            {
                status_pagamento = false;
            }

            bool resp = !string.IsNullOrWhiteSpace(txt_nome.Text) &&
                      !string.IsNullOrWhiteSpace(txt_email.Text) &&
                      !string.IsNullOrWhiteSpace(mtxt_cpf.Text) &&
                      !string.IsNullOrWhiteSpace(txt_cep.Text) &&
                      !string.IsNullOrWhiteSpace(txt_cidade.Text) &&
                      !string.IsNullOrWhiteSpace(txt_estado.Text) &&
                      !string.IsNullOrWhiteSpace(dataN.Text) &&
                      !string.IsNullOrWhiteSpace(dataE.Text) &&
                      !string.IsNullOrWhiteSpace(dataS.Text);

            
            
            if (resp == true)
            {
                string num = numDoQuarto.Text;
                string[] infoQuarto = num.Split('-');
         

                string nomeCompleto = txt_nome.Text;
                string email = txt_email.Text;
                string tell = mtxt_telefone.Text.Replace(" ", "").Replace("(", "").Replace("-", "");
                string cell = mtxt_celular.Text.Replace(" ", "").Replace("(", "").Replace("-", "");
                string cpf = mtxt_cpf.Text;
                string cep = txt_cep.Text;
                string cidade = txt_cidade.Text;
                string estado = txt_estado.Text;
                DateTime dataNas = dataN.Value.Date;
                string timQ = infoQuarto[1];
                string numeroDeQuartos = numDeQuartos.Text;
                string numeroDoQuarto = infoQuarto[0];
                DateTime dataEn = dataE.Value;
                DateTime dataSa = dataS.Value;

                Hospedes hp = new Hospedes(nomeCompleto, email, tell, cell, cpf, cep, cidade, estado, dataNas, timQ, numeroDeQuartos, numeroDoQuarto, dataEn, dataSa, status_pagamento);
                HospedeController hc = new HospedeController();
                if (hc.InserirHospede(hp))
                {
                    MessageBox.Show("Cadastro Realizado com sucesso!", "Aviso", MessageBoxButtons.OK);
                    limpar();
                }
            }
            else
            {
                lbl_aviso.Visible = false;
            }
        }

        private void limpar()
        {
            txt_nome.Clear();
            txt_email.Clear();
            mtxt_telefone.Clear();
            mtxt_cpf.Clear();
            txt_cep.Clear();
            txt_cidade.Clear();
            txt_estado.Clear();
            txt_nome.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void panel_cadastroH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbPagamentos_CheckStateChanged(object sender, EventArgs e)
        {
           


           
        }
    }
}
