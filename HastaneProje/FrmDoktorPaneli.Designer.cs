
namespace HastaneProje
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.Txt_Soyad = new System.Windows.Forms.TextBox();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_Brans = new System.Windows.Forms.ComboBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(38, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(44, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(52, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(106, 31);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(159, 27);
            this.Txt_Ad.TabIndex = 1;
            // 
            // Txt_Soyad
            // 
            this.Txt_Soyad.Location = new System.Drawing.Point(106, 93);
            this.Txt_Soyad.Name = "Txt_Soyad";
            this.Txt_Soyad.Size = new System.Drawing.Size(159, 27);
            this.Txt_Soyad.TabIndex = 2;
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(106, 215);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(159, 27);
            this.Msk_TC.TabIndex = 4;
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // Cmb_Brans
            // 
            this.Cmb_Brans.FormattingEnabled = true;
            this.Cmb_Brans.Location = new System.Drawing.Point(106, 148);
            this.Cmb_Brans.Name = "Cmb_Brans";
            this.Cmb_Brans.Size = new System.Drawing.Size(159, 28);
            this.Cmb_Brans.TabIndex = 3;
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(106, 274);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(159, 27);
            this.Txt_Sifre.TabIndex = 5;
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.ForeColor = System.Drawing.Color.Red;
            this.Btn_Guncelle.Location = new System.Drawing.Point(28, 331);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(107, 32);
            this.Btn_Guncelle.TabIndex = 10;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.ForeColor = System.Drawing.Color.Red;
            this.Btn_Sil.Location = new System.Drawing.Point(179, 331);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(107, 32);
            this.Btn_Sil.TabIndex = 11;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(106, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Oluştur";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 332);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Cmb_Brans);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.Txt_Soyad);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.TextBox Txt_Soyad;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.ComboBox Cmb_Brans;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}