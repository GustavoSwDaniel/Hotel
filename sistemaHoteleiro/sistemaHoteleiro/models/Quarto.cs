using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.models
{
    class Quarto
    {

        public string numeroDoQuarto { get; set; }
        public string tipoDoQuarto { get; set; }

        public float valorDaDiaria { get; set; }

        public Quarto(string numeroDoQuarto, string tipoDoQuarto, float valorDaDiaria)
        {
            this.numeroDoQuarto = numeroDoQuarto;
            this.tipoDoQuarto = tipoDoQuarto;
            this.valorDaDiaria = valorDaDiaria;
        }
    }
}

