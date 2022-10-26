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

namespace Prov_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int slumptal; 
        static Random generator = new Random();
        static int antalFörsök;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Anropas när man klickar på knappen Starta
        // Slumpa fram ett tal
        private void KlickStart(object sender, RoutedEventArgs e)
        {
            slumptal = generator.Next(1, 101);
            antalFörsök = 0;
        }

        // Anropas när man klickar på knappen Gissa
        // Kolla om användaren gissar rätt
        private void KlickGissa(object sender, RoutedEventArgs e)
        {
            // Läsa av gissningen
            int gissning = int.Parse(rutaGissning.Text);

            // Räkna upp antalet gånger man gissat
            antalFörsök++;

            // Är gissning rätt?
            if (gissning == slumptal)
            {
                rutaSvar.Text += "Rätt gissat!\n";
            }
            else if (gissning < slumptal)
            {
                rutaSvar.Text += "För lågt!\n";
            }
            else
            {
                rutaSvar.Text += "För högt!\n";
            }
        }
    }
}
