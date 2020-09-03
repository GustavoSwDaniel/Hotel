using Correios.CorreiosServiceReference;
using sistemaHoteleiro.controlers;
using sistemaHoteleiro.models;
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
    class HospedeDAO : Conexao
    {

        
        private Conexao Con { get; set; }

        private SqlCommand cmdHospedes { get; set; }
        private SqlCommand cmdQuartos { get; set; }
        private SqlCommand cmdRegistros { get; set; }
        private SqlCommand cmd { get; set; }

        public HospedeDAO()
        {
            Con = new Conexao();
            cmd = new SqlCommand();
        }

        private bool verificarSeCpfExiste(string cpf, string numeroDeQuartos)
        {
            if (Convert.ToInt32(numeroDeQuartos) == 1)
            {
                cmd.Connection = Con.Conectar();
                cmd.CommandText = @"SELECT cpf_hospede FROM quartos WHERE cpf_hospede=@cpfhospede";
                cmd.Parameters.AddWithValue("@cpfhospede", cpf);
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("CPF já cadastrado");
                    Con.desconectar();
                    return false;
                }
                else
                {
                    MessageBox.Show("Bora!!" + numeroDeQuartos);
                    Con.desconectar();
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private bool verificarSeQuartoEstaOcupado(string numeroDeQuarto)
        {
            cmd.Connection = Con.Conectar();
            cmd.CommandText = @"SELECT cpf_hospede FROM quartos WHERE id_quarto=@idQuarto";
            cmd.Parameters.AddWithValue("@idQuarto", numeroDeQuarto);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                MessageBox.Show("Quarto Ocupado");
                Con.desconectar();
                return false;
            }
            else
            {
                MessageBox.Show("Bora!!" + numeroDeQuarto);
                Con.desconectar();
                return true;
            }
        }

        public bool CadastrarHospede(Hospedes hp)
        {
            bool respC = verificarSeCpfExiste(hp.cpf, hp.numeroDeQuartos);
            bool respQ = verificarSeQuartoEstaOcupado(hp.numeroDoQuarto);


            if (respC == true && respQ == true)
            {
                MessageBox.Show("Cadastrando hospede!!");
                cmdHospedes = Con.CreatCom();
                cmdQuartos = Con.CreatCom();
                cmdRegistros = Con.CreatCom();
                Con.Conectar();



                cmdHospedes.CommandText = @"INSERT INTO hospedes VALUES(@nome, @email, @numero_do_quarto, @telefone, @celular, @cpf, @cnpj, @cep, @cidade, @uf, @data_nascimento, @data_entrada, @data_saida)";

                cmdHospedes.Parameters.AddWithValue("@nome", hp.nomeCompleto);
                cmdHospedes.Parameters.AddWithValue("@email", hp.email);
                cmdHospedes.Parameters.AddWithValue("@numero_do_quarto", hp.numeroDoQuarto);
                cmdHospedes.Parameters.AddWithValue("@telefone", hp.tell);
                cmdHospedes.Parameters.AddWithValue("@celular", hp.cell);
                cmdHospedes.Parameters.AddWithValue("@cpf", hp.cpf);
                cmdHospedes.Parameters.AddWithValue("@cnpj", "a");
                cmdHospedes.Parameters.AddWithValue("@cep", hp.cep);
                cmdHospedes.Parameters.AddWithValue("@cidade", hp.cidade);
                cmdHospedes.Parameters.AddWithValue("@uf", hp.estado);
                cmdHospedes.Parameters.AddWithValue("@data_nascimento", SqlDbType.DateTime).Value = hp.dataN;
                cmdHospedes.Parameters.AddWithValue("@data_entrada", SqlDbType.DateTime).Value = hp.dataE;
                cmdHospedes.Parameters.AddWithValue("@data_saida", SqlDbType.DateTime).Value = hp.dataS;

                cmdQuartos.CommandText = @"INSERT INTO quartos VALUES(@id_quarto, @cpf_hospede, @nome_do_hospede, @tipo_do_quarto, @dataEntrada, @dataSaida)";
                cmdQuartos.Parameters.AddWithValue("@id_quarto", hp.numeroDoQuarto);
                cmdQuartos.Parameters.AddWithValue("@cpf_hospede", hp.cpf);
                cmdQuartos.Parameters.AddWithValue("@nome_do_hospede", hp.nomeCompleto);
                cmdQuartos.Parameters.AddWithValue("@tipo_do_quarto", hp.timQ);
                cmdQuartos.Parameters.AddWithValue("@dataEntrada", SqlDbType.DateTime).Value = hp.dataN;
                cmdQuartos.Parameters.AddWithValue("@dataSaida", SqlDbType.DateTime).Value = hp.dataE;

                string status = "ocupado";
                cmdRegistros.CommandText = @"UPDATE registrosQuartos SET status_quarto=@status WHERE numero_do_quarto=@quarto";
                cmdRegistros.Parameters.AddWithValue("@quarto", hp.numeroDoQuarto);
                cmdRegistros.Parameters.AddWithValue("@status", status);

                SqlTransaction tran = Con.Transacoes();

                try
                {

                    cmdHospedes.Transaction = tran;
                    cmdHospedes.ExecuteNonQuery();

                    cmdQuartos.Transaction = tran;
                    cmdQuartos.ExecuteNonQuery();

                    cmdRegistros.Transaction = tran;
                    cmdRegistros.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch (SqlException ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Erro!" + ex);
                    return false;
                }
                finally
                {
                    Con.desconectar();
                }
            }
            return false;
        }
    
       public bool checkoutHospede(string id, string cpf, string name)
       {
            
            
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja realizar o Check Out de " + name + "?", "Check Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Con.Conectar();
                string status = "vazio";
                cmdQuartos.CommandText = @"DELETE FROM quartos WHERE id_quarto = @id";
                cmdQuartos.Parameters.AddWithValue("@id", id);
                cmdHospedes.CommandText = @"DELETE FROM hospedes WHERE cpf = @cpf";
                cmdHospedes.Parameters.AddWithValue("@cpf", cpf);
                cmd.CommandText = @"UPDATE registrosQuartos SET status_quarto = @status_quarto";
                cmd.Parameters.AddWithValue("@status_quarto", status);

                SqlTransaction tran = Con.Transacoes();
                try
                {
                    cmdHospedes.Transaction = tran;
                    cmdHospedes.ExecuteNonQuery();

                    cmdQuartos.Transaction = tran;
                    cmdQuartos.ExecuteNonQuery();

                    cmdRegistros.Transaction = tran;
                    cmdRegistros.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch(SqlException ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Erro" + ex);
                    return false;
                }
                finally
                {
                    Con.desconectar();
                }
             
            }
            return false;
        }
       
    }
}
