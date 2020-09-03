using sistemaHoteleiro.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.Controllers
{
    class QuartoController
    {
        public bool CadastrarQuarto(Quarto qt)
        {
            QuartoDAO qtd = new QuartoDAO();
            return qtd.CadastrarQuarto(qt);
        }
       
    }
}
