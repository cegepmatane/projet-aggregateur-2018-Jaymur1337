using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur.Scripts
{
    class Pokemon
    {
        public string nom { get; set; }

        public int numero { get; set; }

        public int taille { get; set; }

        public List<string> capacites { get; set; }
        
        public Pokemon()
        {
            this.capacites = new List<string>();
        }

        public void ajouterCapacite(string attaque)
        {
            this.capacites.Add(attaque);
        }

    }
}
