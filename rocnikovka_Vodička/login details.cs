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


        public List<string> DateCalendar2016 = new List<string> { "31", "5", "29", "1", "31", "2", "30", "5", "31", "7", "30", "3", "31", "5", "31", "1", "30", "4", "31", "6", "30", "2", "31", "4" };
        public List<string> DateCalendar2017 = new List<string> { "31", "7", "28", "3", "31", "3", "30", "6", "31", "1", "30", "4", "31", "6", "31", "2", "30", "5", "31", "7", "30", "3", "31", "5" };

        public List<string> DateCalendar2018 = new List<string> { "31", "1", "28", "4", "31", "4", "30", "7", "31", "2", "30", "5", "31", "7", "31", "3", "30", "6", "31", "1", "30", "4", "31", "6" };
        public List<string> DateCalendar2019 = new List<string> { "31", "2", "28", "5", "31", "5", "30", "1", "31", "3", "30", "6", "31", "1", "31", "4", "30", "7", "31", "2", "30", "5", "31", "7" };

        public List<string> DateCalendar2020 = new List<string> { "31", "3", "29", "6", "31", "7", "30", "3", "31", "5", "30", "1", "31", "3", "31", "6", "30", "2", "31", "4", "30", "7", "31", "2" };
        public List<string> DateCalendar2021 = new List<string> { "31", "5", "28", "1", "31", "1", "30", "4", "31", "6", "30", "2", "31", "4", "31", "7", "30", "3", "31", "5", "30", "1", "31", "3" };

        public List<string> DateCalendar2022 = new List<string> { "31", "6", "28", "2", "31", "2", "30", "5", "31", "7", "30", "3", "31", "5", "31", "1", "30", "4", "31", "6", "30", "2", "31", "4" };
        public List<string> DateCalendar2023 = new List<string> { "31", "7", "28", "3", "31", "3", "30", "6", "31", "1", "30", "4", "31", "6", "31", "2", "30", "5", "31", "7", "30", "3", "31", "5" };

        public List<string> DateCalendar2024 = new List<string> { "31", "1", "29", "4", "31", "5", "30", "1", "31", "3", "30", "6", "31", "1", "31", "4", "30", "7", "31", "2", "30", "5", "31", "7" };
        public List<string> DateCalendar2025 = new List<string> { "31", "3", "28", "6", "31", "6", "30", "2", "31", "4", "30", "7", "31", "2", "31", "5", "30", "1", "31", "3", "30", "6", "31", "1" };
        public List<string> DateCalendar2026 = new List<string> { "31", "4", "28", "7", "31", "7", "30", "3", "31", "5", "30", "1", "31", "3", "31", "6", "30", "2", "31", "4", "30", "7", "31", "2" };
        
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
                Zmena("Help");
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
