using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P31_Porpiglia3AINF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NUDpes.Maximum = decimal.MaxValue;
            NUDeur.Maximum = decimal.MaxValue;
            NUDusd.Maximum = decimal.MaxValue;
        }

        private void BTcalcola_Click(object sender, EventArgs e)
        {
            float peso = Convert.ToSingle(NUDpes.Value), usd = 0, eur;

            if (peso < 20)
            {
                usd = (peso * 5) + 5;
            }

            if (peso >= 20 && peso < 50)
            {
                usd = peso * 4;
            }
            else if (peso > 50)
            {
                usd = peso * 3;
            }

            eur = usd * 1.05f;

            NUDusd.Value = Convert.ToDecimal(usd);
            NUDeur.Value = Convert.ToDecimal(eur);

        }

        private void NUDusd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il costo in $ è uno dei risultati, non editarlo");
            return;
        }

        private void NUDeur_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il costo in € è uno dei risultati, non editarlo");
            return;
        }

        private void BTesci_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
