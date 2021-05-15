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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rocnikovka_Vodička
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        login_details log = new login_details();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (easy.IsChecked == true )
            {
                log.AddingRemark(upominka.Text, podrobnosti.Text, dateInput.SelectedDate, "easy");
            }
            if (medium.IsChecked == true)
            {
                log.AddingRemark(upominka.Text, podrobnosti.Text, dateInput.SelectedDate, "medium");
            }
            if (hard.IsChecked == true)
            {
                log.AddingRemark(upominka.Text, podrobnosti.Text, dateInput.SelectedDate, "hard");
            }
            this.Close();//po přidání upomínky, zavře se okno
        }
    }
}
