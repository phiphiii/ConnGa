using System.Runtime.InteropServices;

namespace conngaProj
{
    public partial class ConnGa : Form
    {
        public ConnGa()
        {

            InitializeComponent();

            statystykiW.FlatAppearance.MouseOverBackColor = statystykiW.BackColor;
            statystykiW.BackColorChanged += (s, e) => {
                statystykiW.FlatAppearance.MouseOverBackColor = statystykiW.BackColor;
            };

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e) // button statystyki
        {
            userControl11.BringToFront();
            userControl11.Show();

            userControl21.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            userControl11.Hide();

            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void btn_library_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();

            userControl21.Show();
            userControl21.BringToFront();
        }

        private void mojProfil_Click(object sender, EventArgs e) // button mój profil
        {
            mojProfil1.BringToFront();
            mojProfil1.Show();

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void bibliotekaW_Click(object sender, EventArgs e) // button biblioteka
        {
            userControl21.BringToFront();
            userControl21.Show();

            userControl11.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void zainstalowaneW_Click(object sender, EventArgs e) // button biblioteka
        {
            userControl31.BringToFront();
            userControl31.Show();

            userControl11.Hide();
            userControl21.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void aktywnoscW_Click(object sender, EventArgs e) // button aktywnoœæ
        {
            aktywnosc1.BringToFront();
            aktywnosc1.Show();

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            profilKozy1.Hide();
        }

        private void dodajZnajomego_Click(object sender, EventArgs e) // button dodaj znajomego
        {

        }

        private void znaj2_Click(object sender, EventArgs e) // button profil Kozy
        {
            profilKozy1.BringToFront();
            profilKozy1.Show();

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            aktywnosc1.Hide();
            mojProfil1.Hide();
        }
    }


}
