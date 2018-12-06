using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur.Scripts
{
    class Navigateur
    {
        public Acceuil acceuil;
        
        public CryptoWindow crypto = new CryptoWindow();
        public MemeWindow memes = new MemeWindow();
        public MessagesWindow messages = new MessagesWindow();
        public MeteoWindow meteo = new MeteoWindow();
        public PokeWindow poke = new PokeWindow();


        public void initialiserFenetres(Acceuil Aceuil)
        {
            this.acceuil = Aceuil;
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
                    acceuil.Hide();
                    break;
                case 1:
                    memes.Hide();
                    break;
                case 2:
                    messages.Hide();
                    break;
                case 3:
                    crypto.Hide();
                    break;
                case 4:
                    meteo.Hide();
                    break;
                case 5:
                    poke.Hide();
                    break;
            }

            switch(FenetreApres)
            {
                case 0:
                    acceuil.Show();
                    break;
                case 1:
                    memes.Show();
                    break;
                case 2:
                    messages.Show();
                    break;
                case 3:
                    crypto.Show();
                    break;
                case 4:
                    meteo.Show();
                    break;
                case 5:
                    poke.Show();
                    break;
            }
                
                    
        }
    }
}


//public int IdAcceuil = 0;
//public int IdMemes = 1;
//public int IdMessages = 2;
//public int IdCrypto = 3;
//public int IdMeteo = 4;
//public int IdPoke = 5;