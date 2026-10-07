using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneSıstemıProjeOdev
{
    public partial class FrmKitapDegerlendirme : Form
    {
        KutuphaneDBEntities _db = new KutuphaneDBEntities();
        List<TextBox> kondisyonInputlari = new List<TextBox>();

        public FrmKitapDegerlendirme()
        {
            InitializeComponent();
        }

        private void FrmKitapDegerlendirme_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            flpKitaplar.Controls.Clear();
            kondisyonInputlari.Clear();

            var sorgu = _db.OduncIslemleri.AsQueryable();

            if (!string.IsNullOrEmpty(txtAraAd.Text))
            {
                sorgu = sorgu.Where(x => x.Uyeler.Ad.Contains(txtAraAd.Text));
            }

            if (!string.IsNullOrEmpty(txtAraSoyad.Text))
            {
                sorgu = sorgu.Where(x => x.Uyeler.Soyad.Contains(txtAraSoyad.Text));
            }

            var filtrelenmisKitaplar = sorgu.ToList();

            if (filtrelenmisKitaplar.Count == 0)
            {
                MessageBox.Show("Aranan kriterlere uygun ödünç kitap kaydı bulunamadı.");
                return;
            }

            foreach (var odunc in filtrelenmisKitaplar)
            {
                Panel pnlSatir = new Panel { Width = 450, Height = 40 };

                Label lblKitap = new Label
                {
                    Text = odunc.Uyeler.Ad + " " + odunc.Uyeler.Soyad + " - " + odunc.Kitaplar.KitapAd + " (" + odunc.VerilisTarihi.Value.ToShortDateString() + ")",
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 9, FontStyle.Bold)
                };

                TextBox txtKondisyon = new TextBox
                {
                    Location = new Point(280, 10),
                    Width = 150,
                    Text = odunc.KondisyonDurumu != null ? odunc.KondisyonDurumu.ToString() : "",
                    Tag = odunc.Id
                };

                pnlSatir.Controls.Add(lblKitap);
                pnlSatir.Controls.Add(txtKondisyon);
                kondisyonInputlari.Add(txtKondisyon);
                flpKitaplar.Controls.Add(pnlSatir);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kondisyonInputlari.Count == 0)
            {
                MessageBox.Show("Lütfen önce arama yaparak kitapları listeleyiniz!");
                return;
            }

            foreach (var item in kondisyonInputlari)
            {
                int oduncId = (int)item.Tag;
                var oduncKaydi = _db.OduncIslemleri.Find(oduncId);

                if (oduncKaydi != null)
                {
                    oduncKaydi.KondisyonDurumu = item.Text;
                }
            }

            _db.SaveChanges();
            MessageBox.Show("Kitap kondisyon durumları başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}