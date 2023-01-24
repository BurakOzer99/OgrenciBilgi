namespace OgrenciProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.BtnSınavKayıt = new System.Windows.Forms.Button();
            this.btnOgretmenBılgı = new System.Windows.Forms.Button();
            this.btnOgrencıKayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "YOZGAT ENDÜSTİRİ MESLEK LİSESİ ÖĞRENCİ İŞLEMLERİ";
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.Location = new System.Drawing.Point(362, 159);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(121, 83);
            this.BtnCıkıs.TabIndex = 8;
            this.BtnCıkıs.Text = "GOOD BYE";
            this.BtnCıkıs.UseVisualStyleBackColor = true;
            // 
            // BtnSınavKayıt
            // 
            this.BtnSınavKayıt.Location = new System.Drawing.Point(202, 159);
            this.BtnSınavKayıt.Name = "BtnSınavKayıt";
            this.BtnSınavKayıt.Size = new System.Drawing.Size(121, 83);
            this.BtnSınavKayıt.TabIndex = 7;
            this.BtnSınavKayıt.Text = "Sınav Notları";
            this.BtnSınavKayıt.UseVisualStyleBackColor = true;
            this.BtnSınavKayıt.Click += new System.EventHandler(this.BtnSınavKayıt_Click);
            // 
            // btnOgretmenBılgı
            // 
            this.btnOgretmenBılgı.Location = new System.Drawing.Point(362, 70);
            this.btnOgretmenBılgı.Name = "btnOgretmenBılgı";
            this.btnOgretmenBılgı.Size = new System.Drawing.Size(121, 83);
            this.btnOgretmenBılgı.TabIndex = 6;
            this.btnOgretmenBılgı.Text = "Öğretmen Bilgiler";
            this.btnOgretmenBılgı.UseVisualStyleBackColor = true;
            this.btnOgretmenBılgı.Click += new System.EventHandler(this.btnOgretmenBılgı_Click);
            // 
            // btnOgrencıKayıt
            // 
            this.btnOgrencıKayıt.Location = new System.Drawing.Point(202, 70);
            this.btnOgrencıKayıt.Name = "btnOgrencıKayıt";
            this.btnOgrencıKayıt.Size = new System.Drawing.Size(121, 83);
            this.btnOgrencıKayıt.TabIndex = 5;
            this.btnOgrencıKayıt.Text = "Öğrenci Kayıt";
            this.btnOgrencıKayıt.UseVisualStyleBackColor = true;
            this.btnOgrencıKayıt.Click += new System.EventHandler(this.btnOgrencıKayıt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.BtnSınavKayıt);
            this.Controls.Add(this.btnOgretmenBılgı);
            this.Controls.Add(this.btnOgrencıKayıt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnCıkıs;
        public System.Windows.Forms.Button BtnSınavKayıt;
        public System.Windows.Forms.Button btnOgretmenBılgı;
        public System.Windows.Forms.Button btnOgrencıKayıt;
    }
}

