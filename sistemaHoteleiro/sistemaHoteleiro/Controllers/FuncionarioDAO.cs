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
    class FuncionarioDAO
    { 
        private SqlCommand cmd { get; set; }
        private Conexao Con { get; set; }

        public FuncionarioDAO()
        {
            Con = new Conexao();
            cmd = new SqlCommand();
        }


        private bool VerificarSeCpfExiste(string cpf)
        {
            cmd.Connection = Con.Conectar();
            cmd.CommandText = @"SELECT cpf FROM funcionarios WHERE cpf=@cpf_f ";
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
                cmd.CommandText = @"INSERT INTO funcionarios VALUES(@Nome, @email, @cpf, @senha, @salario, @telefone, @celular, @cidade, @uf, @endereco, @cargo, @data_nascimento, @data_admissao)";
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
                    return true;
                return false;    
            }
            return false;
        }
    }
}

/*
 id INTEGER IDENTITY(1001,1) PRIMARY KEY NOT NULL,
	Nome varchar(50) NOT NULL,
	sobrenome varchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	senha varchar(150) NOT NULL,
	telefone varchar(10),
	cidade  varchar(50) NOT NULL,
	uf varchar(2) not null,
	celular varchar(11),
	cpf varchar(11) NOT NULL,
	endereco  varchar(100) NOT NULL,
	salario decimal(10,2) NOT NULL,
	cargo varchar(50) NOT NULL,
	data_nascimento date NOT NULL,
	data_admisao date
);
 */