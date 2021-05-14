﻿using System;
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
        login_details log = new login_details();//vytvoření třídy login_details v třídě uctik
        public uctik2()
        {
            InitializeComponent();
            DataContext = log;//propojení třídy účtík s třídou login_details
        }

        private void ucet_pridani(object sender, RoutedEventArgs e)//otevře okno s registrací uživatele po zmáčknutí tlačítka přidat
        {
            add_page add = new add_page();
            add.Show();
        }

        private void ucet_odebrani(object sender, RoutedEventArgs e)//odebere označenou položku z seznamu
        {
            log.Delete((login)users.SelectedItem);
        }

        private void users_MouseDoubleClick(object sender, MouseButtonEventArgs e)// po dvojtém zmáčknutí na položku účtu, přes který se chceme připojit
        {// ukázání hesla menu
         //DODĚLAT viz. github
            log.Comparing((login)users.SelectedItem);//načte označenou položku
            password2 pas = new password2();//vytvoří třídu okna password
            pas.Show();//otevře okno pro zadání hesla
        }
    }
}
