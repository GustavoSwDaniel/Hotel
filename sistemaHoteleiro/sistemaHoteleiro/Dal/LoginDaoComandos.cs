using sistemaHoteleiro.controlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.Dal
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; // Tudo ok = vazia
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {

            //Procurar no banco esse login e senha
            cmd.CommandText = "select * from funcionarios where cpf = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows) // se foi encontrado
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return tem;
        }


        public String cadastrarHospede()
        {

            return mensagem;
        }
    }
}
