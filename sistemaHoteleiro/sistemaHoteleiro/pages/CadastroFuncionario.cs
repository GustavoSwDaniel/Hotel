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
using sistemaHoteleiro.pages;

namespace sistemaHoteleiro
{
    public partial class CadastroFuncionario : Form
    {

        String txt = "1";
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void txt_csenha_Leave(object sender, EventArgs e)
        {
            if(txt_senha.Text.Equals(txt_csenha))
            {
                lbl_senhaI.Visible = true;
            }
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txt_cep_Leave(object sender, EventArgs e)
        {
            if ((txt_cep.TextLength == 8) && !string.IsNullOrEmpty(txt_cep.Text))
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(txt_cep.Text);

                    txt_estado.Text = retorno.cidade;
                    txt_cidade.Text = retorno.uf;

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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Hotel ht = new Hotel();
            ht.AbrirFormaInPainel(new TelaInicial());
        }
    
    }
}
