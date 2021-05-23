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
    /// Interakční logika pro pripominky.xaml
    /// </summary>
    public partial class pripominky : Window
    {
        public pripominky()
        {
            InitializeComponent();
        }
        private void ButtonOdstraneni(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;  
            string nazev = clickedButton.Name;
            String posledni_slova = nazev.Substring(nazev.Length - 2);
            string textnazev= "text"+posledni_nazev;
            Textbox ty =(Textbox)textnazev;
            ty.Text ="";
            clickedButton.Visibility = Visibility.Hidden;

        }
    }

}
