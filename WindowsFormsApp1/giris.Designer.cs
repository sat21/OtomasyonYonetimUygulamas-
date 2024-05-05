namespace WindowsFormsApp1
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.bunifuTileButtonCalisan = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButtonYonetici = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // bunifuTileButtonCalisan
            // 
            this.bunifuTileButtonCalisan.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButtonCalisan.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButtonCalisan.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButtonCalisan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButtonCalisan.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButtonCalisan.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButtonCalisan.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButtonCalisan.Image")));
            this.bunifuTileButtonCalisan.ImagePosition = 20;
            this.bunifuTileButtonCalisan.ImageZoom = 50;
            this.bunifuTileButtonCalisan.LabelPosition = 41;
            this.bunifuTileButtonCalisan.LabelText = "Çalışan";
            this.bunifuTileButtonCalisan.Location = new System.Drawing.Point(264, 44);
            this.bunifuTileButtonCalisan.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButtonCalisan.Name = "bunifuTileButtonCalisan";
            this.bunifuTileButtonCalisan.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButtonCalisan.TabIndex = 0;
            this.bunifuTileButtonCalisan.Click += new System.EventHandler(this.bunifuTileButtonCalisan_Click);
            // 
            // bunifuTileButtonYonetici
            // 
            this.bunifuTileButtonYonetici.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTileButtonYonetici.color = System.Drawing.Color.DodgerBlue;
            this.bunifuTileButtonYonetici.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.bunifuTileButtonYonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButtonYonetici.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButtonYonetici.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButtonYonetici.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButtonYonetici.Image")));
            this.bunifuTileButtonYonetici.ImagePosition = 20;
            this.bunifuTileButtonYonetici.ImageZoom = 50;
            this.bunifuTileButtonYonetici.LabelPosition = 41;
            this.bunifuTileButtonYonetici.LabelText = "Yönetici";
            this.bunifuTileButtonYonetici.Location = new System.Drawing.Point(45, 44);
            this.bunifuTileButtonYonetici.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButtonYonetici.Name = "bunifuTileButtonYonetici";
            this.bunifuTileButtonYonetici.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButtonYonetici.TabIndex = 1;
            this.bunifuTileButtonYonetici.Click += new System.EventHandler(this.bunifuTileButtonYonetici_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 225);
            this.Controls.Add(this.bunifuTileButtonYonetici);
            this.Controls.Add(this.bunifuTileButtonCalisan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.Text = "Giriş";
            
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonCalisan;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonYonetici;
    }
}

