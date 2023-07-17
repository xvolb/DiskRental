namespace Pujcovna
{
    partial class PridaniZakaznika
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
            this.btnPridat = new System.Windows.Forms.Button();
            this.txtbJmeno = new System.Windows.Forms.TextBox();
            this.txtbPrijmeni = new System.Windows.Forms.TextBox();
            this.txtbAdresa = new System.Windows.Forms.TextBox();
            this.txtRokNarozeni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(34, 165);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(119, 57);
            this.btnPridat.TabIndex = 0;
            this.btnPridat.Text = "Pridat";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // txtbJmeno
            // 
            this.txtbJmeno.Location = new System.Drawing.Point(43, 12);
            this.txtbJmeno.Name = "txtbJmeno";
            this.txtbJmeno.Size = new System.Drawing.Size(100, 22);
            this.txtbJmeno.TabIndex = 1;
            this.txtbJmeno.Text = "Jmeno";
            // 
            // txtbPrijmeni
            // 
            this.txtbPrijmeni.Location = new System.Drawing.Point(43, 49);
            this.txtbPrijmeni.Name = "txtbPrijmeni";
            this.txtbPrijmeni.Size = new System.Drawing.Size(100, 22);
            this.txtbPrijmeni.TabIndex = 2;
            this.txtbPrijmeni.Text = "Prijmeni";
            // 
            // txtbAdresa
            // 
            this.txtbAdresa.Location = new System.Drawing.Point(43, 86);
            this.txtbAdresa.Name = "txtbAdresa";
            this.txtbAdresa.Size = new System.Drawing.Size(100, 22);
            this.txtbAdresa.TabIndex = 3;
            this.txtbAdresa.Text = "Adresa";
            // 
            // txtRokNarozeni
            // 
            this.txtRokNarozeni.Location = new System.Drawing.Point(43, 126);
            this.txtRokNarozeni.Name = "txtRokNarozeni";
            this.txtRokNarozeni.Size = new System.Drawing.Size(100, 22);
            this.txtRokNarozeni.TabIndex = 4;
            this.txtRokNarozeni.Text = "Rok narozeni";
            // 
            // PridaniZakaznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 250);
            this.Controls.Add(this.txtRokNarozeni);
            this.Controls.Add(this.txtbAdresa);
            this.Controls.Add(this.txtbPrijmeni);
            this.Controls.Add(this.txtbJmeno);
            this.Controls.Add(this.btnPridat);
            this.Name = "PridaniZakaznika";
            this.Text = "PridaniZakaznika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.TextBox txtbJmeno;
        private System.Windows.Forms.TextBox txtbPrijmeni;
        private System.Windows.Forms.TextBox txtbAdresa;
        private System.Windows.Forms.TextBox txtRokNarozeni;
    }
}