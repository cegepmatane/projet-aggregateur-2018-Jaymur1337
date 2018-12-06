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
    public partial class CryptoWindow : Window
    {

        CryptoControlleur Control = new CryptoControlleur();
        public CryptoWindow()
        {
            InitializeComponent();

            Control.notifierAfficherBitCoin(this);
        }

        //TODO changer pour la nouvelle navigation
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
        }

        
    }
}
