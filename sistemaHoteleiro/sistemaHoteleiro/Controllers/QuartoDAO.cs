using sistemaHoteleiro.controlers;
using sistemaHoteleiro.models;
using sistemaHoteleiro.pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.Controllers
{
    class QuartoDAO
    {
        private SqlCommand cmd { get; set; }
        private Conexao Con { get; set; }

        public QuartoDAO()
        {
            Con = new Conexao();
            cmd = new SqlCommand();
        }
        
        public DataTable CarregarQuartosNoComboBox()
        {
            //select CAST(numero_do_quarto AS VARCHAR)+ ' - ' + tipo_de_quarto from registrosQuartos;

            try
            {
                cmd.Connection = Con.Conectar();
                cmd.CommandText = @"select * from registroQuartosCompleto;";
                SqlDataReader read = cmd.ExecuteReader();
                DataTable Rquartos = new DataTable();
                Rquartos.Load(read);
                return Rquartos;
            }
            catch
            {
                MessageBox.Show("Nenhum Quarto cadastradado!");
                return null;
            }
            
        }

        private bool verificarSeQuartoExiste(string numeroDeQuarto)
        {
            try
            {
                cmd.Connection = Con.Conectar();
                cmd.CommandText = @"SELECT numero_do_quarto FROM registrosQuartos WHERE numero_do_quarto=@numeroDoQuarto";
                cmd.Parameters.AddWithValue("@numeroDoQuarto", Convert.ToInt32(numeroDeQuarto));
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("Numero do Quarto ja existe" + numeroDeQuarto);
                    Con.desconectar();
                    return false;
                }
                else
                {
                    MessageBox.Show("Cadastrando Quarto" + numeroDeQuarto);
                    Con.desconectar();
                    return true;
                }
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Informe apena numeros!", "Aviso");
                return false;
            }
        }
        
        public bool CadastrarQuarto(Quarto ct)
        {
            bool resp = verificarSeQuartoExiste(ct.numeroDoQuarto);
            if(resp)
            {
                cmd.Connection = Con.Conectar();
                cmd.CommandText = @"INSERT INTO registrosQuartos VALUES(@numero_do_quarto, @tipo_de_quarto, @valor_do_quarto,@status_quarto)";


                string statusQ = "vazio";
                cmd.Parameters.AddWithValue("@numero_do_quarto", Convert.ToInt32(ct.numeroDoQuarto)) ;
                cmd.Parameters.AddWithValue("@tipo_de_quarto", ct.tipoDoQuarto);
                cmd.Parameters.AddWithValue("@valor_do_quarto", SqlDbType.SmallMoney).Value = ct.valorDaDiaria;
                cmd.Parameters.AddWithValue("@status_quarto", statusQ);
               


                if (cmd.ExecuteNonQuery() == 1)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            return false;
        }
    
    }
}

/*
    id_quarto int PRIMARY KEY,
	cpf_hospede varchar(11),
	nome_do_hospede varchar(50),
	tipo_do_quarto varchar(50),
	dataEntrada date,
	dataSaida date
*/