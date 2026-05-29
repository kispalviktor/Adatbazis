using System;
using System.Windows.Forms;

namespace OrvosRendelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNyit_Click(object sender, EventArgs e)
        {
            new Form2().Show(); this.Hide();
        }

        private void btnUjBeteg_Click(object sender, EventArgs e)
        {
            new Form3().Show(); this.Hide();
        }

        private void btnOsszesAdat_Click(object sender, EventArgs e)
        {
            new Form4().Show(); this.Hide();
        }

        private void btnSzerkeszt_Click(object sender, EventArgs e)
        {
            new Form5().Show(); this.Hide();
        }

        private void btnSzabadIdopont_Click(object sender, EventArgs e)
        {
            new Form6().Show(); this.Hide();
        }

        private void btnStatusz_Click(object sender, EventArgs e)
        {
            new Form7().Show(); this.Hide();
        }
    }
}