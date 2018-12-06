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
        private int conteurMeme = 0;
        public List<Meme> listerMemes(string rss)
        {
            
            List<Meme> liste = new List<Meme>();
            //Console.WriteLine("MemeDao.ListerMemes();");
            HttpWebRequest demandeMemes = (HttpWebRequest)WebRequest.Create(rss);
            demandeMemes.Method = "GET";
            demandeMemes.UserAgent = "Mozilla FireFox";
            WebResponse reponse = demandeMemes.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());

            string xml = lecteur.ReadToEnd();
            XElement MemesXML = XElement.Parse(xml);
          

            foreach (XElement memeXML in MemesXML.Elements())
            {
                if (conteurMeme >= 6) break;
                XmlReader lecteurMeme = memeXML.CreateReader();

                string test = memeXML.Name.LocalName;

                lecteurMeme.ReadToDescendant("title");
                string titreMeme = lecteurMeme.ReadInnerXml();
                if (titreMeme == "") continue;
                Console.WriteLine(titreMeme);

                lecteurMeme.ReadToFollowing("Content");

                Meme meme = new Meme();
                meme.Titre = titreMeme.ToString(); 
                

                liste.Add(meme);
            }
            return liste;
        }
    }
}
