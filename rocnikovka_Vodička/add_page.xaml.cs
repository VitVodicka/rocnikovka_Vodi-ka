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
    /// Interakční logika pro add_page.xaml
    /// </summary>
    public partial class add_page : Window
    {
        login_details log;//vytvoření třídy login_details v add_page
        public add_page(login_details _log)
        {
            log = _log;
            InitializeComponent();
        }

        private void pridani_tlacitko(object sender, RoutedEventArgs e)
        {
            log.addingToList(prezdivka.Text, mail.Text, heslo.Text);//po stiknutí tlačítka přidat se přidají pomocí funkce addingToList do databáze přezdívka, mail a heslo. Po přidání dat do databáze se zavře okno.
            this.Close();
        }
    }
}
