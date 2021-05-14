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
    /// Interakční logika pro zkouska.xaml
    /// </summary>
    
    public partial class zkouska : UserControl
    {
        login_details l = new login_details();
        public zkouska()
        {
            InitializeComponent();
        }
    }
}
