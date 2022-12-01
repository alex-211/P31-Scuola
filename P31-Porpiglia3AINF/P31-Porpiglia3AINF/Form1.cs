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
