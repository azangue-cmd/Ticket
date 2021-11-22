
namespace TicketApp
{
    partial class frmAddProduit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 51);
            this.panel1.TabIndex = 0;
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
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(59, 86);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(255, 26);
            this.tbId.TabIndex = 1;
            // 
            // tbReference
            // 
            this.tbReference.Location = new System.Drawing.Point(59, 148);
            this.tbReference.Multiline = true;
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(255, 26);
            this.tbReference.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(59, 214);
            this.tbNom.Multiline = true;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(255, 26);
            this.tbNom.TabIndex = 3;
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(59, 275);
            this.tbPrix.Multiline = true;
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(255, 26);
            this.tbPrix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prix";
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(59, 340);
            this.tbQuantite.Multiline = true;
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(255, 26);
            this.tbQuantite.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantite";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(128, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProduit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}