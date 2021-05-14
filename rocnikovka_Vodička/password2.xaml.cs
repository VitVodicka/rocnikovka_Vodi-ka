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
    /// Interakční logika pro password2.xaml
    /// </summary>
    public partial class password2 : Window
    {
        login_details log = new login_details();//vytváření třídy login_details v password okně
        public password2()
        {
            InitializeComponent();
            DataContext = log;
        }

        private void okButton(object sender, RoutedEventArgs e)
        {//zjištuje, pomocí funkce passcheck, zda se shodují hesla z popupu a databáze
            log.Passcheck(passwordInput.Text);
            this.Close();
        }
    }
}
