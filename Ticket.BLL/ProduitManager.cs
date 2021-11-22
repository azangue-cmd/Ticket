using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.BO;
using Ticket.DAL;
namespace Ticket.BLL
{
    public class ProduitManager
    {
       public ProduitRepertory produitRepertory;
       // public ProduitRepertory repository;
        protected List<Produit> datas;

        public ProduitManager()
        {
           // repository = new ProduitRepertory();
            produitRepertory = new ProduitRepertory();
        }

        public void AddProduit(Produit produit)
        {
            produitRepertory.Add(produit);
            produitRepertory.Save();
        }

        public List<Produit> GetAllProduit()
        {
            return produitRepertory.GetAll();
        }

        public void CreateProduit(Produit produit)
        {
            produitRepertory.Add(produit);
            produitRepertory.Save();
        }

        public void Edit(Produit oldObj, Produit newObj)
        {
            produitRepertory.Update(oldObj, newObj);
            produitRepertory.Save();
        }

        public void Delete(Produit obj)
        {
            produitRepertory.Delete(obj);
            produitRepertory.Save();
        }

        public List<Produit> Search(string nom)
        {
            return produitRepertory.FindByName(nom);
        }




    }
}
