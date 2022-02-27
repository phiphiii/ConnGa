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
    public partial class biblioteka : UserControl
    {
        public biblioteka()
        {
            InitializeComponent();

            pictureBox5.Hide();
            pictureBox6.Hide();
        }

        private void biblioteka_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void sortowanieSzukaj_Click(object sender, EventArgs e)
        {

        }

        private void sortowanieZA_Click(object sender, EventArgs e)
        {
            pictureBox6.Show();
            pictureBox5.Hide();
            pictureBox1.Hide();
        }

        private void sortowanieAZ_Click(object sender, EventArgs e)
        {
            pictureBox5.Show();
            pictureBox6.Hide();
            pictureBox1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "shell:RecycleBinFolder");
        }
    }
}
