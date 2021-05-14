using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    class login:login_details
    {
        public string Prezdivka { get; set; }//proměnné pro přihlašování
        public string Mail { get; set; }
        public string Heslo { get; set; }
         
        public login(string prezdivka, string mail, string heslo)//přidání proměnných přezdívka, mail, heslo do konstruktoru
        {
            Prezdivka = prezdivka;
            Mail = mail;
            Heslo = heslo;
        }

    }
}
