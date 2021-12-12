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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        SqlBaglanti bgl = new SqlBaglanti();// Sınıfımzdaki bağlantıyı çağırmak için
        //kayıt olma kısmındaki textboxlara girilen bilgileri veritabanına eklediğimiz kısım.
        private void Btn_KayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);//textbox'tan gelen değeri p1'e p1 dekini veir tabanına ekle.
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();// Bağlantıyı kapatmak için
            MessageBox.Show("Kayıt işlemi gerçekleşti.Şifreniz:" + TxtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Messagebox'ta parametre yazılış sırası:messagebox un içine yazılacak mesaj,başlık,butonunda ne olacağı,ikon seçimi
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmHastaKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
