
namespace HastaneProje
{
    partial class FrmSekreterGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiriş));
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.ForeColor = System.Drawing.Color.Red;
            this.Btn_Giris.Location = new System.Drawing.Point(248, 238);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(101, 32);
            this.Btn_Giris.TabIndex = 12;
            this.Btn_Giris.Text = "Giriş";
            this.Btn_Giris.UseVisualStyleBackColor = true;
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(196, 192);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(153, 27);
            this.Txt_Sifre.TabIndex = 11;
            this.Txt_Sifre.Text = "1234";
            this.Txt_Sifre.UseSystemPasswordChar = true;
            this.Txt_Sifre.TextChanged += new System.EventHandler(this.Txt_Sifre_TextChanged);
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(196, 142);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(153, 27);
            this.Msk_TC.TabIndex = 10;
            this.Msk_TC.Text = "44444444444";
            this.Msk_TC.ValidatingType = typeof(int);
            this.Msk_TC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_TC_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(130, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personel Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmSekreterGiriş
            // 
            this.AcceptButton = this.Btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Giris);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiriş";
            this.Text = "Personel Girişi";
            this.Load += new System.EventHandler(this.FrmSekreterGiriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Giris;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}