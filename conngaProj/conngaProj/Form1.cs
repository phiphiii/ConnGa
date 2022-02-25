using System.Runtime.InteropServices;

namespace conngaProj
{
    public partial class ConnGa : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
              int nLeft
            , int nTop
            , int nRight
            , int nBottom
            , int nWidthEllipse
            , int nHeightEllipse
            );
        public ConnGa()
        {
            InitializeComponent();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            stat_actv.Hide();
            install_actv.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,button1.Height, 30, 30));
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

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
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
            stat_actv.Show();
            install_actv.Hide();
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
            stat_actv.Hide();
            install_actv.Show();
            userControl21.Show();
            userControl21.BringToFront();
        }
    }


}
