using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.models
{
    public class Base
    {
        public string nomeCompleto { get; set; }
        public string email { get; set; }
        public string tell { get; set; }
        public string cell { get; set; }
        public string cpf { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public DateTime dataN { get; set; }
    }
}
