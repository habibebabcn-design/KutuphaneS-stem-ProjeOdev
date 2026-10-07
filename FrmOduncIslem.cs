using System;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneSıstemıProjeOdev
{
    public partial class FrmOduncIslem : Form
    {
        KutuphaneDBEntities _db = new KutuphaneDBEntities();

        int secilenOduncId = 0;

        public FrmOduncIslem()
        {
            InitializeComponent();
        }


        private void FrmOduncIslem_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlAktif.Visible = false;
            pnlGecmis.Visible = false;

            UyeDoldur();
            KitapDoldur();
            OduncListeyiYenile();
        }


        private void btnAktifOdünc_Click(object sender, EventArgs e)
        {
            pnlAktif.Visible = true;

            pnlGecmis.Visible = false;


            OduncListeyiYenile();
        }


        private void btnGecmis_Click(object sender, EventArgs e)
        {
            pnlGecmis.Visible = true;

            pnlAktif.Visible = false;

            dgvGecmis.DataSource = _db.OduncIslemleri
                .Where(x => x.TeslimTarihi != null)
                .Select(x => new
                {
                    Id = x.Id,
                    Uye = x.Uyeler.Ad + " " + x.Uyeler.Soyad,
                    Kitap = x.Kitaplar.KitapAd,
                    VerisTarihi = x.VerilisTarihi,
                    TeslimTarihi = x.TeslimTarihi
                })
                .ToList();
        }


        private void UyeDoldur()
        {

            var uyeler = _db.Uyeler
                .Where(x => x.AktifMi == true)
                .Select(x => new
                {
                    x.Id,
                    AdSoyad = x.Ad + " " + x.Soyad
                })
                .ToList();

            comboBoxUye.DataSource = uyeler;
            comboBoxUye.DisplayMember = "AdSoyad";
            comboBoxUye.ValueMember = "Id";
        }


        private void KitapDoldur()
        {

            var kitaplar = _db.Kitaplar
                .Select(x => new
                {
                    Id = x.Id,
                    KitapAd = x.KitapAd + " (Stok: " + x.MevcutStok + ")"
                })
                .ToList();

            comboBoxKıtap.DataSource = kitaplar;
            comboBoxKıtap.DisplayMember = "KitapAd";
            comboBoxKıtap.ValueMember = "Id";
        }


        private void OduncListeyiYenile()
        {
            _db = new KutuphaneDBEntities();

            dgvOdunc.DataSource = _db.OduncIslemleri
                .Where(x => x.TeslimTarihi == null)
                .Select(x => new
                {
                    Id = x.Id,
                    Uye = x.Uyeler.Ad + " " + x.Uyeler.Soyad,
                    Kitap = x.Kitaplar.KitapAd,
                    VerisTarihi = x.VerilisTarihi
                })
                .ToList();
        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtUyeAra.Text.ToLower();

            var filtrelenmis = _db.Uyeler
                .Where(x => x.AktifMi == true &&
                    (x.Ad.ToLower().Contains(aranan) ||
                     x.Soyad.ToLower().Contains(aranan)))
                .Select(x => new
                {
                    Id = x.Id,
                    AdSoyad = x.Ad + " " + x.Soyad
                })
                .ToList();


            comboBoxUye.DataSource = filtrelenmis;
            comboBoxUye.DisplayMember = "AdSoyad";
            comboBoxUye.ValueMember = "Id";
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtKitapAra.Text.ToLower();


            var filtrelenmis = _db.Kitaplar
                .Where(x => x.KitapAd.ToLower().Contains(aranan))
                .Select(x => new
                {
                    Id = x.Id,
                    KitapAd = x.KitapAd + " (Stok: " + x.MevcutStok + ")"
                })
                .ToList();

            comboBoxKıtap.DataSource = filtrelenmis;
            comboBoxKıtap.DisplayMember = "KitapAd";
            comboBoxKıtap.ValueMember = "Id";
        }


        private void btnOdunc_Click(object sender, EventArgs e)
        {
            try
            {

                _db = new KutuphaneDBEntities();

                int secilenUyeId = (int)comboBoxUye.SelectedValue;
                int secilenKitapId = (int)comboBoxKıtap.SelectedValue;


                var kitap = _db.Kitaplar.Find(secilenKitapId);

                if (kitap.MevcutStok == 0)
                {
                    MessageBox.Show("Bu kitabın stoğu tükendi, ödünç verilemiyor!");
                    return;
                }

      
                kitap.MevcutStok = kitap.MevcutStok - 1;

            
                OduncIslemleri yeniOdunc = new OduncIslemleri();
                yeniOdunc.UyeId = secilenUyeId;
                yeniOdunc.KitapId = secilenKitapId;
                yeniOdunc.VerilisTarihi = DateTime.Now;


                _db.OduncIslemleri.Add(yeniOdunc);

                _db.SaveChanges();

                OduncListeyiYenile();
                KitapDoldur(); 
                MessageBox.Show("Kitap başarıyla ödünç verildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void dgvOdunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                secilenOduncId = Convert.ToInt32(
                    dgvOdunc.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (secilenOduncId == 0)
            {
                MessageBox.Show("Lütfen iade alınacak kaydı listeden seçiniz!");
                return;
            }

            var odunc = _db.OduncIslemleri.Find(secilenOduncId);
            if (odunc != null)
            {

                odunc.TeslimTarihi = DateTime.Now;


                var kitap = _db.Kitaplar.Find(odunc.KitapId);
                kitap.MevcutStok = kitap.MevcutStok + 1;

                _db.SaveChanges();

                MessageBox.Show("Kitap başarıyla iade alındı!");
                secilenOduncId = 0;
                OduncListeyiYenile();
                KitapDoldur();
            }
        }
    }
}