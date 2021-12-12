using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneProje
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Btn_CikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_BilgiDuzenle_Click(object sender, EventArgs e)
        {

        }
        //FrmDuyurular sayfasını açar.
        private void Btn_Duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
        public string TC;//TC yi çekmemizi sağlayan nesne
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            Lbl_TC.Text = TC;

            //Doktorun kendisine ait randevuların ad ve soyadına göre veritabanındaki tablosundan çekildiği kısım
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmDoktorGiris = new FrmDoktorGiris();
            frmDoktorGiris.Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
