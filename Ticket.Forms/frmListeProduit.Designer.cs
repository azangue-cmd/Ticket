
namespace Ticket.Forms
{
    partial class frmListeProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panListeProduit = new System.Windows.Forms.Panel();
            this.lvProduit = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panListeProduit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panListeProduit
            // 
            this.panListeProduit.Controls.Add(this.lvProduit);
            this.panListeProduit.Location = new System.Drawing.Point(2, 55);
            this.panListeProduit.Name = "panListeProduit";
            this.panListeProduit.Size = new System.Drawing.Size(443, 267);
            this.panListeProduit.TabIndex = 0;
            // 
            // lvProduit
            // 
            this.lvProduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProduit.HideSelection = false;
            this.lvProduit.Location = new System.Drawing.Point(0, 0);
            this.lvProduit.Name = "lvProduit";
            this.lvProduit.Size = new System.Drawing.Size(443, 267);
            this.lvProduit.TabIndex = 0;
            this.lvProduit.UseCompatibleStateImageBehavior = false;
            this.lvProduit.View = System.Windows.Forms.View.Details;
            this.lvProduit.SelectedIndexChanged += new System.EventHandler(this.lvProduit_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 219;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reference";
            this.columnHeader2.Width = 215;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(451, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 292);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(570, 292);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(4, 29);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(346, 20);
            this.tbRecherche.TabIndex = 2;
            this.tbRecherche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(356, 29);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(89, 23);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(148, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Suprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(20, 358);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Nouveau ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 398);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panListeProduit);
            this.Name = "frmListeProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListeProduit";
            this.Load += new System.EventHandler(this.frmListeProduit_Load);
            this.panListeProduit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panListeProduit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvProduit;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}