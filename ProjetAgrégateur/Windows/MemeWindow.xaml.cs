﻿using System;
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
        MemeControlleur CMeme = new MemeControlleur();
        


        
        List<Meme> listeMeme;

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
            listeMeme = new List<Meme>();
            CMeme.NotifierAfficherMemes(this);
            
        }

       

        private void Home_Click(object sender, RoutedEventArgs e)
        {

            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Close();
        }




    }


}
