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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        //üye ol linklabelına tıklayınca üye olma panelini açtığımız kısım.
        private void Lnk_UyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
        }
        
        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {
           
        }
        //giriş butonuna tıkladıktan sonra eğer giriş bilgileri doğruysa doktor detay sayfasına girme kısmı
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();// Komuttan gelen değerleri oku
            if (dr.Read())// Okuma işlemi doğru gerçekleşirse yani ekranda girilen değerler ile veri tabanındaki değerler aynı ise if içine gircek.
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = Msk_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi!");
            }
            bgl.baglanti().Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            Hide();
        }
    }
}
