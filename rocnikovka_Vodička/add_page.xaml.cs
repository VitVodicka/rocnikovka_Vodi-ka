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
        login_details log = new login_details();
        public add_page()
        {
            

            InitializeComponent();
        }

        private void pridani_tlacitko(object sender, RoutedEventArgs e)
        {
            log.addingToList(prezdivka.Text, mail.Text, heslo.Text);
            this.Close();
        }
    }
}
