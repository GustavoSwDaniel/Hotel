using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace sistemaHoteleiro
{
    class DataBase
    {
        private static string conexao = "Data Source = C:\\Users\\Lobo\\Documents\\GitHub\\Hotel\\sistemaHoteleiro\\sistemaHoteleiro\\DataBase.db";
        private static string nomebanco = "DataBase.db";

        public void criar_banco()
        {
            if(!File.Exists(nomebanco))
            {
                SQLiteConnection.CreateFile(nomebanco);
                SQLiteConnection conn = new SQLiteConnection(conexao);
                conn.Open();
                StringBuilder sql = new StringBuilder();
                sql.Append("CREATE TABLE IF NOTE EXISTS HOSPEDES ([ID]) INTEGER PRIMARY KEY AUTOINCREMENT(1001,1),");
                sql.Append("[nome] TEXT NOT NULL");
                sql.Append("[sobrenome] TEXT NOT NULL");
                sql.Append("[numero_do_quarto] INTEGER NOT NULL");
                sql.Append("[telefone] TEXT");
                sql.Append("[celular] TEXT");
                sql.Append("[endereco] TEXT NOT NULL");
                sql.Append("[data_nascimento] TEXT");
                sql.Append("[data_entrada] TEXT");
                sql.Append("[data_saida] TEXT");


                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    
                }
                catch(Exception e)
                {
                    MessageBox.Show("Deu ruim");
                }

            }
        }
    }
}
