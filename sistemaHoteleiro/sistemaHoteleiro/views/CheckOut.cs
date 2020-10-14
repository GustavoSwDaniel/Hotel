using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.views
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void pnl_CheckOut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // int t = buscaTableAdapter.Fill(teste2DataSet.Busca, txt_cpf.Text);
            MessageBox.Show("teste");

        }
        private void carregarDados()
        {

            try
            {

                MessageBox.Show(mskCheckIn.Text + " " + mskCheckInOut.Text);
                txt_nome.Text = dataGridQuartos.CurrentRow.Cells[3].Value.ToString();
                txtCpf.Text = dataGridQuartos.CurrentRow.Cells[4].Value.ToString();
                mskCheckIn.Text = dataGridQuartos.CurrentRow.Cells[8].Value.ToString();
                mskCheckInOut.Text = dataGridQuartos.CurrentRow.Cells[9].Value.ToString();
                lbl_statusQ.Text = dataGridQuartos.CurrentRow.Cells[5].Value.ToString();
                //TimeSpan diasHospededados = Convert.ToDateTime(mskCheckInOut.Text) - Convert.ToDateTime(mskCheckIn.Text);
                int totalDias = (DateTime.Parse(mskCheckInOut.Text).Subtract(DateTime.Parse(mskCheckIn.Text))).Days;

                totalDias = totalDias * -1;

                //int totalDias = diasHospededados.Days;
                txt_num.Text = totalDias.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_valor_Click(object sender, EventArgs e)
        {

        }
    }
}


/***
 if (lbl_statusQ.Text == "pago")
            {
                try
                {
                    int idQuarto = Convert.ToInt32(dataGridQuartos.CurrentRow.Cells[0].Value);
                    int idHospede = Convert.ToInt32(dataGridQuartos.CurrentRow.Cells[1].Value);
                    int numQuarto = Convert.ToInt32(dataGridQuartos.CurrentRow.Cells[2].Value);
                    string nome = dataGridQuartos.CurrentRow.Cells[3].Value.ToString();
                    HospedeDAO hd = new HospedeDAO();
                    bool resp = hd.checkoutHospede(idQuarto, idHospede, numQuarto, nome);

                    if (resp)
                        MessageBox.Show("Check Out realizado com Sucesso!!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }
            else
            {
                MessageBox.Show("Pagamento Necessario para a realização do Check Out!!", "Aviso", MessageBoxButtons.OK);
            }
 


    }
}*/
