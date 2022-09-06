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

namespace Labb1
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

        // Fånga upp klick på knappen
        private void KlickRäknaUt(object sender, RoutedEventArgs e)
        {
            // Läsa av höjden
            int höjd = int.Parse(rutaHöjd.Text);

            // Läsa bredden
            int bredd = int.Parse(rutaBredd.Text);

            // Räkna ut arean
            int area = bredd * höjd;

            // Skriv ut i rutan resultat (TextBox)
            //rutaResultat.Text = area.ToString();
            rutaResultat.Text = $"{höjd} * {bredd} = {area}";
        }
    }
}
