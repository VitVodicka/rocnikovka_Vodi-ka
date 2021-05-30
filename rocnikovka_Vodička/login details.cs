using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace rocnikovka_Vodička
{
    public class login_details : INotifyPropertyChanged// zde je implementováno rozhraní pro aktualizaci prvků
    {
        public ObservableCollection<login> listPrihlasovani { get; set; }//list, do kterého se přidávají uživatelské údaje(email, heslo, přezdívka)
        public List<events> listEvents { get; set; }//list poznámek před rostřízením
        public List<events> listEasy { get; set; }//list easy poznámek
        public List<events> listMedium { get; set; }//list medium poznámek
        public List<events> listHard { get; set; }//list hard poznámek
        public int Index { get; set; }//meziproměnná s názvem index
        public string Help { get; set; }//proměnná, když nastane nějaký error
        public string Helpik { get; set; }//proměnná, když nastane nějaký error
        public DateTime TodayNowDate { get; set; }//pomocná proměnná
        public int Easycounter { get; set; }//proměnná, které počítá počet easy poznámek 
        public int Mediumcounter { get; set; }//proměnná, které počítá počet medium poznámek 
        public int Hardcounter { get; set; }//proměnná, které počítá počet hard poznámek 

        public DateTime aktualniDatum { get; set; }//aktuální datum
        public int datumRok { get; set; }//pomocná proměnná
        public int datumMesic { get; set; }//pomocná proměnná
        public int datumDen { get; set; }//pomocná proměnná

        //proměnná s aktuálním datumem, která má ze začátku aktuální datum, ale pomocí tlačítek plus a mínus mění měsíce

        //listy roků, které obsahují počet dní a od jakého dne začínají
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
        
        public void calenderSetting(DateTime datum)//nastaví do proměnné TodaynowDate aktuální datum
        {
            TodayNowDate = datum;


        }
        public void ListImportance()//roztřídí poznámky na základě své důležitosti do různých tříd
        {
            listEasy.Clear();
            listMedium.Clear();
            listHard.Clear();

            for(int i = 0; i < listEvents.Count; i++)
            {
                if (listEvents[i].Importance == "easy")
                {
                    listEasy.Add(listEvents[i]);
                    Easycounter += 1;
                }
                if (listEvents[i].Importance == "medium")
                {
                    listMedium.Add(listEvents[i]);
                    Mediumcounter += 1;
                }
                if (listEvents[i].Importance == "hard")
                {
                    listHard.Add(listEvents[i]);
                    Hardcounter += 1;
                    
                }
            }
            
        }
        //64
        //kouknout se na počet, odstranit přebytečný počet
        public void AddingRemark(string remark, DateTime? date, string importance)
        {
            events eventik = new events(remark, date, importance);
            listEvents.Add(eventik);
        }

        public login_details()//v konstruktoru vytvoření listu na přihlašování
        {
            listPrihlasovani = new ObservableCollection<login>();
            listEvents = new List<events>();
            listEasy = new List<events>();
            listMedium = new List<events>();
            listHard = new List<events>();
            aktualniDatum = DateTime.Today;
        }
        public login_details(DateTime datumik)
        {
            TodayNowDate = datumik;
        }
        public void DatumPridani()
        {
            aktualniDatum = aktualniDatum.AddMonths(1);//přidání 1 měsíce k datumu
            Zmena("aktualniDatum");//aktualizace proměnné aktuálníDatum
        }
        public void DatumOdebrani()
        {
            if (aktualniDatum != null)
            {
                aktualniDatum = aktualniDatum.AddMonths(-1);//odebrání 1 měsíce od datumu
                Zmena("aktualniDatum"); ;//aktualizace proměnné aktuálníDatum
            }
        }

        public void addingToList(string prezdivkaInput, string mailInput, string hesloInput)//přidávání přihlašovacích údajů do listu a aktualizace listu
        {
            login prihlaseni = new login(prezdivkaInput, mailInput, hesloInput);
            listPrihlasovani.Add(prihlaseni);

            Zmena("listPrihlasovani");
            Zmena(prezdivkaInput);
            Zmena(mailInput);
            Zmena(hesloInput);
        }
        public void Delete(login log)//odstranění položky z listu pro přihlašování
        {
            if (listPrihlasovani != null)
            {
                listPrihlasovani.Remove(log);
                Zmena("listPrihlasovani");
            }
        }

        //kontrluje, zda se heslo zadané v popupu rovná s heslem v databázi
        //pokud se heslo z popupu bude shodovat s heslem z databáze, otevře se hlavní kalendář
        //pokud se heslo z popupu nebude shodovat s heslem z databáze, zobrazí se v popupu text špatné heslo, které po 10 sekundách zmizí


        public void Passcheck(int indexik, string passInput)
        {
            if ((passInput == null) || (listPrihlasovani[indexik] != null))
            {
                if (passInput == listPrihlasovani[indexik].Heslo)
                {
                    hlavni_kalendar hlavni = new hlavni_kalendar();
                    hlavni.Show();//otevrení kalendáře


                }
                else
                {
                    Help = "Špatné Heslo";
                    Thread.Sleep(TimeSpan.FromSeconds(10));//nechá uspat celkový proces do té doby než se napočítá počet sekund a pak proces jede dál
                    Help = "";
                    Zmena("Help");
                    //try a catch
                }
            }
            //ted jen dodělat checkování popup hesla s list heslem a odbugování pomocí try
        }

        public event PropertyChangedEventHandler PropertyChanged;//zde se implementuje rozhraní do třídy

        private void Zmena(string vlastnost)//funkce, která obnovuje proměnnou
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(vlastnost));
            }
        }

        public int ZacatekMesice()//projde list a pokud  je prvek lichý, tak od toho čísla bude začínat kalendářní měsíc
        {
            List<string> rok = DateCalendar2021;
            if (aktualniDatum.Year == 2021)
            {
                rok = DateCalendar2021;
            }
            if (aktualniDatum.Year == 2020)
            {
                rok = DateCalendar2020;
            }
            if (aktualniDatum.Year == 2019)
            {
                rok = DateCalendar2019;
            }

            int mesicCislo = aktualniDatum.Month - 1;
            string pocatecniDen = rok[(mesicCislo * 2) + 1];
            return int.Parse(pocatecniDen);//odečte se a přičte se 1, kvůli rozdílu v datumu a listu
        }

        public int PocetDni()//projde list a pokud  je prvek lichý, tak od toho čísla bude začínat kalendářní měsíc
        {
            List<string> rok = DateCalendar2021;
            if (aktualniDatum.Year == 2021)
            {
                rok = DateCalendar2021;
            }
            if (aktualniDatum.Year == 2020)
            {
                rok = DateCalendar2020;
            }
            if (aktualniDatum.Year == 2019)
            {
                rok = DateCalendar2019;
            }

            int mesicCislo = aktualniDatum.Month - 1;
            string pocetDni = rok[mesicCislo * 2];
            return int.Parse(pocetDni);// odečte se a přičte se 1, kvůli rozdílu v datumu a listu
        }
    }
}

