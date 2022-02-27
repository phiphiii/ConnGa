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
        string nickname = "ConngAdmin";
        public mojProfil()
        {
            InitializeComponent();
            chsBg2.Hide();
            chsBg_list.Hide();
            bg_chng_01.Hide();
            bg_chng_02.Hide();
            chsGm2.Hide();
            chsGm.Show();
            chsGm_list.Hide();
            favGm_lista.Hide();
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
            nickname_saved.Show();
            nickname_saved.BringToFront();
            favGm_label.Show();
            favGm_label.BringToFront();
        }

        private void btn_edit_prof_Click(object sender, EventArgs e)
        {
            btn_edit_prof.Hide();
            bg_main_finished.Hide();
            chsBg.Show();
            chsGm.Show();
            nickname_edit.Text = nickname;
            favGm_label.Hide();
            nickname_saved.Hide();

        }

        private void saveChngs_Click(object sender, EventArgs e)
        {
            nickname = nickname_edit.Text;
            if ((nickname_edit.Text.Length == 0) || (nickname_edit.Text.Length > 12))
            {
                if(nickname_edit.Text.Length > 12) { 
                    wrgNick.Text = "Podano za długą nazwę użytkownika"; 
                }
                if(nickname_edit.Text.Length == 0) { 
                    wrgNick.Text = "Podano za krótką nazwę użytkownika"; 
                }
            }
            else
            {
                nickname_saved.Text = null;
                nickname_saved.Text = nickname; 
                wrgNick.Text = "";
                btn_edit_prof.Show();
                bg_main_finished.Show();
                chsBg2.Hide();
                chsBg_list.Hide();
                bg_chng_01.Hide();
                bg_chng_02.Hide();
                chsGm2.Hide();
                chsGm_list.Hide();
                favGm_lista.Hide();

            }

        }

        private void nickname_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void nickname_saved_Click(object sender, EventArgs e)
        {

        }

        private void chsGm_list_Click(object sender, EventArgs e)
        {

        }

        private void chsGm_Click(object sender, EventArgs e)
        {
            chsGm.Hide();
            chsGm2.Show();
            chsGm_list.Show();
            favGm_lista.Show();

            List<favGames> list = new List<favGames>();
            list.Add(new favGames() { ID = "1", Name = "Among Us" });
            list.Add(new favGames() { ID = "2", Name = "CS:GO" });
            list.Add(new favGames() { ID = "3", Name = "Garry's Mod" });
            list.Add(new favGames() { ID = "4", Name = "Minecraft" });
            list.Add(new favGames() { ID = "5", Name = "Spore" });
            list.Add(new favGames() { ID = "6", Name = "Wiedźmin 3: Dziki Gon" });

            favGm_lista.DataSource = list;
            favGm_lista.ValueMember = "ID";
            favGm_lista.DisplayMember = "Name";
        }

        private void chsGm2_Click(object sender, EventArgs e)
        {
            chsGm2.Hide();
            chsGm.Show();
            chsGm_list.Hide();
            favGm_lista.Hide();
        }

        private void wrgNick_Click(object sender, EventArgs e)
        {

        }

        private void favGm_lista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            favGames obj = favGm_lista.SelectedItem as favGames;
            if(obj != null)
            {
                favGm_label.Text = obj.Name;
            }

        }

        private void favGm_label_Click(object sender, EventArgs e)
        {

        }
    }
}
