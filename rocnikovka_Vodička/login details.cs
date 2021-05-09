using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    class login_details:INotifyPropertyChanged
    {
        public List<login> listPrihlasovani { get; set; }
        public int Index { get; set; }
        public string Help { get; set; }
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
        public void Comparing(login log)
        {
            
            for (int i = 0; i < listPrihlasovani.Count; i++)
            {
                if(log.Prezdivka == listPrihlasovani[i].Prezdivka)
                {
                    Index = i;
                }
                if (log.Mail == listPrihlasovani[i].Mail)
                {
                    Index = i;
                }
            }
        }

        public void Passcheck(string passInput)
        {
            if (passInput == listPrihlasovani[Index].Heslo)
            {
                hlavni_kalendar hlavni = new hlavni_kalendar();
                hlavni.Show();
                
                
            }
            else
            {
                Help = "Špatné Heslo";
                Thread.Sleep(TimeSpan.FromSeconds(10));//nechá uspat celkový proces do té doby než se napočítá počet sekund a pak proces jede dál
                Help = "";
                    //try a catch
            }
            //ted jen dodělat checkování popup hesla s list heslem a odbugování pomocí try
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
