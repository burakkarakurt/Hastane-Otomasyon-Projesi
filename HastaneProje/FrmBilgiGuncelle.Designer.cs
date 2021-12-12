
namespace HastaneProje
{
    partial class FrmBilgiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiGuncelle));
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Soyad = new System.Windows.Forms.TextBox();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.ForeColor = System.Drawing.Color.Red;
            this.Btn_Guncelle.Location = new System.Drawing.Point(549, 335);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(125, 34);
            this.Btn_Guncelle.TabIndex = 30;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Cmb_Cinsiyet
            // 
            this.Cmb_Cinsiyet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmb_Cinsiyet.FormattingEnabled = true;
            this.Cmb_Cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.Cmb_Cinsiyet.Location = new System.Drawing.Point(479, 266);
            this.Cmb_Cinsiyet.Name = "Cmb_Cinsiyet";
            this.Cmb_Cinsiyet.Size = new System.Drawing.Size(195, 28);
            this.Cmb_Cinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(391, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cinsiyet:";
            // 
            // Msk_Telefon
            // 
            this.Msk_Telefon.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Msk_Telefon.Location = new System.Drawing.Point(479, 202);
            this.Msk_Telefon.Mask = "(999) 000-0000";
            this.Msk_Telefon.Name = "Msk_Telefon";
            this.Msk_Telefon.Size = new System.Drawing.Size(195, 27);
            this.Msk_Telefon.TabIndex = 4;
            // 
            // Txt_Soyad
            // 
            this.Txt_Soyad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Soyad.Location = new System.Drawing.Point(479, 127);
            this.Txt_Soyad.Name = "Txt_Soyad";
            this.Txt_Soyad.Size = new System.Drawing.Size(195, 27);
            this.Txt_Soyad.TabIndex = 2;
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Ad.Location = new System.Drawing.Point(159, 127);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(195, 27);
            this.Txt_Ad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(408, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(396, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(116, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad:";
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Sifre.Location = new System.Drawing.Point(159, 266);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(195, 27);
            this.Txt_Sifre.TabIndex = 5;
            // 
            // Msk_TC
            // 
            this.Msk_TC.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Msk_TC.Location = new System.Drawing.Point(159, 196);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(195, 31);
            this.Msk_TC.TabIndex = 3;
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(100, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(32, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(132, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(415, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "*Lütfen Güncellemek İstediğiniz Bilgileri Eksiksiz Giriniz.";
            // 
            // FrmBilgiGuncelle
            // 
            this.AcceptButton = this.Btn_Guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 421);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Cmb_Cinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Msk_Telefon);
            this.Controls.Add(this.Txt_Soyad);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBilgiGuncelle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.ComboBox Cmb_Cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Msk_Telefon;
        private System.Windows.Forms.TextBox Txt_Soyad;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}