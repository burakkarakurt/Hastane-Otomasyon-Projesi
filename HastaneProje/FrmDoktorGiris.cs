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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        //belirlenen tc ve şifre ile  doktorun kendine ait detay sayfasına girmesini sağlar. 
        //Girilen yanlış bilgler sonucunda doktor,kendine ait sayfaya giriş yapamaz.!
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                //doktor tc sini doktor detay sayfasına taşıyor.
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = Msk_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
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
