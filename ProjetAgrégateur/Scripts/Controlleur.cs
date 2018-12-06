using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur
{
    class Controlleur
    {
        public void NotifierChangerVersNews(Acceuil acceuil)
        {
            acceuil.ChangerVersMemes();
        }
        public void NotifierChangerVersPoke(Acceuil acceuil)
        {
            acceuil.ChangerVersPokemon();
        }
        public void NotifierChangerVersMeteo(Acceuil acceuil)
        {
            acceuil.ChangerVersMeteo();
        }
        public void NotifierChangerVersCrypto(Acceuil acceuil)
        {
            acceuil.ChangerVersCrypto();
        }
        public void NotifierChangerVersMessages(Acceuil acceuil)
        {
            acceuil.ChangerVersMessages();
        }
    }
}
