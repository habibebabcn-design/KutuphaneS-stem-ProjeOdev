namespace KutuphaneSıstemıProjeOdev
{
    partial class FrmUyeEkle
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
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.colGüncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemızle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAramaSoyad = new System.Windows.Forms.TextBox();
            this.txtAramaAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBaslngc = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictFoto = new System.Windows.Forms.PictureBox();
            this.buttonFotoSec = new System.Windows.Forms.Button();
            this.txtFotoYolu = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGüncelle,
            this.colSil});
            this.dgvUyeler.Location = new System.Drawing.Point(12, 236);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.RowHeadersWidth = 51;
            this.dgvUyeler.RowTemplate.Height = 24;
            this.dgvUyeler.Size = new System.Drawing.Size(663, 282);
            this.dgvUyeler.TabIndex = 0;
            this.dgvUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellClick);
            this.dgvUyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellContentClick);
            // 
            // colGüncelle
            // 
            this.colGüncelle.HeaderText = "Güncelle";
            this.colGüncelle.MinimumWidth = 6;
            this.colGüncelle.Name = "colGüncelle";
            this.colGüncelle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGüncelle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGüncelle.Text = "Güncelle";
            this.colGüncelle.Width = 80;
            // 
            // colSil
            // 
            this.colSil.HeaderText = "Sil";
            this.colSil.MinimumWidth = 6;
            this.colSil.Name = "colSil";
            this.colSil.ToolTipText = "Sil";
            this.colSil.Width = 60;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(845, 320);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(174, 24);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(845, 250);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(174, 24);
            this.txtAd.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEkle.Location = new System.Drawing.Point(849, 462);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(162, 46);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemızle
            // 
            this.btnTemızle.BackColor = System.Drawing.Color.MistyRose;
            this.btnTemızle.Location = new System.Drawing.Point(849, 544);
            this.btnTemızle.Name = "btnTemızle";
            this.btnTemızle.Size = new System.Drawing.Size(162, 45);
            this.btnTemızle.TabIndex = 9;
            this.btnTemızle.Text = "Temizle";
            this.btnTemızle.UseVisualStyleBackColor = false;
            this.btnTemızle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(784, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(763, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(761, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAramaSoyad);
            this.groupBox1.Controls.Add(this.txtAramaAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimeBitis);
            this.groupBox1.Controls.Add(this.dateTimeBaslngc);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnArama);
            this.groupBox1.Location = new System.Drawing.Point(32, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 174);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaylı Arama";
            // 
            // txtAramaSoyad
            // 
            this.txtAramaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaSoyad.Location = new System.Drawing.Point(76, 100);
            this.txtAramaSoyad.Name = "txtAramaSoyad";
            this.txtAramaSoyad.Size = new System.Drawing.Size(243, 30);
            this.txtAramaSoyad.TabIndex = 32;
            // 
            // txtAramaAd
            // 
            this.txtAramaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaAd.Location = new System.Drawing.Point(76, 47);
            this.txtAramaAd.Name = "txtAramaAd";
            this.txtAramaAd.Size = new System.Drawing.Size(243, 30);
            this.txtAramaAd.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(205, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kayıt Tarihi:";
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Location = new System.Drawing.Point(247, 151);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(87, 22);
            this.dateTimeBitis.TabIndex = 21;
            // 
            // dateTimeBaslngc
            // 
            this.dateTimeBaslngc.Location = new System.Drawing.Point(112, 151);
            this.dateTimeBaslngc.Name = "dateTimeBaslngc";
            this.dateTimeBaslngc.Size = new System.Drawing.Size(87, 22);
            this.dateTimeBaslngc.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(358, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 22);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "AktifMi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnArama.Location = new System.Drawing.Point(438, 75);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(152, 50);
            this.btnArama.TabIndex = 18;
            this.btnArama.Text = "Arama";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPdf.Location = new System.Drawing.Point(247, 563);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 35);
            this.btnPdf.TabIndex = 28;
            this.btnPdf.Text = "Pdf Al";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExcel.Location = new System.Drawing.Point(390, 563);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(73, 35);
            this.btnExcel.TabIndex = 29;
            this.btnExcel.Text = "Excel Al";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictFoto
            // 
            this.pictFoto.Location = new System.Drawing.Point(886, 22);
            this.pictFoto.Name = "pictFoto";
            this.pictFoto.Size = new System.Drawing.Size(133, 139);
            this.pictFoto.TabIndex = 30;
            this.pictFoto.TabStop = false;
            // 
            // buttonFotoSec
            // 
            this.buttonFotoSec.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonFotoSec.Location = new System.Drawing.Point(766, 65);
            this.buttonFotoSec.Name = "buttonFotoSec";
            this.buttonFotoSec.Size = new System.Drawing.Size(107, 38);
            this.buttonFotoSec.TabIndex = 31;
            this.buttonFotoSec.Text = "Fotoğraf Seç";
            this.buttonFotoSec.UseVisualStyleBackColor = false;
            this.buttonFotoSec.Click += new System.EventHandler(this.buttonFotoSec_Click);
            // 
            // txtFotoYolu
            // 
            this.txtFotoYolu.Location = new System.Drawing.Point(668, 124);
            this.txtFotoYolu.Name = "txtFotoYolu";
            this.txtFotoYolu.ReadOnly = true;
            this.txtFotoYolu.Size = new System.Drawing.Size(212, 22);
            this.txtFotoYolu.TabIndex = 24;
            this.txtFotoYolu.Visible = false;
            this.txtFotoYolu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(845, 396);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(174, 24);
            this.txtTelefon.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(694, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "TC Kimlik No";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(845, 183);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(174, 24);
            this.txtTcNo.TabIndex = 1;
            // 
            // FrmUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1050, 611);
            this.Controls.Add(this.txtFotoYolu);
            this.Controls.Add(this.buttonFotoSec);
            this.Controls.Add(this.pictFoto);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUyeler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnTemızle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.btnEkle);
            this.Name = "FrmUyeEkle";
            this.Text = "FrmUyeEkle";
            this.Load += new System.EventHandler(this.FrmUyeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemızle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBaslngc;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictFoto;
        private System.Windows.Forms.Button buttonFotoSec;
        private System.Windows.Forms.TextBox txtFotoYolu;
        private System.Windows.Forms.DataGridViewButtonColumn colGüncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSil;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtAramaSoyad;
        private System.Windows.Forms.TextBox txtAramaAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}