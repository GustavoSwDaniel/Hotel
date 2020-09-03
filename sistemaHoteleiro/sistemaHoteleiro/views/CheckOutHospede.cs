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
        public CheckOutHospede()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            quartosTableAdapter.FillBySelect(hotelDataSet.quartos, txt_cpf.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string id = dataGridQuartos.CurrentRow.Cells[0].Value.ToString();
                string cpf = dataGridQuartos.CurrentRow.Cells[1].Value.ToString();
                string name = dataGridQuartos.CurrentRow.Cells[2].Value.ToString();
                HospedeDAO hd = new HospedeDAO();
                bool resp = hd.checkoutHospede(id, cpf, name);

                if (resp)
                    MessageBox.Show("Check Out realizado com Sucesso!!");
            }
            catch(System.Exception)
            {
                MessageBox.Show("Por favor selecione algo");
            }
        }

        private void lbl_cpf_Click(object sender, EventArgs e)
        {

        }

        private void lblnumQ_Click(object sender, EventArgs e)
        {

        }
    }
}
