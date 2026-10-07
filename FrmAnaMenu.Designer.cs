namespace KutuphaneSıstemıProjeOdev
{
    partial class FrmAnaMenu
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
            this.BtnUyeEkle = new System.Windows.Forms.Button();
            this.BtnKullaniciYonetim = new System.Windows.Forms.Button();
            this.BtnKıtapEkle = new System.Windows.Forms.Button();
            this.BtnOduncislem = new System.Windows.Forms.Button();
            this.btnKitapDegerlendirme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUyeEkle
            // 
            this.BtnUyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeEkle.Location = new System.Drawing.Point(80, 25);
            this.BtnUyeEkle.Name = "BtnUyeEkle";
            this.BtnUyeEkle.Size = new System.Drawing.Size(532, 112);
            this.BtnUyeEkle.TabIndex = 0;
            this.BtnUyeEkle.Text = "Üye Ekle";
            this.BtnUyeEkle.UseVisualStyleBackColor = true;
            this.BtnUyeEkle.Click += new System.EventHandler(this.BtnUyeEkle_Click);
            // 
            // BtnKullaniciYonetim
            // 
            this.BtnKullaniciYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKullaniciYonetim.Location = new System.Drawing.Point(80, 261);
            this.BtnKullaniciYonetim.Name = "BtnKullaniciYonetim";
            this.BtnKullaniciYonetim.Size = new System.Drawing.Size(532, 125);
            this.BtnKullaniciYonetim.TabIndex = 3;
            this.BtnKullaniciYonetim.Text = "Kullanıcı İşlemleri";
            this.BtnKullaniciYonetim.UseVisualStyleBackColor = true;
            this.BtnKullaniciYonetim.Click += new System.EventHandler(this.BtnKullaniciYonetim_Click);
            // 
            // BtnKıtapEkle
            // 
            this.BtnKıtapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKıtapEkle.Location = new System.Drawing.Point(80, 143);
            this.BtnKıtapEkle.Name = "BtnKıtapEkle";
            this.BtnKıtapEkle.Size = new System.Drawing.Size(532, 112);
            this.BtnKıtapEkle.TabIndex = 4;
            this.BtnKıtapEkle.Text = "Kitap Ekle";
            this.BtnKıtapEkle.UseVisualStyleBackColor = true;
            this.BtnKıtapEkle.Click += new System.EventHandler(this.BtnKıtapEkle_Click);
            // 
            // BtnOduncislem
            // 
            this.BtnOduncislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOduncislem.Location = new System.Drawing.Point(80, 392);
            this.BtnOduncislem.Name = "BtnOduncislem";
            this.BtnOduncislem.Size = new System.Drawing.Size(532, 118);
            this.BtnOduncislem.TabIndex = 5;
            this.BtnOduncislem.Text = "Ödünç İşlemleri";
            this.BtnOduncislem.UseVisualStyleBackColor = true;
            this.BtnOduncislem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKitapDegerlendirme
            // 
            this.btnKitapDegerlendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapDegerlendirme.Location = new System.Drawing.Point(80, 516);
            this.btnKitapDegerlendirme.Name = "btnKitapDegerlendirme";
            this.btnKitapDegerlendirme.Size = new System.Drawing.Size(532, 130);
            this.btnKitapDegerlendirme.TabIndex = 6;
            this.btnKitapDegerlendirme.Text = "Kitap Değerlendirme/Kondisyon İşlemleri";
            this.btnKitapDegerlendirme.UseVisualStyleBackColor = true;
            this.btnKitapDegerlendirme.Click += new System.EventHandler(this.btnKitapDegerlendirme_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 674);
            this.Controls.Add(this.btnKitapDegerlendirme);
            this.Controls.Add(this.BtnOduncislem);
            this.Controls.Add(this.BtnKıtapEkle);
            this.Controls.Add(this.BtnKullaniciYonetim);
            this.Controls.Add(this.BtnUyeEkle);
            this.Name = "FrmAnaMenu";
            this.Text = "f77f7";
            this.Load += new System.EventHandler(this.FrmAnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUyeEkle;
        private System.Windows.Forms.Button BtnKullaniciYonetim;
        private System.Windows.Forms.Button BtnKıtapEkle;
        private System.Windows.Forms.Button BtnOduncislem;
        private System.Windows.Forms.Button btnKitapDegerlendirme;
    }
}