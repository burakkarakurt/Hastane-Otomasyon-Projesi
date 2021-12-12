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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti baglan = new SqlBaglanti();// sql bağlantımız.
        //veritabanından hasta Ad soyad çekme kısmı
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();// Okuma parametremizi çağırıyoruz.
            while (dr.Read())//Bir şeyi listelemek istediğimizde while kullanıyoruz.
            {
                Lbl_Ad_Soyad.Text = dr[0] + "  " + dr[1];//0. sütun ile 1. sütunu yazıyoruz.(Ad ve soyadı yani)

            }
            baglan.baglanti().Close();
            //Rnadevu Geçmişi kısmı için veritabanındaki tbl_randevular tablosundan bilgileri çekiyoruz.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, baglan.baglanti());
            da.Fill(dt);// da'yı dt'den gelen değerle doldur.
            dataGridView1.DataSource = dt; //Datageriview'in kaynağı dt'den gelen değerlerdir.
            //datagrid'de bağlantı açıp kapamaya gerek yok.

            //veritabanından Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", baglan.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            baglan.baglanti().Close();
        }

        //Hasta istediği branşı seçtiğinde o branşa ait doktorların combobox'ta çıktığı kısım.
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();//Önce combobox'taki doktor isimleri temizlensin sonra branş seçtikten sonra doktolar listelensin.
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", baglan.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + "  " + dr[1]);
            }
            baglan.baglanti().Close();
        }

        // Branş ve doktor seçildikten sonra datagrid'de aktif randevular çıksın.
        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans= '" + CmbBrans.Text+ "'" ,baglan.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        //bilgilerini güncelle linklabelına tıklayınca bilgi güncelle panelini getirdiğimiz kısım 
        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiGuncelle fr = new FrmBilgiGuncelle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_RandevuAl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
            frmHastaGiris.Show();
            Hide();
        }
    }
}
