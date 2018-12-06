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
    public partial class PokeWindow : Window
    {
        Navigateur nav;
        private PokeControlleur controlleur = new PokeControlleur();
        public int IdAcceuil = 0;
        public int IdMemes = 1;
        public int IdMessages = 2;
        public int IdCrypto = 3;
        public int IdMeteo = 4;
        public int IdPoke = 5;
        PokemonDAO Dao = new PokemonDAO();
        private List<Pokemon> listePokemon = new List<Pokemon>();
       

        public PokeWindow()
        {
            InitializeComponent();
            controlleur.notifierAfficherPoke(this);
        }
        public void afficherPoke()
        {
            listePokemon = Dao.listerPoke();
            int i = 0;
            foreach(Pokemon poke in listePokemon)
            {
                switch(i)
                {
                    case 0:
                        this.Poke1.Text = poke.nom;
                        i++;
                        break;
                    case 3:
                        this.Poke2.Text = poke.nom;
                        i++;
                        break;
                    case 6:
                        this.Poke3.Text = poke.nom;
                        i++;
                        break;
                    default:
                        i++;
                        break;
                }
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
