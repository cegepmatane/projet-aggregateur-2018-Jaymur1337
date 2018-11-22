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
        Navigateur nav;
        string rss = "https://www.reddit.com/r/memes.rss";

        public int IdAcceuil = 0;
        public int IdMemes = 1;
        public int IdMessages = 2;
        public int IdCrypto = 3;
        public int IdMeteo = 4;
        public int IdPoke = 5;

        public int conteurMeme = 0;

        public MemeWindow()
        {
            InitializeComponent();
            afficherMemes();

        }

        private void afficherMemes()
        {
            MemeDAO Memes = new MemeDAO();
            List<Meme> listeMeme = Memes.listerMemes(rss);
            foreach (Meme meme in listeMeme)
            

                switch (conteurMeme)
                {
                    case 0:
                        Console.WriteLine(meme.titre);
                        Meme1.Text = "Meme 1 :" + meme.titre;
                        conteurMeme++;
                        break;
                    case 1:
                        Console.WriteLine(meme.titre);
                        Meme2.Text = "Meme 2 :" + meme.titre;
                        conteurMeme++;
                        break;
                    case 2:
                        Console.WriteLine(meme.titre);
                        Meme3.Text = "Meme 3 :" + meme.titre;
                        conteurMeme++;
                        break;
                    case 3:
                        Console.WriteLine(meme.titre);
                        Meme4.Text = "Meme 4 :" + meme.titre;
                        conteurMeme++;
                        break;
                    case 4:
                        Console.WriteLine(meme.titre);
                        Meme5.Text = "Meme 5 :" + meme.titre;
                        conteurMeme++;
                        break;
                    case 5:
                        Console.WriteLine(meme.titre);
                        Meme6.Text = "Meme 6 :" + meme.titre;
                        conteurMeme++;
                        break;
                    default:
                        break;
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
