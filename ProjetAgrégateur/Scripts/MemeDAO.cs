using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace ProjetAgrégateur.Scripts
{
    class MemeDAO
    {
        private int conteur = 0;
        public List<Meme> listerMemes(string rss)
        {
            List<Meme> listeMeme = new List<Meme>();
            Console.WriteLine("MemeDao.ListerMemes();");
            HttpWebRequest demandeMemes = (HttpWebRequest)WebRequest.Create(rss);
            demandeMemes.Method = "GET";
            demandeMemes.UserAgent = "Mozilla Firefox";

            WebResponse reponse = demandeMemes.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());

            string xml = lecteur.ReadToEnd();
            XElement MemesXML = XElement.Parse(xml);
            foreach (XElement memeXML in MemesXML.Elements())
            {
                XmlReader lecteurMeme = memeXML.CreateReader();
                lecteurMeme.MoveToContent();
                lecteurMeme.ReadToDescendant("title");
                string titre = lecteurMeme.ReadInnerXml();
                Console.WriteLine(titre);
                
                Meme meme = new Meme();
                meme.setTitre(titre); 
                

                listeMeme.Add(meme);
            }
            return listeMeme;
        }
    }
}
