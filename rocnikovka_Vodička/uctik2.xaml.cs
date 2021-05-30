using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

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
            add_page add = new add_page(log);
            add.ShowDialog();
        }

        private void ucet_odebrani(object sender, RoutedEventArgs e)//odebere označenou položku z seznamu
        {
            log.Delete((login)users.SelectedItem);
        }

        private void users_MouseDoubleClick(object sender, MouseButtonEventArgs e)// po dvojtém zmáčknutí na položku účtu, přes který se chceme připojit
        {// ukázání hesla menu
         //DODĚLAT viz. github
            if (users.SelectedItem != null) {
                password2 pas = new password2(log, users.SelectedIndex);//vytvoří třídu okna password
                pas.Show();//otevře okno pro zadání hesla
            }
        }

        #region ukladani a otevirani
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(log.GetType());
            using (StreamWriter sw = new StreamWriter("users.xml"))
            {
                serializer.Serialize(sw, log);
            }
        }

        #endregion ukladani a otevirani
    }
}
