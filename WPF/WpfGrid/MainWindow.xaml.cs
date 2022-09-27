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
using System.Text.RegularExpressions;

namespace WpfGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Agera på klick
        private void KlickSkicka(object sender, RoutedEventArgs e)
        {
            // Läs av epost och texten
            string epost = rutaEpost.Text;
            string texten = rutaTexten.Text;

            // Kolla om tomt
            if (epost == "" || texten == "")
            {
                rutaStatus.Text = "Fel! Epost eller text får inte vara tomma";
            }
            else
            {
                // Regex för epostformat
                Regex epostRegex = new Regex("^\\S+@\\S+.\\S+$");

                // Kolla att epost är i rätt format
                if (!epostRegex.IsMatch(epost))
                {
                    rutaStatus.Text = "Fel! Epost inte giltigt format.";
                }
            }
        }
    }
}
