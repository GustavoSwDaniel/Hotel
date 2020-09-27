using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.views.Administrativo
{
    public partial class FuncionarioList : Form
    {
        public FuncionarioList()
        {
            InitializeComponent();
        }

        private void FuncionarioList_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'teste2DataSet2.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.teste2DataSet2.funcionario);

        }
    }
}
