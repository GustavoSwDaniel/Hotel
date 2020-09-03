using sistemaHoteleiro.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.Controllers
{
    class HospedeController
    {
        public bool InserirHospede(Hospedes hp)
        {
            HospedeDAO h = new HospedeDAO();
            return h.CadastrarHospede(hp);
        }

    }
}
