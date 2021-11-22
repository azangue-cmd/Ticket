using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket.BLL;
using Ticket.BO;

namespace Ticket.Forms
{
    public partial class frmAddProduit : Form
    {
        ProduitManager manager;

       // bool isLoged = true;
        List<Produit> produits = new List<Produit>();


        
      //  Produit oldProduit = null;
        public frmAddProduit()
        {
            InitializeComponent();
            manager = new ProduitManager();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var client = new Produit(tbId.Text, tbReference.Text, tbNom.Text, float.Parse(tbPrix.Text), int.Parse(tbQuantite.Text));
            manager.AddProduit(client);
            clear(client);
           var form = new frmListeProduit();
           form.Show();
            this.Close();


        }

        private void clear(Produit client)
        {
          
            tbId.Clear();
            tbReference.Clear();
            tbNom.Clear();
            tbPrix.Clear();
            tbQuantite.Clear();
        }

        private void frmListeProduit_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
