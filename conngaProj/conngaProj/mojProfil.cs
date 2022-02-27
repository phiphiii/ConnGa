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
    public partial class mojProfil : UserControl
    {
        public mojProfil()
        {
            InitializeComponent();
            chsBg2.Hide();
        }

        private void chsBg_Click(object sender, EventArgs e)
        {
            chsBg.Hide();
            chsBg2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chsBg2_Click(object sender, EventArgs e)
        {
            chsBg2.Hide();
            chsBg.Show();
        }

        private void chsBg2_Click_1(object sender, EventArgs e)
        {
            chsBg2.Hide();
            chsBg.Show();
        }
    }
}
