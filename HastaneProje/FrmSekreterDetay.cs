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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;//tcyi çekmek için oluşturulan nesne
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            Lbl_TC.Text = TCnumara;

            //personel(sekreter) Ad Soyad Getirme
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lbl_AdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();


            //veritabanındaki tbl_branslar da ki bilgileri Datagrid'e aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar ", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //veritabanındaki tbl_doktorlar tablosundaki bilgileri datagrid'e aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+'  '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            //as atagrid'de sütun ismi eklemek için
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //veritabanındaki tbl_branslar tablosundaki bilgileri Combobox'a getirme
            SqlCommand komut1 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                Cmb_Brans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }
        //veritabanına yeni randevu bilgisi ekleme kısmı
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", Msk_Tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", Msk_Saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", Cmb_Brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", Cmb_Doktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }
        //başka branş seçildiğinde comboboxtaki diğer branş ve doktor kısmını silip yenisini koymamızı sağlayan kısım
        private void Cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", Cmb_Brans.Text);
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                Cmb_Doktor.Items.Add(dr[0] + "  " + dr[1]);
            }
            bgl.baglanti().Close();
        }
        //Yeni duyuru oluşturulma kısmı(veritabanına ekler)
        private void Btn_Olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void Btn_DoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frs = new FrmDoktorPaneli();
            frs.Show();
        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Msk_TC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_RandevuPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frb = new FrmBransPaneli();
            frb.Show();
        }

        private void Btn_RandevuListele_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş frmSekreterGiriş = new FrmSekreterGiriş();
            frmSekreterGiriş.Show();
            Hide();
        }
    }
}
