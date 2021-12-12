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
    public partial class FrmBilgiGuncelle : Form
    {
        public FrmBilgiGuncelle()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmBilgiGuncelle_Load(object sender, EventArgs e)
        {
            Msk_TC.Text = TCno;//Forma hasta detayda ki tcyi aktarıyoruz.
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //Güncelleme ekranı açıldığında her bilginin doğru textboxa otomotik olarak yazılmasını sağlıyoruz.
                Txt_Ad.Text = dr[1].ToString();
                Txt_Soyad.Text = dr[2].ToString();
                Msk_Telefon.Text = dr[4].ToString();
                Txt_Sifre.Text = dr[5].ToString();
                Cmb_Cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        //Güncellenen Bilgilerin veritabanına güncel halini kaydediyoruz.
        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", Txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3", Msk_Telefon.Text);
            komut2.Parameters.AddWithValue ("@p4",Txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@p5", Cmb_Cinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", Msk_TC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}
