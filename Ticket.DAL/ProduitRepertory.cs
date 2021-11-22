using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.BO;

namespace Ticket.DAL
{
    public class ProduitRepertory:BaseRepertory<Produit>
    {
        
        
        public List<Produit> FindByName(string value)
        {
            List<Produit> list = new List<Produit>();
            foreach (var data in datas)
                if (data.Nom.ToLower().Contains(value.ToLower()))
                    list.Add(data);
            return new List<Produit>(list);
        }

       
    }
}
