using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace sistemaHoteleiro.models
{
    class Hash
    {
        public string BhashPassword(string Password)
        {

            string hash = BCrypt.Net.BCrypt.HashPassword(Password);
            return hash;
        }

        public bool BhashVerify(string Password, string PassawordHash)
        {
            try
            {
                bool HashVerify = BCrypt.Net.BCrypt.Verify(Password, PassawordHash);
                if (HashVerify)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(BCrypt.Net.SaltParseException e)
            {
                
                return false;
            }
        }
    }
}
