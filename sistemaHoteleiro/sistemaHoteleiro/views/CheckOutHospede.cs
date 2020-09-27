using DynamicData.Tests;
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

namespace sistemaHoteleiro.views
{
    public partial class CheckOutHospede : Form
    {

        int row;

        public CheckOutHospede()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            row = buscaTableAdapter.Fill(teste2DataSet.Busca, txt_cpf.Text);
            carregarDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
        private void carregarDados()
        {

            if (row > 0)
            {
                txt_nome.Text = dataGridQuartos.CurrentRow.Cells[3].Value.ToString();
                txtCpf.Text = dataGridQuartos.CurrentRow.Cells[4].Value.ToString();
                mskCheckIn.Text = dataGridQuartos.CurrentRow.Cells[8].Value.ToString();
                mskCheckInOut.Text = dataGridQuartos.CurrentRow.Cells[9].Value.ToString();
                lbl_statusQ.Text = dataGridQuartos.CurrentRow.Cells[5].Value.ToString();

                TimeSpan diasHospededados = Convert.ToDateTime(mskCheckIn.Text) - Convert.ToDateTime(mskCheckInOut.Text);

                int totalDias = diasHospededados.Days;
                txt_num.Text = totalDias.ToString();
            }   
            else
            {
                MessageBox.Show("CPF não cadastrado");
            }
              
            
        }

        private void pnl_CheckOut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void title_cadastro_Click(object sender, EventArgs e)
        {

        }
    }
}

