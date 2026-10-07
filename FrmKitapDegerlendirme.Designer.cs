namespace KutuphaneSıstemıProjeOdev
{
    partial class FrmKitapDegerlendirme
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
            this.flpKitaplar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAraAd = new System.Windows.Forms.TextBox();
            this.txtAraSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpKitaplar
            // 
            this.flpKitaplar.AutoScroll = true;
            this.flpKitaplar.Location = new System.Drawing.Point(34, 178);
            this.flpKitaplar.Name = "flpKitaplar";
            this.flpKitaplar.Size = new System.Drawing.Size(716, 268);
            this.flpKitaplar.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAra.Location = new System.Drawing.Point(539, 67);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(162, 44);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(262, 464);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(254, 70);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAraAd
            // 
            this.txtAraAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraAd.Location = new System.Drawing.Point(173, 45);
            this.txtAraAd.Name = "txtAraAd";
            this.txtAraAd.Size = new System.Drawing.Size(287, 30);
            this.txtAraAd.TabIndex = 3;
            // 
            // txtAraSoyad
            // 
            this.txtAraSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraSoyad.Location = new System.Drawing.Point(173, 111);
            this.txtAraSoyad.Name = "txtAraSoyad";
            this.txtAraSoyad.Size = new System.Drawing.Size(287, 30);
            this.txtAraSoyad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // FrmKitapDegerlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAraSoyad);
            this.Controls.Add(this.txtAraAd);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.flpKitaplar);
            this.Name = "FrmKitapDegerlendirme";
            this.Text = "FrmKitapDegerlendirme";
            this.Load += new System.EventHandler(this.FrmKitapDegerlendirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpKitaplar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAraAd;
        private System.Windows.Forms.TextBox txtAraSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}