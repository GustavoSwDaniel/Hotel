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

        private SqlCommand cmdU;

        private SqlCommand cmdHospedes { get; set; }
        private SqlCommand cmdQuartos { get; set; }
        private SqlCommand cmdRegistros { get; set; }
        private SqlCommand cmd { get; set; }

        private SqlCommand cmdP { get; set; }

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
                cmd.CommandText = @"SELECT cpf FROM hospedes WHERE cpf=@cpfhospede";
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
            return true;
        }

        public bool CadastrarHospede(Hospedes hp)
        {
            bool respC = verificarSeCpfExiste(hp.cpf, hp.numeroDeQuartos);
            bool respQ = verificarSeQuartoEstaOcupado(hp.numeroDoQuarto);

            string statusPay;
            if(hp.statusPagamento)
            {
                statusPay = "pago";
            }
            else
            {
                statusPay = "pendente";
            }

            if (respC == true && respQ == true)
            {
                MessageBox.Show("Cadastrando hospede!!");
                cmdHospedes = Con.CreatCom();
                cmdQuartos = Con.CreatCom();
                cmdRegistros = Con.CreatCom();
                Con.Conectar();

                SqlTransaction tran = Con.Transacoes();


                cmdHospedes.CommandText = @"INSERT INTO hospedes VALUES(@nome, @email, @numero_do_quarto, @telefone, @celular, @cpf, @cnpj, @cep, @cidade, @uf, @data_nascimento, @data_entrada, @data_saida) SELECT SCOPE_IDENTITY();";
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

                string status = "ocupado";
                cmdRegistros.CommandText = @"UPDATE registrosQuartos SET status_quarto=@status WHERE numero_do_quarto=@quarto";
                cmdRegistros.Parameters.AddWithValue("@quarto", hp.numeroDoQuarto);
                cmdRegistros.Parameters.AddWithValue("@status", status);

                try
                {
                    cmdHospedes.Transaction = tran;
                    int hospede_id = Convert.ToInt32(cmdHospedes.ExecuteScalar());
                    cmdRegistros.Transaction = tran;
                    cmdRegistros.ExecuteNonQuery();
                     
                    cmdQuartos.CommandText = @"INSERT INTO quartos VALUES(@id_quarto, @numero_do_quarto, @hospede_id, @status_de_pagamento)";
                    cmdQuartos.Parameters.AddWithValue("@id_quarto", hp.numeroDoQuarto);
                    cmdQuartos.Parameters.AddWithValue("@numero_do_quarto", hp.numeroDoQuarto);
                    cmdQuartos.Parameters.AddWithValue("@hospede_id", hospede_id);
                    cmdQuartos.Parameters.AddWithValue("@numero_de_ocupantes", 2);
                    cmdQuartos.Parameters.AddWithValue("status_de_pagamento", statusPay);


                    cmdQuartos.Transaction = tran;
                    cmdQuartos.ExecuteNonQuery();
                    
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
    
       public bool checkoutHospede(int idQuarto, int idHospede, int numQuarto, string nome)
       {
            
            
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja realizar o Check Out de " + nome + "?", "Check Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                ///SqlTransaction tran = Con.Transacoes();
                
                cmdP = new SqlCommand("dbo.Excluir");
                cmdP.Connection = Con.Conectar();


                cmdP.CommandType = CommandType.StoredProcedure;
                cmdP.Parameters.Add(new SqlParameter("@idHospede", idHospede));
                cmdP.Parameters.Add(new SqlParameter("@id_quarto", idQuarto));
                cmdP.Parameters.Add(new SqlParameter("numeroQuarto", numQuarto));

                try
                {                  
                    //cmdP.Transaction = tran;
                    cmdP.ExecuteNonQuery();
                    //tran.Commit();
                    return true;
                }
                catch(SqlException ex)
                {
                    ///tran.Rollback();
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

       public bool updade(int quartoAntigo, int quartoNovo)
        {


            cmdU = new SqlCommand("dbo.updadeQuartos");
            cmdU.Connection = Con.Conectar();


            cmdU.CommandType = CommandType.StoredProcedure;
            cmdU.Parameters.Add(new SqlParameter("@novoID", quartoNovo));
            cmdU.Parameters.Add(new SqlParameter("@antigoId", quartoAntigo));
            
            try
            {
                cmdU.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro" + ex);
                return false;
            }
            finally
            {
                Con.desconectar();
            }
        }
       
    }
}
