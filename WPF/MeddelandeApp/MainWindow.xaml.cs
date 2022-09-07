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

namespace MeddelandeApp
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

        // Hantera klick på knappen
        private void KlickSkicka(object sender, RoutedEventArgs e)
        {
            // Kontrollera att inte epost eller text är tomt
            if (rutaEpost.Text == "" || rutaText.Text == "")
            {
                rutaStatus.Text = "Vg ange epost och meddelande";
            }
            else
            {
                rutaStatus.Text = "Meddelandet skickat...";
            }
        }
    }
}
