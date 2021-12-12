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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //veritabanındaki tbl_doktorlar tablosundan verimizi çekiyoruz.
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Combobox'a branşları getirme
            SqlCommand komut1 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                Cmb_Brans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }
        //doktor ekleme kısmı
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", Cmb_Brans.Text);
            komut.Parameters.AddWithValue("@p4", Msk_TC.Text);
            komut.Parameters.AddWithValue("@p5", Txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //tabloda seçilen doktoru sol kısımdaki texboxa doldurma kısmı
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Doktor panelinde datage-rind'deki bir doktoara basınca hemen soldaki kısma gelsin bilgiler.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//Hücrenin 0. sütununa göre satır ineexi al.
            Txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();//datagrid'de seçilen satırın hücereleri içinde 1.hücresi
            Txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Cmb_Brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Msk_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
        //doktor panelindeki doktoru sil butonuna tıklayınca veritabından sildiği kısım
        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt başarıyla silindi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        //veritabanında değiştirilmek istenen bilgiler değiştirilerek güncelleme işleminin yapıldığı kısım.
        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@d2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d3", Cmb_Brans.Text);
            komut.Parameters.AddWithValue("@d4", Msk_TC.Text);
            komut.Parameters.AddWithValue("@d5", Txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
