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
        private Navigateur navigation = new Navigateur();

        string rss = "https://www.reddit.com/r/memes.rss";
        private List<Meme> listeMeme;
        MemeDAO memeDao = new MemeDAO();
        private Meme DernierMeme;

        public int IdAcceuil = 0;
        public int IdMemes = 1;
        public int IdMessages = 2;
        public int IdCrypto = 3;
        public int IdMeteo = 4;
        public int IdPoke = 5;

        public Acceuil()
        {
            InitializeComponent();
            afficherAcceuil();
            navigation.initialiserFenetres(this);
            listeMeme = memeDao.listerMemes(rss);
            
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
            navigation.changerFenetre(IdAcceuil,IdMemes);
            this.Close();
        }
        public void ChangerVersCrypto()
        {
            navigation.changerFenetre(IdAcceuil, IdCrypto);
            this.Close();
        }
        public void ChangerVersMessages()
        {
            navigation.changerFenetre(IdAcceuil, IdMessages);
            this.Close();
        }
        public void ChangerVersMeteo()
        {
            navigation.changerFenetre(IdAcceuil, IdMeteo);
            this.Close();
        }
        public void ChangerVersPokemon()
        {
            navigation.changerFenetre(IdAcceuil, IdPoke);
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