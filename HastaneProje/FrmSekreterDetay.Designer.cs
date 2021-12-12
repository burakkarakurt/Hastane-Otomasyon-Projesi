
namespace HastaneProje
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_AdSoyad = new System.Windows.Forms.Label();
            this.Lbl_TC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Olustur = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_Doktor = new System.Windows.Forms.ComboBox();
            this.Cmb_Brans = new System.Windows.Forms.ComboBox();
            this.Msk_Saat = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_RandevuListele = new System.Windows.Forms.Button();
            this.Btn_RandevuPaneli = new System.Windows.Forms.Button();
            this.Btn_DoktorPaneli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Lbl_AdSoyad);
            this.groupBox1.Controls.Add(this.Lbl_TC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgi";
            // 
            // Lbl_AdSoyad
            // 
            this.Lbl_AdSoyad.AutoSize = true;
            this.Lbl_AdSoyad.BackColor = System.Drawing.Color.White;
            this.Lbl_AdSoyad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_AdSoyad.Location = new System.Drawing.Point(140, 119);
            this.Lbl_AdSoyad.Name = "Lbl_AdSoyad";
            this.Lbl_AdSoyad.Size = new System.Drawing.Size(99, 20);
            this.Lbl_AdSoyad.TabIndex = 3;
            this.Lbl_AdSoyad.Text = "NULL NULL";
            // 
            // Lbl_TC
            // 
            this.Lbl_TC.AutoSize = true;
            this.Lbl_TC.BackColor = System.Drawing.Color.White;
            this.Lbl_TC.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TC.Location = new System.Drawing.Point(140, 62);
            this.Lbl_TC.Name = "Lbl_TC";
            this.Lbl_TC.Size = new System.Drawing.Size(119, 20);
            this.Lbl_TC.TabIndex = 2;
            this.Lbl_TC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Btn_Olustur);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // Btn_Olustur
            // 
            this.Btn_Olustur.Location = new System.Drawing.Point(16, 283);
            this.Btn_Olustur.Name = "Btn_Olustur";
            this.Btn_Olustur.Size = new System.Drawing.Size(269, 38);
            this.Btn_Olustur.TabIndex = 1;
            this.Btn_Olustur.Text = "Oluştur";
            this.Btn_Olustur.UseVisualStyleBackColor = true;
            this.Btn_Olustur.Click += new System.EventHandler(this.Btn_Olustur_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 236);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Btn_Güncelle);
            this.groupBox3.Controls.Add(this.Btn_Kaydet);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.Msk_TC);
            this.groupBox3.Controls.Add(this.Cmb_Doktor);
            this.groupBox3.Controls.Add(this.Cmb_Brans);
            this.groupBox3.Controls.Add(this.Msk_Saat);
            this.groupBox3.Controls.Add(this.Msk_Tarih);
            this.groupBox3.Controls.Add(this.Txt_id);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(329, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 445);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.Location = new System.Drawing.Point(19, 394);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(281, 35);
            this.Btn_Güncelle.TabIndex = 17;
            this.Btn_Güncelle.Text = "Güncelle";
            this.Btn_Güncelle.UseVisualStyleBackColor = true;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(19, 353);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(281, 35);
            this.Btn_Kaydet.TabIndex = 16;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(166, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Randevu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(166, 319);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(148, 27);
            this.Msk_TC.TabIndex = 15;
            this.Msk_TC.ValidatingType = typeof(int);
            this.Msk_TC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_TC_MaskInputRejected);
            // 
            // Cmb_Doktor
            // 
            this.Cmb_Doktor.FormattingEnabled = true;
            this.Cmb_Doktor.Location = new System.Drawing.Point(166, 241);
            this.Cmb_Doktor.Name = "Cmb_Doktor";
            this.Cmb_Doktor.Size = new System.Drawing.Size(148, 28);
            this.Cmb_Doktor.TabIndex = 14;
            // 
            // Cmb_Brans
            // 
            this.Cmb_Brans.FormattingEnabled = true;
            this.Cmb_Brans.Location = new System.Drawing.Point(166, 194);
            this.Cmb_Brans.Name = "Cmb_Brans";
            this.Cmb_Brans.Size = new System.Drawing.Size(148, 28);
            this.Cmb_Brans.TabIndex = 13;
            this.Cmb_Brans.SelectedIndexChanged += new System.EventHandler(this.Cmb_Brans_SelectedIndexChanged);
            // 
            // Msk_Saat
            // 
            this.Msk_Saat.Location = new System.Drawing.Point(166, 136);
            this.Msk_Saat.Mask = "00:00";
            this.Msk_Saat.Name = "Msk_Saat";
            this.Msk_Saat.Size = new System.Drawing.Size(148, 27);
            this.Msk_Saat.TabIndex = 12;
            this.Msk_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // Msk_Tarih
            // 
            this.Msk_Tarih.Location = new System.Drawing.Point(166, 78);
            this.Msk_Tarih.Mask = "00/00/0000";
            this.Msk_Tarih.Name = "Msk_Tarih";
            this.Msk_Tarih.Size = new System.Drawing.Size(148, 27);
            this.Msk_Tarih.TabIndex = 11;
            this.Msk_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(166, 21);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(148, 27);
            this.Txt_id.TabIndex = 10;
            this.Txt_id.TextChanged += new System.EventHandler(this.Txt_id_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(123, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "TC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Randevu Durumu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(90, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(98, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(107, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(103, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "id:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(666, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 218);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branş Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(345, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(666, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 349);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktor Listesi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(345, 323);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.Btn_RandevuListele);
            this.groupBox6.Controls.Add(this.Btn_RandevuPaneli);
            this.groupBox6.Controls.Add(this.Btn_DoktorPaneli);
            this.groupBox6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(329, 472);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(320, 130);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // Btn_RandevuListele
            // 
            this.Btn_RandevuListele.Location = new System.Drawing.Point(79, 81);
            this.Btn_RandevuListele.Name = "Btn_RandevuListele";
            this.Btn_RandevuListele.Size = new System.Drawing.Size(149, 32);
            this.Btn_RandevuListele.TabIndex = 2;
            this.Btn_RandevuListele.Text = "Randevu Listele";
            this.Btn_RandevuListele.UseVisualStyleBackColor = true;
            this.Btn_RandevuListele.Click += new System.EventHandler(this.Btn_RandevuListele_Click);
            // 
            // Btn_RandevuPaneli
            // 
            this.Btn_RandevuPaneli.Location = new System.Drawing.Point(160, 26);
            this.Btn_RandevuPaneli.Name = "Btn_RandevuPaneli";
            this.Btn_RandevuPaneli.Size = new System.Drawing.Size(149, 32);
            this.Btn_RandevuPaneli.TabIndex = 1;
            this.Btn_RandevuPaneli.Text = "Randevu Paneli";
            this.Btn_RandevuPaneli.UseVisualStyleBackColor = true;
            this.Btn_RandevuPaneli.Click += new System.EventHandler(this.Btn_RandevuPaneli_Click);
            // 
            // Btn_DoktorPaneli
            // 
            this.Btn_DoktorPaneli.Location = new System.Drawing.Point(22, 26);
            this.Btn_DoktorPaneli.Name = "Btn_DoktorPaneli";
            this.Btn_DoktorPaneli.Size = new System.Drawing.Size(130, 32);
            this.Btn_DoktorPaneli.TabIndex = 0;
            this.Btn_DoktorPaneli.Text = "Doktor Paneli";
            this.Btn_DoktorPaneli.UseVisualStyleBackColor = true;
            this.Btn_DoktorPaneli.Click += new System.EventHandler(this.Btn_DoktorPaneli_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 544);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSekreterDetay";
            this.Text = "Personel Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_AdSoyad;
        private System.Windows.Forms.Label Lbl_TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Olustur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.ComboBox Cmb_Doktor;
        private System.Windows.Forms.ComboBox Cmb_Brans;
        private System.Windows.Forms.MaskedTextBox Msk_Saat;
        private System.Windows.Forms.MaskedTextBox Msk_Tarih;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Btn_RandevuListele;
        private System.Windows.Forms.Button Btn_RandevuPaneli;
        private System.Windows.Forms.Button Btn_DoktorPaneli;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}