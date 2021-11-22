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

namespace TicketApp
{
    public partial class frmAddProduit : Form
    {
        ProduitManager manager;

        public frmAddProduit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var client = new Produit(tbId.Text, tbReference.Text, tbNom.Text,float.Parse(tbPrix.Text), int.Parse(tbQuantite.Text));
            manager.AddProduit(client);
            tbId.Clear();
            tbReference.Clear();
            tbNom.Clear();
            tbPrix.Clear();
            tbQuantite.Clear();
        }
    }
}
