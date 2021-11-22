using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.BO
{
    public class Produit:BaseMode
    {
        public string reference { get; set; }
       // public string Nom { get; set; }
        //public string Id { get; set; }
        public float Prix { get; set; }
        public int Quantite { get; set; }
        public static int SommeT { get; set; }

        public Produit(string identifient, string reff, string name, float montant, int qte)
        {
            Nom = name;
            reference = reff;
            Prix = montant;
            Id = identifient;
            Quantite = qte;
        }


    }
}
