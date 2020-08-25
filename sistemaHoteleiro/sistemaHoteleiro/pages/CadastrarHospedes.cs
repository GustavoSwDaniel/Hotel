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

namespace sistemaHoteleiro.pages
{
    public partial class CadastrarHospedes : Form
    {
        public CadastrarHospedes()
        {
            InitializeComponent();
        }

        private void panel_cadastroH_Paint(object sender, PaintEventArgs e)
        {

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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Hotel ht = new Hotel();
            ht.AbrirFormaInPainel(new TelaInicial());
        }
    }
}
