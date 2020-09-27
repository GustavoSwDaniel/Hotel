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
    class FuncionarioDAO : Conexao
    { 
        private SqlCommand cmd { get; set; }
        private Conexao Con { get; set; }

        public FuncionarioDAO()
        {
            Con = new Conexao();
            cmd = new SqlCommand();
        }

        public bool trocaSenha(string cpf, string nova_senha)
        {
            cmd = new SqlCommand("dbo.update_senha");
            cmd.Connection = Con.Conectar();
            Hash hs = new Hash();

            string cry_nova_senha = hs.BhashPassword(nova_senha);
           
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
            cmd.Parameters.Add(new SqlParameter("@nova_senha", cry_nova_senha));

            try
            {           
                cmd.ExecuteNonQuery();
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
   

        public string RetornaEmail(string cpf)
        {
            cmd.Connection = Con.Conectar();
            cmd.CommandText = @"SELECT email From funcionario WHERE cpf=@cpf_e";
            cmd.Parameters.AddWithValue("cpf_e", cpf);
            SqlDataReader read = cmd.ExecuteReader();
            
            if(read.Read())
            {
                string email = read[0].ToString();      
                return email;
            }
            return null;
        }

        private bool VerificarSeCpfExiste(string cpf)
        {
            cmd.Connection = Con.Conectar();
            cmd.CommandText = @"SELECT cpf FROM funcionario WHERE cpf=@cpf_f ";
            cmd.Parameters.AddWithValue("cpf_f", cpf);
            SqlDataReader read = cmd.ExecuteReader();

            if(read.Read())
            {
                MessageBox.Show("CPF já cadastrado, Funcionario já cadastrado");
                Con.desconectar();
                return false;
            }
            Con.desconectar();
            return true;   
        }


        public bool CadastrarFuncionario(Funcionarios fn)
        {
            bool resp = VerificarSeCpfExiste(fn.cpf);

            if(resp)
            {
                cmd.Connection = Con.Conectar();
                cmd.CommandText = @"INSERT INTO funcionario VALUES(@Nome, @email, @cpf, @senha, @salario, @telefone, @celular, @cidade, @uf, @endereco, @cargo, @data_nascimento, @data_admissao) SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@Nome", fn.nomeCompleto);
                cmd.Parameters.AddWithValue("@email", fn.email);
                cmd.Parameters.AddWithValue("cpf", fn.cpf);
                cmd.Parameters.AddWithValue("@senha", fn.senha);
                cmd.Parameters.AddWithValue("@salario", fn.salario);
                cmd.Parameters.AddWithValue("@telefone", fn.tell);
                cmd.Parameters.AddWithValue("@celular", fn.cell);
                cmd.Parameters.AddWithValue("@cidade", fn.cidade);
                cmd.Parameters.AddWithValue("@uf", fn.estado);
                cmd.Parameters.AddWithValue("@endereco", fn.rua);
                cmd.Parameters.AddWithValue("@cargo", fn.cargo);
                cmd.Parameters.AddWithValue("@data_nascimento", SqlDbType.DateTime).Value = fn.dataN;
                cmd.Parameters.AddWithValue("@data_admissao", SqlDbType.DateTime).Value = fn.data_admisao;
                if (cmd.ExecuteNonQuery() == 1)
                {                   
                    return true;
                }
                return false;    
            }
            return false;
        }
    }
}

