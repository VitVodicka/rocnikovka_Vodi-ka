using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace rocnikovka_Vodička
{
    /// <summary>
    /// Interakční logika pro hlavni_kalendar.xaml
    /// </summary>
    
    public partial class hlavni_kalendar : Window
    {
        login_details log = new login_details();//vytvoření třídy login_details v hlavnim kalendáři
        public hlavni_kalendar()
        {
            InitializeComponent();
            DataContext = log;
            log.SettingDays(mesicnidatum.Text);
            ZviditelnujTlacitka();
        }


        private void KalendarMinus(object sender, RoutedEventArgs e)
        {
            log.DatumOdebrani();//po zmáčknutí tlačítka plus se spustí funkce DatumOdebrani, která odečte z celkového datumu 1 měsíc
            hint.Text = mesicnidatum.Text;
            ZviditelnujTlacitka();
        }

        private void KalendarPlus(object sender, RoutedEventArgs e)
        {
            log.DatumPridani();//po zmáčknutí tlačítka mínus se spustí funkce DatumPridani, která přičte k celkového datumu 1 měsíc
            ZviditelnujTlacitka();
        }
        public void ZviditelnujTlacitka()
        {
            // zviditelní či vypne talčítka, podle počtu dní a kdy bude začínat
            List<Button> tlacitka = new List<Button> { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20, Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34, Button35, Button36, Button37, Button38, Button39, Button40, Button41, Button42 };

            int pocitadlo = 1;
            for (int i = 0; i < tlacitka.Count; i++)
            {
                if (i >= log.ZacatekMesice() - 1 && pocitadlo <= log.PocetDni())//pokud je měsíc lichý, tak zviditelní 
                {
                    tlacitka[i].Visibility = Visibility.Visible;
                    tlacitka[i].Content = pocitadlo;
                    pocitadlo = pocitadlo + 1;
                }
                else
                {
                    tlacitka[i].Visibility = Visibility.Hidden;
                }
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int datumDen = int.Parse(((Button)sender).Content.ToString());
            //int datumDen = int.Parse(((Button)sender).Content.ToString());
            //int datumMesic = int.Parse(log.aktualniDatum.Month.ToString());
            //int datumRok = int.Parse(log.aktualniDatum.Year.ToString());
            log.datumDen = 5;
            log.datumMesic = 5;
            log.datumRok = 2020;
            //DateTime datum = new DateTime(datumDen, datumMesic, datumRok);
            //log.calenderSetting(datumDen, datumMesic, datumRok);



            MainWindow ma = new MainWindow();
            ma.Show();
        }
        
        /*private void Button_Click(object sender, RoutedEventArgs e)
		{
			string contentik = ((Button)sender).Content.ToString(); 
		}*/
        private void Button_Click3(object sender, RoutedEventArgs e)
		{
			pripominky pr = new pripominky();
			pr.Show();
		}
	}
}
