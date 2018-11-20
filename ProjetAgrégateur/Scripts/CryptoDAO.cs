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

       
        public List<CryptoMonnaie> listerMonnaies() 
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

            List<CryptoMonnaie> listeCryptomonnaie = new List<CryptoMonnaie>();
            foreach (dynamic itemMonnaie in lesMonnaies)
            {
                var monnaie = itemMonnaie.Value;
                var symbole = monnaie["Symbol"];
                var nom = monnaie["CoinName"];
                var algorithme = monnaie["Algorithm"];
                var nombre = monnaie["TotalCoinSupply"];
               
                Console.WriteLine("Monnaie " + symbole + " : " + nom + "(" + nombre + ")");

                
                CryptoMonnaie cryptomonnaie = new CryptoMonnaie();
                cryptomonnaie.symbole = symbole;
                cryptomonnaie.nom = nom;
                cryptomonnaie.algorithme = algorithme;
                cryptomonnaie.nombre = nombre;
                listeCryptomonnaie.Add(cryptomonnaie);
            }

            return listeCryptomonnaie;
        }

        public CryptoMonnaie detaillerMonnaie()
        {
            CryptoMonnaie cryptomonnaie = new CryptoMonnaie();



            return cryptomonnaie;
        }

    }
}
