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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            popularneGry.Show();
            popularneGryTest.Hide();
            ostatnioUruchamianeGry.Show();
            ostatnioUruchamianeGryTest.Hide();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            popularneGry.Show();
            popularneGryTest.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            popularneGry.Hide();
            popularneGryTest.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ostatnioUruchamianeGry.Show();
            ostatnioUruchamianeGryTest.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ostatnioUruchamianeGry.Hide();
            ostatnioUruchamianeGryTest.Show();
        }

        private void ostatnioUruchamianeGryTest_Click(object sender, EventArgs e)
        {

        }
    }
}
