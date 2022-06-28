using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Form2 : Form
    {
        public string P1Name { get; set; }
        public string P2Name { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            P1Name = txbP1.Text;
            P2Name = txbP2.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbP2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbP2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbP2, "Името е задолжително!");
            }
            else
            {
                errorProvider1.SetError(txbP2, null);
            }
        }

        private void txbP1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbP1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbP1, "Името е задолжително!");
            }
            else
            {
                errorProvider1.SetError(txbP1, null);
            }
        }
    }
}
