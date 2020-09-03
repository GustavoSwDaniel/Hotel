using Correios.CorreiosServiceReference;
using sistemaHoteleiro.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.Controllers
{
    class FuncionarioController
    {
        public bool InseirFuncionario(Funcionarios fn)
        {
            FuncionarioDAO f = new FuncionarioDAO();
            return f.CadastrarFuncionario(fn);
        }
    }
}
