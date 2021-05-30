using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rocnikovka_Vodička
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        login_details log;
        public MainWindow(login_details log2)//nate třídu login_details a odkáže se na ní a propojí se s ní
        {
            InitializeComponent();
            log = log2;
            DataContext = log;
        }

        private void Button_Click(object sender, RoutedEventArgs e)//pokud není text pro upomínku delší než 30 znaků a není počet jakékoliv kategorie poznámky větší než 27 přidá poznámku do Listu a zároven se roztřídí do listů, podle kategorií. Pokud ne, tak napíše se, že je moc přidaných poznámek
        {


            if (easy.IsChecked == true)
            {
                log.AddingRemark(upominka.Text, dateInput.SelectedDate, "easy");
            }
            if (medium.IsChecked == true)
            {
                log.AddingRemark(upominka.Text, dateInput.SelectedDate, "medium");
            }
           
            if (hard.IsChecked == true)
            {
                log.AddingRemark(upominka.Text, dateInput.SelectedDate, "hard");
            }
            
        

        log.ListImportance();
        this.Close();//po přidání upomínky, zavře se okno
        //podrobnosti.Text = log.TodayNowDate.ToString(); nevím, k čemu to bylo
         
        }
    }
}
