using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur.Scripts
{
    class PokemonDAO
    {
        public List<Pokemon> listerPoke()
        {
            List<Pokemon> listePokemon = new List<Pokemon>();

            string url = "https://pokeapi.co/api/v2/pokemon/";

            HttpWebRequest requetePoke = (HttpWebRequest)WebRequest.Create(url);
            requetePoke.Method = "GET";

            //TODO Finir
            return listePokemon;
        }
    }
}
