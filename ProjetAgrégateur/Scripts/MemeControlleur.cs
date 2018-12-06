using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur.Scripts
{ 
    class MemeControlleur
    {
        MemeDAO Memes = new MemeDAO();
        private int conteurMeme = 0;
        private string rss = "http://www.reddit.com/r/memes.rss";
        private List<Meme> listeMeme = new List<Meme>();
        public void NotifierAfficherMemes(MemeWindow window)
        {

            listeMeme = Memes.listerMemes(rss);
            foreach (Meme meme in listeMeme)
            {
                Console.WriteLine(meme.Titre);

                if (conteurMeme == 6) break;
                switch (conteurMeme)
                {
                    case 0:
                        Console.WriteLine(meme.Titre);
                        window.Meme1.Text = meme.Titre;
                        conteurMeme++;
                        break;
                    case 1:
                        Console.WriteLine(meme.Titre);
                        window.Meme2.Text = meme.Titre;
                        conteurMeme++;
                        break;
                    case 2:
                        Console.WriteLine(meme.Titre);
                        window.Meme3.Text = meme.Titre;
                        conteurMeme++;
                        break;
                    case 3:
                        Console.WriteLine(meme.Titre);
                        window.Meme4.Text = meme.Titre;
                        conteurMeme++;
                        break;
                    case 4:
                        Console.WriteLine(meme.Titre);
                        window.Meme5.Text = meme.Titre;
                        conteurMeme++;
                        break;
                    case 5:
                        Console.WriteLine(meme.Titre);
                        window.Meme6.Text = meme.Titre;
                        conteurMeme++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
