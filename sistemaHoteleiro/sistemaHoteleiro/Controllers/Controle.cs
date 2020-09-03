
using sistemaHoteleiro.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaHoteleiro.models
{
    class Controle
    {

        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {

            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;

        }


        public String cadastrar(String email, String senha)
        {
            //Comando pra inserir 
            return mensagem;
        }
    }
}
