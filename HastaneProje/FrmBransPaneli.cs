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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
           
        }
        //Veritabanına yeni branşların eklendiği kısım
        private void Btn_Olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (Bransid,BransAd) values (@b1,@b2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",Txt_Bransid.Text);
            komut.Parameters.AddWithValue("@b2", Txt_BransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //branş panelindeki kısımlara veritabanındaki branslar tablosundan veri çektiğimiz kısım
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //Veritabanından branşların silindiği kısım
        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From tbl_branslar where BransAd=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", Txt_BransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi.");
        }
        //tablodan seçilen satırdaki bilgilerin textboxa gelmesini sağlar
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txt_BransAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txt_BransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
          
        }
    }
}
