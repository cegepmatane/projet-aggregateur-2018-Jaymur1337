using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur.Scripts
{
    class Meme
    {
        public string titre;

        public string getTitre()
        {
            return titre;
        }

        public void setTitre(string title)
        {
            this.titre = title;
        }

        

        public string lienUtilisateur { get; set; }

        public string nomUtilisateur { get; set; }

        
    }
}
