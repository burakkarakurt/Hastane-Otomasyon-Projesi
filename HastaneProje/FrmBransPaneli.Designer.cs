
namespace HastaneProje
{
    partial class FrmBransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBransPaneli));
            this.Txt_BransAd = new System.Windows.Forms.TextBox();
            this.Txt_Bransid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Olustur = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_BransAd
            // 
            this.Txt_BransAd.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_BransAd.Location = new System.Drawing.Point(136, 89);
            this.Txt_BransAd.Name = "Txt_BransAd";
            this.Txt_BransAd.Size = new System.Drawing.Size(159, 27);
            this.Txt_BransAd.TabIndex = 10;
            // 
            // Txt_Bransid
            // 
            this.Txt_Bransid.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Bransid.Location = new System.Drawing.Point(136, 39);
            this.Txt_Bransid.Name = "Txt_Bransid";
            this.Txt_Bransid.Size = new System.Drawing.Size(159, 27);
            this.Txt_Bransid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Branş Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Branş İD:";
            // 
            // Btn_Olustur
            // 
            this.Btn_Olustur.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Olustur.ForeColor = System.Drawing.Color.Red;
            this.Btn_Olustur.Location = new System.Drawing.Point(110, 198);
            this.Btn_Olustur.Name = "Btn_Olustur";
            this.Btn_Olustur.Size = new System.Drawing.Size(107, 34);
            this.Btn_Olustur.TabIndex = 15;
            this.Btn_Olustur.Text = "Oluştur";
            this.Btn_Olustur.UseVisualStyleBackColor = true;
            this.Btn_Olustur.Click += new System.EventHandler(this.Btn_Olustur_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.ForeColor = System.Drawing.Color.Red;
            this.Btn_Sil.Location = new System.Drawing.Point(183, 145);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(107, 34);
            this.Btn_Sil.TabIndex = 14;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.ForeColor = System.Drawing.Color.Red;
            this.Btn_Guncelle.Location = new System.Drawing.Point(32, 145);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(107, 34);
            this.Btn_Guncelle.TabIndex = 13;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(350, 200);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 258);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Olustur);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Txt_BransAd);
            this.Controls.Add(this.Txt_Bransid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBransPaneli";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_BransAd;
        private System.Windows.Forms.TextBox Txt_Bransid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Olustur;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}