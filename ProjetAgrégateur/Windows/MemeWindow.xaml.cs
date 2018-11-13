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
using ProjetAgrégateur.Scripts;

namespace ProjetAgrégateur
{
    /// <summary>
    /// Logique d'interaction pour News.xaml
    /// </summary>
    public partial class MemeWindow : Window
    {
        string rss = "https://www.reddit.com/r/memes.rss";
        public MemeWindow()
        {
            InitializeComponent();
            afficherMemes();
        }

        private void afficherMemes()
        {
            MemeDAO test = new MemeDAO();
            List<Meme> listeMeme = test.listerMemes(rss);
            foreach (Meme meme in listeMeme)
            {
                Console.WriteLine(meme.titre + "\n");
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {    
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
        }
    }
}
