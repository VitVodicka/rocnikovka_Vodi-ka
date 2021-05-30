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
        login_details log;

        List<TextBlock> textyEasy;
        List<TextBlock> textyMedium;
        List<TextBlock> textyHard;

        List<Button> buttonyEasy;
        List<Button> buttonyMedium;
        List<Button> buttonyHard;
        
        public pripominky(login_details log2)
        {
            InitializeComponent();

            // vytvoří seznamy textboxů a buttonů pro každou důležitost
            textyEasy = new List<TextBlock> { text01, text02, text03, text04, text05, text06, text07, text08, text09, text10, text11, text12,text13,text14,text15,text16,text17,text18,text19,text20,text21, text22,text23,text24,text25,text26,text27,text28 };
            buttonyEasy = new List<Button> { Button01, Button02, Button03, Button04, Button05, Button06, Button07, Button08, Button09, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20, Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28 };

            textyMedium = new List<TextBlock> { text29, text30, text31, text32, text33, text34, text35, text36, text37, text38, text39, text40, text41, text42, text43, text44, text45, text46, text47, text48, text49, text50, text51, text52, text53, text54, text55, text56 };
            buttonyMedium = new List<Button> { Button29, Button30, Button31, Button32, Button33, Button34, Button35, Button36, Button37, Button38, Button39, Button40, Button41, Button42, Button43, Button44, Button45, Button46, Button47, Button48, Button49, Button50, Button51, Button52, Button53, Button54, Button55, Button56};
            textyHard = new List<TextBlock> { text57, text58, text59, text60, text61, text62, text63, text64, text65, text66, text67, text68, text69, text70, text71, text72, text73, text74, text75, text76, text77, text78, text79, text80, text81, text82, text83,text84};
            buttonyHard = new List<Button> { Button57, Button58, Button59, Button60, Button61, Button62, Button63, Button64, Button65, Button66, Button67, Button68, Button69, Button70, Button71, Button72, Button73, Button74, Button75, Button76, Button77, Button78, Button79, Button80, Button81, Button82, Button83,Button84};
            //57-84


            // načte seznam eventů a seřadí je
            log = log2;
            log.ListImportance();

            // vloží hodnoty do formuláře
            NactiEasy();
            NactiMedium();
            NactiHard();
        }

        private void NactiEasy()//přidá text a zviditelní buttony podle počtu easy upomínek 
        {
            int i = 0;
            foreach(TextBlock txtbl in textyEasy)
            {
                if (log.listEasy.Count > i)
                {
                    txtbl.Text = log.listEasy[i].ImportanceToText;
                    buttonyEasy[i].Visibility = Visibility.Visible;
                } else
                {
                    txtbl.Text = "";
                    buttonyEasy[i].Visibility = Visibility.Hidden;
                }

                i += 1;
            }
        }

        private void NactiMedium()//přidá text a zviditelní buttony podle počtu medium upomínek 
        {
            int i = 0;
            foreach (TextBlock txtbl in textyMedium)
            {
                if (log.listMedium.Count > i)
                {
                    txtbl.Text = log.listMedium[i].ImportanceToText;
                    buttonyMedium[i].Visibility = Visibility.Visible;
                }
                else
                {
                    txtbl.Text = "";
                    buttonyMedium[i].Visibility = Visibility.Hidden;
                }

                i += 1;
            }
        }

       private void NactiHard()//přidá text a zviditelní buttony podle počtu hard upomínek 
        {
            int j = 0;
            foreach (TextBlock txtbl in textyHard)
            {
                if (log.listHard.Count > j)
                {
                    txtbl.Text = log.listHard[j].ImportanceToText;
                    buttonyHard[j].Visibility = Visibility.Visible;
                }
                else
                {
                    txtbl.Text = "";
                    buttonyHard[j].Visibility = Visibility.Hidden;
                }

                j += 1;
            }
        }
        private void ButtonOdstraneni(object sender, RoutedEventArgs e)//odstraní upomínky
        {
            Button clickedButton = (Button)sender;
            string nazev = clickedButton.Name;
            String posledni_slova = nazev.Substring(nazev.Length - 2);
            string textnazev = "text" + posledni_slova;
            Object tex = new Object();
            tex = (Object)textnazev;
            TextBox ty = tex as TextBox;
            ty.Text = "";
            clickedButton.Visibility = Visibility.Hidden;

        }

    }
}
