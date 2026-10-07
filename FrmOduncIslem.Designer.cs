namespace KutuphaneSıstemıProjeOdev
{
    partial class FrmOduncIslem
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
            this.comboBoxUye = new System.Windows.Forms.ComboBox();
            this.comboBoxKıtap = new System.Windows.Forms.ComboBox();
            this.btnödünc = new System.Windows.Forms.Button();
            this.btnIade = new System.Windows.Forms.Button();
            this.dgvOdunc = new System.Windows.Forms.DataGridView();
            this.txtUyeAra = new System.Windows.Forms.TextBox();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.pnlAktif = new System.Windows.Forms.Panel();
            this.btnAktifOdünc = new System.Windows.Forms.Button();
            this.pnlGecmis = new System.Windows.Forms.Panel();
            this.dgvGecmis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdunc)).BeginInit();
            this.pnlAktif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUye
            // 
            this.comboBoxUye.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxUye.FormattingEnabled = true;
            this.comboBoxUye.Location = new System.Drawing.Point(511, 186);
            this.comboBoxUye.Name = "comboBoxUye";
            this.comboBoxUye.Size = new System.Drawing.Size(236, 30);
            this.comboBoxUye.TabIndex = 0;
            this.comboBoxUye.Text = "Üye Seç";
            // 
            // comboBoxKıtap
            // 
            this.comboBoxKıtap.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxKıtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKıtap.FormattingEnabled = true;
            this.comboBoxKıtap.Location = new System.Drawing.Point(511, 117);
            this.comboBoxKıtap.Name = "comboBoxKıtap";
            this.comboBoxKıtap.Size = new System.Drawing.Size(236, 30);
            this.comboBoxKıtap.TabIndex = 1;
            this.comboBoxKıtap.Text = "Kitap Seç";
            // 
            // btnödünc
            // 
            this.btnödünc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnödünc.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnödünc.Location = new System.Drawing.Point(741, 191);
            this.btnödünc.Name = "btnödünc";
            this.btnödünc.Size = new System.Drawing.Size(193, 44);
            this.btnödünc.TabIndex = 2;
            this.btnödünc.Text = "Ödünç Ver";
            this.btnödünc.UseVisualStyleBackColor = false;
            this.btnödünc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // btnIade
            // 
            this.btnIade.BackColor = System.Drawing.Color.Salmon;
            this.btnIade.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIade.Location = new System.Drawing.Point(743, 338);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(184, 47);
            this.btnIade.TabIndex = 4;
            this.btnIade.Text = "İade Al";
            this.btnIade.UseVisualStyleBackColor = false;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // dgvOdunc
            // 
            this.dgvOdunc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdunc.Location = new System.Drawing.Point(10, 254);
            this.dgvOdunc.Name = "dgvOdunc";
            this.dgvOdunc.RowHeadersWidth = 51;
            this.dgvOdunc.RowTemplate.Height = 24;
            this.dgvOdunc.Size = new System.Drawing.Size(737, 289);
            this.dgvOdunc.TabIndex = 5;
            this.dgvOdunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdunc_CellClick);
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUyeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeAra.Location = new System.Drawing.Point(91, 116);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(237, 27);
            this.txtUyeAra.TabIndex = 6;
            this.txtUyeAra.TextChanged += new System.EventHandler(this.txtUyeAra_TextChanged);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtKitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAra.Location = new System.Drawing.Point(92, 189);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(236, 27);
            this.txtKitapAra.TabIndex = 7;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Üye Ara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kitap Ara:";
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackColor = System.Drawing.Color.LightGreen;
            this.btnGecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmis.Location = new System.Drawing.Point(1090, 24);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(184, 48);
            this.btnGecmis.TabIndex = 10;
            this.btnGecmis.Text = "Geçmiş Kayıtlar";
            this.btnGecmis.UseVisualStyleBackColor = false;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // pnlAktif
            // 
            this.pnlAktif.Controls.Add(this.btnIade);
            this.pnlAktif.Controls.Add(this.btnödünc);
            this.pnlAktif.Location = new System.Drawing.Point(10, 107);
            this.pnlAktif.Name = "pnlAktif";
            this.pnlAktif.Size = new System.Drawing.Size(937, 436);
            this.pnlAktif.TabIndex = 12;
            // 
            // btnAktifOdünc
            // 
            this.btnAktifOdünc.BackColor = System.Drawing.Color.LightGreen;
            this.btnAktifOdünc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktifOdünc.Location = new System.Drawing.Point(382, 24);
            this.btnAktifOdünc.Name = "btnAktifOdünc";
            this.btnAktifOdünc.Size = new System.Drawing.Size(184, 48);
            this.btnAktifOdünc.TabIndex = 13;
            this.btnAktifOdünc.Text = "Aktif Ödünçler";
            this.btnAktifOdünc.UseVisualStyleBackColor = false;
            this.btnAktifOdünc.Click += new System.EventHandler(this.btnAktifOdünc_Click);
            // 
            // pnlGecmis
            // 
            this.pnlGecmis.Location = new System.Drawing.Point(953, 107);
            this.pnlGecmis.Name = "pnlGecmis";
            this.pnlGecmis.Size = new System.Drawing.Size(497, 436);
            this.pnlGecmis.TabIndex = 14;
            // 
            // dgvGecmis
            // 
            this.dgvGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmis.Location = new System.Drawing.Point(971, 254);
            this.dgvGecmis.Name = "dgvGecmis";
            this.dgvGecmis.RowHeadersWidth = 51;
            this.dgvGecmis.RowTemplate.Height = 24;
            this.dgvGecmis.Size = new System.Drawing.Size(462, 289);
            this.dgvGecmis.TabIndex = 15;
            this.dgvGecmis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdunc_CellClick);
            // 
            // FrmOduncIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 643);
            this.Controls.Add(this.dgvGecmis);
            this.Controls.Add(this.pnlGecmis);
            this.Controls.Add(this.btnAktifOdünc);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.txtUyeAra);
            this.Controls.Add(this.dgvOdunc);
            this.Controls.Add(this.comboBoxKıtap);
            this.Controls.Add(this.comboBoxUye);
            this.Controls.Add(this.pnlAktif);
            this.Name = "FrmOduncIslem";
            this.Text = "FrmOduncIslem";
            this.Load += new System.EventHandler(this.FrmOduncIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdunc)).EndInit();
            this.pnlAktif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUye;
        private System.Windows.Forms.ComboBox comboBoxKıtap;
        private System.Windows.Forms.Button btnödünc;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.DataGridView dgvOdunc;
        private System.Windows.Forms.TextBox txtUyeAra;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Panel pnlAktif;
        private System.Windows.Forms.Button btnAktifOdünc;
        private System.Windows.Forms.Panel pnlGecmis;
        private System.Windows.Forms.DataGridView dgvGecmis;
    }
}