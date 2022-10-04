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

namespace Luffarschack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Hålla koll vems tur det är
        static bool spelare1Tur = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Hantera klick på någon knapp
        private void KlickKnapp(object sender, RoutedEventArgs e)
        {
            // Fånga in knappen
            Button knapp = (Button)sender;

            // Kan vi se vilken knapp som trycktes
            //MessageBox.Show(knapp.Name);

            // Skriva ett kryss eller en ring
            knapp.FontSize = 90;
            knapp.IsEnabled = false;

            // Vems tu det är
            if (spelare1Tur)
            {
                // Spelare 1 = X
                knapp.Content = "X";
                spelare1Tur = false;
            }
            else
            {
                // Spelare 2 = O
                knapp.Content = "O";
                spelare1Tur = true;
            }

            // Kolla om en rad är full för spelare 1
            if (knapp1.Content == "X" && knapp2.Content == "X" && knapp3.Content == "X" ||
                knapp4.Content == "X" && knapp5.Content == "X" && knapp6.Content == "X" ||
                knapp7.Content == "X" && knapp8.Content == "X" && knapp9.Content == "X")
            {
                MessageBox.Show("Spelare 1 vann!");
                Omstart();
            }

            // Kolla om en rad är full för spelare 2
            if (knapp1.Content == "O" && knapp2.Content == "O" && knapp3.Content == "O" ||
                knapp4.Content == "O" && knapp5.Content == "O" && knapp6.Content == "O" ||
                knapp7.Content == "O" && knapp8.Content == "O" && knapp9.Content == "O")
            {
                MessageBox.Show("Spelare 2 vann!");
                Omstart();
            }

            // Kolla om en kolumn är full för spelare 1
            if (knapp1.Content == "X" && knapp4.Content == "X" && knapp7.Content == "X" ||
                knapp2.Content == "X" && knapp5.Content == "X" && knapp8.Content == "X" ||
                knapp3.Content == "X" && knapp6.Content == "X" && knapp9.Content == "X")
            {
                MessageBox.Show("Spelare 1 vann!");
                Omstart();
            }

            // Kolla om en kolumn är full för spelare 2
            if (knapp1.Content == "O" && knapp4.Content == "O" && knapp7.Content == "O" ||
                knapp2.Content == "O" && knapp5.Content == "O" && knapp8.Content == "O" ||
                knapp3.Content == "O" && knapp6.Content == "O" && knapp9.Content == "O")
            {
                MessageBox.Show("Spelare 2 vann!");
                Omstart();
            }

            // Kolla om en diagonal är full för spelare 1
            if (knapp1.Content == "X" && knapp5.Content == "X" && knapp9.Content == "X" ||
                knapp3.Content == "X" && knapp5.Content == "X" && knapp7.Content == "X")
            {
                MessageBox.Show("Spelare 1 vann!");
                Omstart();
            }
            
            // Kolla om en diagonal är full för spelare 
            if (knapp1.Content == "O" && knapp5.Content == "O" && knapp9.Content == "O" ||
                knapp3.Content == "O" && knapp5.Content == "O" && knapp7.Content == "O")
            {
                MessageBox.Show("Spelare 2 vann!");
                Omstart();
            }
        }

        // Återställer spelplanen för nytt spel
        private void Omstart()
        {
            // Återställ alla knappar, dvs
            // Ta bort X/O och "enabla" knapparna
            knapp1.Content = null;
            knapp1.IsEnabled = true;
            knapp2.Content = null;
            knapp2.IsEnabled = true;
            knapp3.Content = null;
            knapp3.IsEnabled = true;
            knapp4.Content = null;
            knapp4.IsEnabled = true;
            knapp5.Content = null;
            knapp5.IsEnabled = true;
            knapp6.Content = null;
            knapp6.IsEnabled = true;
            knapp7.Content = null;
            knapp7.IsEnabled = true;
            knapp8.Content = null;
            knapp8.IsEnabled = true;
            knapp9.Content = null;
            knapp9.IsEnabled = true;
        }
    }
}
