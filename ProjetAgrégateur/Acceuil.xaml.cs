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
using ProjetAgrégateur.Scripts;
using System.IO;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace ProjetAgrégateur
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Acceuil : Window
    {
        private Controlleur controlleur = new Controlleur();
        
        public Acceuil()
        {
            InitializeComponent();
            afficherAcceuil();
        }

        public void afficherAcceuil()
        {

        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            controlleur.NotifierChangerVersNews(this);
        }

        public void ChangerVersMemes()
        {
            MemeWindow memes = new MemeWindow();
            memes.Show();
            this.Close();
        }
        public void ChangerVersCrypto()
        {
            CryptoWindow crypto = new CryptoWindow();
            crypto.Show();
            this.Close();
        }
        public void ChangerVersMessages()
        {
            MessagesWindow messages = new MessagesWindow();
            messages.Show();
            this.Close();
        }
        public void ChangerVersMeteo()
        {
            MeteoWindow meteo = new MeteoWindow();
            meteo.Show();
            this.Close();
        }
        public void ChangerVersPokemon()
        {
            PokeWindow poke = new PokeWindow();
            poke.Show();
            this.Close();
        }
        
        private void Mess_Click(object sender, RoutedEventArgs e)
        {
            controlleur.NotifierChangerVersMessages(this);
        }
        private void Crypto_Click(object sender, RoutedEventArgs e)
        {
            controlleur.NotifierChangerVersCrypto(this);
        }
        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            controlleur.NotifierChangerVersPoke(this);
        }
        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            controlleur.NotifierChangerVersMeteo(this);
        }

    }
}
