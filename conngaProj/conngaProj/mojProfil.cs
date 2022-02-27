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
            chsBg_list.Hide();
            bg_chng_01.Hide();
            bg_chng_02.Hide();
        }

        private void chsBg_Click(object sender, EventArgs e)
        {
            chsBg.Hide();
            chsBg_list.Show();
            chsBg2.BringToFront();
            chsBg2.Show();
            bg_chng_01.Show();
            bg_chng_02.Show();
            bg_chng_01.BringToFront();
            bg_chng_02.BringToFront();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chsBg2_Click(object sender, EventArgs e)
        {
            chsBg2.Hide();
            chsBg_list.Hide();
            chsBg.Show();
            bg_chng_01.Hide();
            bg_chng_02.Hide();
        }

        private void chsBg2_Click_1(object sender, EventArgs e)
        {
            chsBg2.Hide();
            chsBg_list.Hide();
            chsBg.Show();
            bg_chng_01.Hide();
            bg_chng_02.Hide();
        }

        private void chsBg_list_Click(object sender, EventArgs e)
        {
            
        }

        private void bg_chng_02_Click(object sender, EventArgs e)
        {
            bg_main.BackgroundImage = Image.FromFile(@"\Connga\Connga\conngaProj\backgrounds\witcher3.jpg");
            bg_main_finished.BackgroundImage = Image.FromFile(@"\Connga\Connga\conngaProj\backgrounds\witcher3.jpg");
        }

        private void bg_chng_01_Click(object sender, EventArgs e)
        {
            bg_main.BackgroundImage = Image.FromFile(@"\Connga\Connga\conngaProj\backgrounds\portal2.jpg");
            bg_main_finished.BackgroundImage = Image.FromFile(@"\Connga\Connga\conngaProj\backgrounds\portal2.jpg");
        }

        private void bg_main_Click(object sender, EventArgs e)
        {

        }

        private void bg_main_finished_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_prof_Click(object sender, EventArgs e)
        {
            btn_edit_prof.Hide();
            bg_main_finished.Hide();
            chsBg.Show();
        }

        private void saveChngs_Click(object sender, EventArgs e)
        {
            btn_edit_prof.Show();
            bg_main_finished.Show();
            chsBg2.Hide();
            chsBg_list.Hide();
            bg_chng_01.Hide();
            bg_chng_02.Hide();
        }
    }
}
