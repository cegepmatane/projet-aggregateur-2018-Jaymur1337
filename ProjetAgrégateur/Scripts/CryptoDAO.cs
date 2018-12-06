using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using ProjetAgrégateur.Scripts;

namespace ProjetAgrégateur
{
    class CryptoDAO
    {
        private bool bitcoinTrouvé = false;
        private CryptoMonnaie cryptomonnaie;
        public CryptoMonnaie trouverBitCoin() 
        {
            Console.WriteLine("CryptoMonnaieDAO.listerMonnaies()");
            string url = "https://www.cryptocompare.com/api/data/coinlist/";
            HttpWebRequest requeteListeMonnaies = (HttpWebRequest)WebRequest.Create(url);
            WebResponse reponse = requeteListeMonnaies.GetResponse();
            StreamReader lecteurListeMonnaies = new StreamReader(reponse.GetResponseStream());
            string json = lecteurListeMonnaies.ReadToEnd();
            

            JavaScriptSerializer parseur = new JavaScriptSerializer();
            dynamic objet = parseur.Deserialize<dynamic>(json);
            var lesMonnaies = objet["Data"];

            
            foreach (dynamic itemMonnaie in lesMonnaies)
            {
                if (bitcoinTrouvé) break;
                var monnaie = itemMonnaie.Value;
                var symbole = monnaie["Symbol"];
                string nom = monnaie["CoinName"];
                var algorithme = monnaie["Algorithm"];
                var nombre = monnaie["TotalCoinSupply"];

                if (nom == "BottleCaps")
                    bitcoinTrouvé = true;
                
                    

                Console.WriteLine("Monnaie " + symbole + " : " + nom + "(" + nombre + ")");

                if (!bitcoinTrouvé) continue;

                cryptomonnaie = new CryptoMonnaie();
                cryptomonnaie.symbole = symbole;
                cryptomonnaie.nom = nom;
                cryptomonnaie.algorithme = algorithme;
                cryptomonnaie.nombre = nombre;
                
            }

            return cryptomonnaie;
        }

        public CryptoMonnaie detaillerMonnaie()
        {
            CryptoMonnaie cryptomonnaie = new CryptoMonnaie();



            return cryptomonnaie;
        }

    }
}
