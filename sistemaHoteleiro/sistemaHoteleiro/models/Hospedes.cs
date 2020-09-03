using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.models
{
    public class Hospedes:Base
    {
        
        public string cnpj              { get;  set; }
        public string timQ             { get;  set; }
        public DateTime dataE          { get;  set; }
        public DateTime dataS          { get;  set; }
        public string numeroDeQuartos { get; set; }
        public string numeroDoQuarto { get; set; }




        public Hospedes(string nc, string email, string tell, string cell, string cpf, string cep, string cidade, string estado, DateTime dataN, string timQ, string numeroDeQuartos, string numeroDoQuarto, DateTime dataE, DateTime dataS)
        {
            this.nomeCompleto = nc;
            this.email = email;
            this.tell = tell;
            this.cell = cell;
            this.cpf = cpf;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.dataN = dataN;
            this.timQ = timQ;
            this.numeroDeQuartos = numeroDeQuartos;
            this.numeroDoQuarto = numeroDoQuarto;
            this.dataE = dataE;
            this.dataS = dataS;
        }


        public Hospedes(string nc, string email, string cell, string cpf ,string cep, string cidade, string estado, DateTime dataN, string timQ, string numeroDoQuarto, string numeroDeQuarto, DateTime dataE, DateTime dataS)
        {
            this.nomeCompleto = nc;
            this.email = email;
            this.cell = cell;
            this.cpf = cpf;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.dataN = dataN;
            this.timQ = timQ;
            this.numeroDeQuartos = numeroDeQuarto;
            this.numeroDoQuarto = numeroDoQuarto;
            this.dataE = dataE;
            this.dataS = dataS;
        }


        public Hospedes(string nc, string email, string cell, string tell, string cpf, string cnpj, string cep, string cidade, string estado, DateTime dataN, string timQ, string numeroDeQuartos, string numeroDoQuarto, DateTime dataE, DateTime dataS)
        {
            this.nomeCompleto = nc;
            this.email = email;
            this.tell = tell;
            this.cell = tell;
            this.cpf = cpf;
            this.cnpj = cnpj;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.dataN = dataN;
            this.timQ = timQ;
            this.numeroDeQuartos = numeroDeQuartos;
            this.numeroDoQuarto = numeroDoQuarto;
            this.dataE = dataE;
            this.dataS = dataS;
        }
    }
    
    
}
