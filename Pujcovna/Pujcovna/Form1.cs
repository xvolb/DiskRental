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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvZakaznici.DataSource = Databaze.Zakaznici;
            dgvSklad.DataSource = Databaze.Sklad;

        }
        private void CheckButton(int indZ)
        {
            btnVypujcit.Enabled = (Databaze.Sklad.Count > 0);
            btnVratit.Enabled = (Databaze.Zakaznici[indZ].Vypujcene.Count > 0);

        }

        private void btnPridatZakaznika_Click(object sender, EventArgs e)
        {
            PridaniZakaznika pridaniZakaznika = new PridaniZakaznika();
            pridaniZakaznika.Show();
            
        }

        private void dgvZakaznici_SelectionChanged(object sender, EventArgs e)
        {
            
            int indZ = dgvZakaznici.CurrentCell.RowIndex;
            dgvVypujcene.DataSource = Databaze.Zakaznici[indZ].Vypujcene;
            CheckButton(indZ);
        }


        private void btnVypujcit_Click(object sender, EventArgs e)
        {
            
            int indZ = dgvZakaznici.CurrentCell.RowIndex;
            int indS = dgvSklad.CurrentRow.Index;

            Databaze.Zakaznici[indZ].Vypujcene.Add(Databaze.Sklad[indS]);
            Databaze.Sklad.RemoveAt(indS);
            CheckButton(indZ);
        }

        private void btnVratit_Click(object sender, EventArgs e)
        {
            int indZ = dgvZakaznici.CurrentCell.RowIndex;
            int indV = dgvVypujcene.CurrentCell.RowIndex;

            Databaze.Sklad.Add(Databaze.Zakaznici[indZ].Vypujcene[indV]);
            Databaze.Zakaznici[indZ].Vypujcene.RemoveAt(indV);
            CheckButton(indZ);
        }
    }
}
