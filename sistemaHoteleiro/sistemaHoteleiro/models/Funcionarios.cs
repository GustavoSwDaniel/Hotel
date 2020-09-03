using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sistemaHoteleiro.models
{
    public class Funcionarios:Base
    {
        
        public string senha { get; set;}
        public string rua { get; set; }
        public float salario { get; set;  }
        public string cargo { get; set; }
        public DateTime data_admisao { get; set; }
        
        public Funcionarios(string nc, string email, string senha, string tell, string cell, string cpf, string cep, string cidade, string estado, string rua, float salario, string cargo, DateTime dataN, DateTime data_admisao)
        {
            this.nomeCompleto = nc;
            this.email = email;
            this.senha = senha;
            this.tell = tell;
            this.cell = cell;
            this.cpf = cpf;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.rua = rua;
            this.salario = salario;
            this.cargo = cargo;
            this.dataN = dataN;
            this.data_admisao = data_admisao;


        }
      

    }
}
