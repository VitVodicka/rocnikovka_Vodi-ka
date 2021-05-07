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
    /// Interakční logika pro uctik2.xaml
    /// </summary>
    public partial class uctik2 : Window
    {
        login_details log = new login_details();
        public uctik2()
        {
            InitializeComponent();
            DataContext = log;
        }

        private void ucet_pridani(object sender, RoutedEventArgs e)
        {
            add_page add = new add_page();
            add.Show();
        }

        private void ucet_odebrani(object sender, RoutedEventArgs e)
        {
            log.Delete((login)users.SelectedItem);
        }
    }
}
