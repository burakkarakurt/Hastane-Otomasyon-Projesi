using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //seçilen pictureboxlar'a uygun panellerin açılmasını sağlayan kısımlar.
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmDoktorGiris frd = new FrmDoktorGiris();
            frd.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş frs = new FrmSekreterGiriş();
            frs.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }
    }
}
