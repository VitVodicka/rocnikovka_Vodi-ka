using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    class login_details
    {
        public List<login> listPrihlasovani { get; set; }
        public login_details()
        {
            listPrihlasovani = new List<login>();
        }
        public void addingToList(string prezdivkaInput, string mailInput, string hesloInput)
        {
            login prihlaseni = new login(prezdivkaInput, mailInput, hesloInput);
            listPrihlasovani.Add(prihlaseni);
        }
    }
}
