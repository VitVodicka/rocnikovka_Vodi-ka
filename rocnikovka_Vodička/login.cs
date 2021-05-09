using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    class login:login_details
    {
        public string Prezdivka { get; set; }
        public string Mail { get; set; }
        public string Heslo { get; set; }
         
        public login(string prezdivka, string mail, string heslo)
        {
            Prezdivka = prezdivka;
            Mail = mail;
            Heslo = heslo;
        }

    }
}
