using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Forms
{
    public class RptProduitListe
    {
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }

        public RptProduitListe(string nom, int quantite, float prix)
        {
            Nom = nom;
            Quantite = quantite;
            Prix = prix;
        }
    }
}
