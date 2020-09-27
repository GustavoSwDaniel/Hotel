using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.controlers
{
    public class Conexao
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public Conexao()
        {
            string stringConnection = @"Data Source=DESKTOP-AR2I7GC\SQLEXPRESS;Initial Catalog=teste2;Integrated Security=True";
            con.ConnectionString = stringConnection;

        }
        
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlCommand CreatCom()
        {
            SqlCommand creatCom = con.CreateCommand();
            return creatCom;
        }

        public SqlTransaction Transacoes()
        {
            SqlTransaction tran = con.BeginTransaction();
            return tran;
        }

    

    }
}
