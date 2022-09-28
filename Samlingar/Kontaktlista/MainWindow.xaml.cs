using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
using System.IO;

namespace Kontaktlista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Intern lagring
        //static string[] lista = new string[100];
        static List<string> lista = new List<string>();

        // Körs vi start
        public MainWindow()
        {
            InitializeComponent();

            // Kolla att textfilen finns
            if (File.Exists("kontaktlista.txt"))
            {
                // Läsa in kontaktlistan
                lista = File.ReadAllLines("kontaktlista.txt").ToList();

                // Skriv ut alla kontakter
                foreach (string kontakt in lista)
                {
                    rutaLista.Text += kontakt + "\n";
                }

                rutaStatus.Text = lista.Count + " kontakter";
            }
            else
            {
                rutaStatus.Text = "0 kontakter";
            }
        }

        // Hantera klick på knappen
        private void KlickLäggTill(object sender, RoutedEventArgs e)
        {
            // Läs av namn & mobil
            string namn = rutaNamn.Text;
            string mobil = rutaMobil.Text;

            // Kolla att inte tomma
            if (namn == "" || mobil == "")
            {
                rutaStatus.Text = "Namn eller mobil saknas, vg försök igen!";
            }
            else
            {
                // Kolla mobilen följer rätt format (07XXXXXXXX)
                Regex regexMobil = new Regex("07[0-9]{8}");
                if (!regexMobil.IsMatch(mobil))
                {
                    rutaStatus.Text = "Mobil är fel format, vg försök igen!";
                }
                else
                {
                    rutaLista.Text += namn + "\t" + mobil + "\n";

                    // Spara i lista i minnet
                    lista.Add(namn + "\t" + mobil);

                    // Spara ned listan i en textfil
                    File.WriteAllLines("kontaktlista.txt", lista);

                    rutaStatus.Text = lista.Count + " kontakter";
                }
            }
        }
    }
}
