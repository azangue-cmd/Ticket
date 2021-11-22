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
using Ticket.BO;

namespace Ticket.Forms
{
    public partial class frmRpFacture : Form
    {
        public frmRpFacture()
        {
            InitializeComponent();
        }


        private void frmRpFacture_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "rptFacture.rdlc";
            AddReport();
        }

        public void AddReport()
        {
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
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

    }
}
