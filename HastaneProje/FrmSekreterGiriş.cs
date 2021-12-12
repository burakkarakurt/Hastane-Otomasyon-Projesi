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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        //personel giriş yapma kısmı (bu kısımda veritabanındaki tbl_sekreter tablosundan bilgiyi çeker ve sorgular.)
        //sorguladığı bilgi doğru ise giriş yapar yanlış ise hatalı kullanıcı girişi diye uyarı verir.
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())//Sorgulama yaptığımızda if'i kullanıyoruz.
            {
                //girilen sekreter giriş bilgilerini sekreter detay sayfasında sol üstte görüntülenmesini sağlayan kısım.
                FrmSekreterDetay frs = new FrmSekreterDetay();
                 frs.TCnumara = Msk_TC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı girişi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void Txt_Sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Msk_TC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmSekreterGiriş_Load(object sender, EventArgs e)
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
