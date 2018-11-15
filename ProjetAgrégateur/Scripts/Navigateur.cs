using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur.Scripts
{
    class Navigateur
    {
        public Acceuil acceuil = new Acceuil();
        public CryptoWindow crypto = new CryptoWindow();
        public MemeWindow memes = new MemeWindow();
        public MessagesWindow messages = new MessagesWindow();
        public MeteoWindow meteo = new MeteoWindow();
        public PokeWindow poke = new PokeWindow();

        public void initialiserFenetres()
        {
            acceuil.Show();
            crypto.Hide();
            memes.Hide();
            messages.Hide();
            meteo.Hide();
            poke.Hide();
        }
        
        public void changerFenetre(int FenetreAvant, int FenetreApres)
        {
            switch(FenetreAvant)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
                
                    
        }
    }
}
