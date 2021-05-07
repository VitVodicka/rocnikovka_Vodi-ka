using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    class login_details:INotifyPropertyChanged
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

            Zmena("listPrihlasovani");
            Zmena("prezdivkaInput");
            Zmena("mailInput");
            Zmena("hesloInput");
        }
        public void Delete(login log)
        {
            listPrihlasovani.Remove(log);
            Zmena("listPrihlasovani");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Zmena(string vlastnost)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(vlastnost));
            }
        }
    }
}
