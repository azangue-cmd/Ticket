using Microsoft.Reporting.WinForms;
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
    public partial class frmListeProduit : Form
    {
        List<Produit> produits = new List<Produit>();
        ProduitManager manager;
        public frmListeProduit()
        {
            InitializeComponent();
            manager = new ProduitManager();
        }

        private void frmListeProduit_Load(object sender, EventArgs e)
        {
            lvProduit.Items.Clear();
            produits = manager.GetAllProduit();
            if (produits.Count != 0)
                foreach (var prod in produits)
                {
                    var item = new ListViewItem(new string[] { prod.Nom, prod.reference });
                    
                    item.Tag = prod.Id;
                    lvProduit.Items.Add(item);
                }
            this.reportViewer1.RefreshReport();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvProduit.SelectedItems.Count != 0)
            {
                var btn = MessageBox.Show("Do you really want to delete selected item(s)?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (btn == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lvProduit.SelectedItems)
                    {
                        foreach (var prod in produits)
                            if (prod.Id == (string)item.Tag)
                                manager.Delete(prod);
                    }
                }
                frmListeProduit_Load(sender, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

     

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new frmAddProduit();
            form.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "rptFacture.rdlc";
            frmRpFacture frmListe = new frmRpFacture();

            List<RptProduitListe> produits = new List<RptProduitListe>
            {
                new RptProduitListe( "Pot", 5, 5000),
                 new RptProduitListe( "Pot en Or", 1, 25000),
                  new RptProduitListe( "Usb", 1, 5000)
            };


            Recup recup = new Recup();
            foreach (var pro in produits)
            {
                recup.Somme += pro.Quantite;
            }

            List<int> rsom = new List<int>();
            rsom.Add(recup.Somme);
            this.reportViewer1.LocalReport.DataSources.Add
                (
                    new ReportDataSource("DataSet1", produits)
                );

            this.reportViewer1.LocalReport.DataSources.Add
                (
                    new ReportDataSource("DataSet2", rsom)
                );


            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 60;
            this.reportViewer1.RefreshReport();

        }

        private void lvProduit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (tbRecherche.Text != string.Empty)
            {
                produits = manager.Search(tbRecherche.Text);
                if (produits.Count != 0)
                {
                    lvProduit.Items.Clear();
                    foreach (var prod in produits)
                    {
                        var item = new ListViewItem(new string[] { prod.Nom, prod.reference });
                        item.Tag = prod.Nom;
                        lvProduit.Items.Add(item);

                    }
                }

            }
            else
                frmListeProduit_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
