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
using System.IO;
using System.Timers;

namespace Brannboll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int innePoäng = 0;
        static int utePoäng = 0;

        public MainWindow()
        {
            InitializeComponent();

            Timer timer = new Timer(1000);
            timer.Elapsed += OnTimerEvent;
            timer.Start();
        }

        private void OnTimerEvent(object source, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(UpdateraKlockan);
        }

        private void UpdateraKlockan()
        {
            DateTime tid = DateTime.Now;
            rutaKlocka.Text = tid.ToString("HH:mm:ss");
        }

        private void KlickFrivarv(object sender, RoutedEventArgs e)
        {
            innePoäng += 5;
            rutaInne.Text = innePoäng.ToString();

            // Skriv ut händelsen i historiken
            DateTime tid = DateTime.Now;
            rutaHistorik.Text += tid.ToString("HH:mm:ss") + " Frivarv +5 poäng\n";

            // Spara ned i textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }
        private void KlickBränning(object sender, RoutedEventArgs e)
        {
            utePoäng += 2;
            rutaUte.Text = utePoäng.ToString();

            // Skriv ut händelsen i historiken
            DateTime tid = DateTime.Now;
            rutaHistorik.Text += tid.ToString("HH:mm:ss") + " Bränning +2 poäng\n";
            
            // Spara ned i textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }
        private void KlickLyra(object sender, RoutedEventArgs e)
        {
            utePoäng += 3;
            rutaUte.Text = utePoäng.ToString();

            // Skriv ut händelsen i historiken
            DateTime tid = DateTime.Now;
            rutaHistorik.Text += tid.ToString("HH:mm:ss") + " Lyra +3 poäng\n";

            // Spara ned i textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }
        private void KlickVarv(object sender, RoutedEventArgs e)
        {
            innePoäng += 1;
            rutaInne.Text = innePoäng.ToString();

            // Skriv ut händelsen i historiken
            DateTime tid = DateTime.Now;
            rutaHistorik.Text += tid.ToString("HH:mm:ss") + " Varv +1 poäng\n";

            // Spara ned i textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }
    }
}
