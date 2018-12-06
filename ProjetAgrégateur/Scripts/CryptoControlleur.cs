using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgrégateur.Scripts
{
    class CryptoControlleur
    {
        CryptoDAO DAO = new CryptoDAO();
        CryptoMonnaie bitcoin;
        public void notifierAfficherBitCoin(CryptoWindow window)
        {
            bitcoin = DAO.trouverBitCoin();

            window.Nom.Text = bitcoin.nom;
            window.Quantité.Text = bitcoin.nombre;
        }


    }
}
