
namespace Ticket.Forms
{
    partial class frmAddProduit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(128, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 26);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quantite";
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(59, 345);
            this.tbQuantite.Multiline = true;
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(255, 26);
            this.tbQuantite.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id";
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(59, 280);
            this.tbPrix.Multiline = true;
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(255, 26);
            this.tbPrix.TabIndex = 16;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(59, 219);
            this.tbNom.Multiline = true;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(255, 26);
            this.tbNom.TabIndex = 15;
            // 
            // tbReference
            // 
            this.tbReference.Location = new System.Drawing.Point(59, 153);
            this.tbReference.Multiline = true;
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(255, 26);
            this.tbReference.TabIndex = 14;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(59, 91);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(255, 26);
            this.tbId.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 51);
            this.panel1.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(333, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 45);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Produit";
            // 
            // frmAddProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbQuantite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.tbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}

