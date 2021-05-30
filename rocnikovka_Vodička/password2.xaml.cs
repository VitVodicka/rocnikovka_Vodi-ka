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
        login_details log;//vytváření třídy login_details v password okně
        private int indexUzivatele = 0;
        public password2(login_details log2, int indexUzivatele2)
        {
            InitializeComponent();
            indexUzivatele = indexUzivatele2;
            log = log2;
            DataContext = log;
        }

        private void okButton(object sender, RoutedEventArgs e)
        {//zjištuje, pomocí funkce passcheck, zda se shodují hesla z popupu a databáze
            log.Passcheck(indexUzivatele, passwordInput.Text);
            this.Close();
        }
    }
}
