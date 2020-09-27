﻿using sistemaHoteleiro.controlers;
using sistemaHoteleiro.Controllers;
using sistemaHoteleiro.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteleiro.Dal
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; // Tudo ok = vazia
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        
        
        private bool verificarcpfdb(string cpf)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT cpf FROM funcionario WHERE cpf=@cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            SqlDataReader read = cmd.ExecuteReader();

            if(read.Read())
            {
                con.desconectar();
                return true;
            }
            con.desconectar();
            return false;
        }



        public bool verificarLogin(string login, string senha)
        {


            bool resp = verificarcpfdb(login);
            if (resp)
            {


                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = @"SELECT senha FROM funcionario WHERE cpf=@cpfS;";
                    cmd.Parameters.AddWithValue("@cpfS", login);
                    MessageBox.Show("Entrei");
                    dr = cmd.ExecuteReader();
                    DataTable pwh = new DataTable();
                    pwh.Load(dr);
                    string hash = (string)pwh.Rows[0][0];
                    Hash hs = new Hash();
                    MessageBox.Show("Alo" + senha + hash);

                    bool res = hs.BhashVerify(senha, hash);
                    if (res) // se foi encontrado
                    {
                        tem = true;
                    }
                    return tem;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Erro: " + ex);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Login ou senha invalida");
                return false;
            }
        }


        public String cadastrarHospede()
        {

            return mensagem;
        }
    }
}
