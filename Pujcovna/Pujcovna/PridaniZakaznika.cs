using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pujcovna
{
    public partial class PridaniZakaznika : Form
    {
        public PridaniZakaznika()
        {
            InitializeComponent();
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            string jmeno = txtbJmeno.Text;
            string prijmeni = txtbPrijmeni.Text;
            string adresa = txtbAdresa.Text;
            try
            {
                ushort rokNarozeni = Convert.ToUInt16(txtRokNarozeni.Text);
                Databaze.Zakaznici.Add(new Zakaznik(jmeno, prijmeni, adresa, rokNarozeni));
                txtbJmeno.Text = "Jmeno";
                txtbPrijmeni.Text = "Prijmeni";
                txtbAdresa.Text = "Adresa";
                txtRokNarozeni.Text = "Rok narozeni";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Zadejte spravny rok narozeni");
            }
            
            
        }
    }
}
