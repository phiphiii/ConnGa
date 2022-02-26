using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conngaProj
{
    public partial class profilKozy : UserControl
    {
        public profilKozy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dodajZnaj_Click(object sender, EventArgs e)
        {
            dodajZnaj.Hide();
            cnclZnaj.Show();
        }

        private void cnclZnaj_Click(object sender, EventArgs e)
        {
            dodajZnaj.Show();
            cnclZnaj.Hide();
        }
    }
}
