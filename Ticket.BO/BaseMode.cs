using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.BO
{
    public class BaseMode
    {
        public string Id { get; set; }
        public string Nom { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Produit product &&

                   Id.Equals(product.Id, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
