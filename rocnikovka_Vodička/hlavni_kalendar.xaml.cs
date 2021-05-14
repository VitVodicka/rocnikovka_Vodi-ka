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
        }


        private void KalendarMinus(object sender, RoutedEventArgs e)
        {
            log.DatumOdebrani();//po zmáčknutí tlačítka plus se spustí funkce DatumOdebrani, která odečte z celkového datumu 1 měsíc
        }

        private void KalendarPlus(object sender, RoutedEventArgs e)
        {
            log.DatumPridani();//po zmáčknutí tlačítka mínus se spustí funkce DatumPridani, která přičte k celkového datumu 1 měsíc
        }
    }
}
