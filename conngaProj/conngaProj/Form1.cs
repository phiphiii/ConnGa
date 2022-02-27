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
            statystykiW.Hide();
            bibliotekaW.Hide();
            zainstalowaneW.Hide();
            mojProfilW.Hide();
            aktywnoscW.Hide();

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
            frndList_add.Hide();
            znajSearchBtn.Hide();
            znajSearchTxt.Hide();

            medzieZnajAdd.Hide();
            medzieZnaj.Hide();
            listaZnajSwitch.Hide();
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

        private void mojProfil_Click(object sender, EventArgs e) // button m�j profil
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

        private void aktywnoscW_Click(object sender, EventArgs e) // button aktywno��
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
            frndList.Hide();
            frndList_add.Show();
            znajSearchBtn.Show();
            listaZnajSwitch.Show();
            znajSearchTxt.Show();
            znajSearchTxt.BringToFront();
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

            statystykiW.Hide();
            aktywnoscW.Hide();
            zainstalowaneW.Hide();
            bibliotekaW.Hide();
            mojProfilW.Hide();

            statyBezBialego.Show();
            aktywBezBialego.Show();
            zainstalBezBialego.Show();
            biblioBezBialego.Show();
            mojProfBezBialego.Show();
        }

        private void znaj1_Click(object sender, EventArgs e)
        {

        }

        private void statyBezBialego_Click(object sender, EventArgs e)
        {
            statystykiW.Show();
            statyBezBialego.Hide();

            bibliotekaW.Hide();
            zainstalowaneW.Hide();
            mojProfilW.Hide();
            aktywnoscW.Hide();

            biblioBezBialego.Show();
            zainstalBezBialego.Show();
            mojProfBezBialego.Show();
            aktywBezBialego.Show();

            userControl11.BringToFront();
            userControl11.Show();

            userControl21.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void aktywBezBialego_Click(object sender, EventArgs e)
        {
            aktywnoscW.Show();
            aktywBezBialego.Hide();

            statystykiW.Hide();
            bibliotekaW.Hide();
            zainstalowaneW.Hide();
            mojProfilW.Hide();

            statyBezBialego.Show();
            biblioBezBialego.Show();
            zainstalBezBialego.Show();
            mojProfBezBialego.Show();

            aktywnosc1.BringToFront();
            aktywnosc1.Show();

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            profilKozy1.Hide();
        }

        private void zainstalBezBialego_Click(object sender, EventArgs e)
        {
            zainstalowaneW.Show();
            zainstalBezBialego.Hide();

            statystykiW.Hide();
            bibliotekaW.Hide();
            mojProfilW.Hide();
            aktywnoscW.Hide();

            statyBezBialego.Show();
            biblioBezBialego.Show();
            mojProfBezBialego.Show();
            aktywBezBialego.Show();

            userControl31.BringToFront();
            userControl31.Show();

            userControl11.Hide();
            userControl21.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void biblioBezBialego_Click(object sender, EventArgs e)
        {
            bibliotekaW.Show();
            biblioBezBialego.Hide();

            statystykiW.Hide();
            zainstalowaneW.Hide();
            mojProfilW.Hide();
            aktywnoscW.Hide();

            statyBezBialego.Show();
            zainstalBezBialego.Show();
            mojProfBezBialego.Show();
            aktywBezBialego.Show();

            userControl21.BringToFront();
            userControl21.Show();

            userControl11.Hide();
            userControl31.Hide();
            mojProfil1.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void mojProfBezBialego_Click(object sender, EventArgs e)
        {
            mojProfilW.Show();
            mojProfBezBialego.Hide();

            statystykiW.Hide();
            bibliotekaW.Hide();
            zainstalowaneW.Hide();
            aktywnoscW.Hide();

            statyBezBialego.Show();
            biblioBezBialego.Show();
            zainstalBezBialego.Show();
            aktywBezBialego.Show();

            mojProfil1.BringToFront();
            mojProfil1.Show();

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            aktywnosc1.Hide();
            profilKozy1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profilKozy1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frndList_Click(object sender, EventArgs e)
        {

        }

        private void znajSearchBtn_Click(object sender, EventArgs e)
        {
            string znajinput = znajSearchTxt.Text;
            if (znajinput == "medzie")
            {
                frndSucsInfo.Text = "";
                medzieZnaj.Show();
                medzieZnaj.BringToFront();
                medzieZnajAdd.Show();
                medzieZnajAdd.BringToFront();

            }
            else
            {
                frndSucsInfo.ForeColor = Color.Red;
                frndSucsInfo.Text = "Nie znaleziono takiego u�ytkownika";
            }
        }

        private void medzieZnajAdd_Click(object sender, EventArgs e)
        {
            frndSucsInfo.ForeColor = Color.Green;
            frndSucsInfo.Text = "Pomy�lnie dodano u�ytkownika :))";
        }

        private void medzieZnaj_Click(object sender, EventArgs e)
        {

        }

        private void listaZnajSwitch_Click(object sender, EventArgs e)
        {
            listaZnajSwitch.Hide();
            frndList_add.Hide();
            znajSearchBtn.Hide();
            znajSearchTxt.Hide();

            medzieZnajAdd.Hide();
            medzieZnaj.Hide();
            frndList.Show();

            frndSucsInfo.Text = "";
        }

        private void znajSearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frndSucsInfo_Click(object sender, EventArgs e)
        {

        }
    }
    //27.02.21 - 8:50Pm - A message to all the people who decided to even think EVEN THINK about making something in Windows Forms. DON'T DO NOT JUST DON'T MAKE A WEBSITE OR SOMETHING DO NOT EVEN TRY MAKING THIS, THIS IS PAIN.

}
