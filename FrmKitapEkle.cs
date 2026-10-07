using KutuphaneSıstemıProjeOdev.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ClosedXML.Excel;

namespace KutuphaneSıstemıProjeOdev
{
    public partial class FrmKitapEkle : Form
    {
        KutuphaneDBEntities _db = new KutuphaneDBEntities();
        int secilenKitapId = 0;
        string secilenFotografYolu = "";

        public FrmKitapEkle()
        {
            InitializeComponent();
        }

        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
            ListeyiYenile();
        }

        private void KategoriDoldur()
        {
            var kategoriler = _db.Kategoriler.ToList();

            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "Id";

            List<Kategoriler> aramaKategoriler = new List<Kategoriler>();
            aramaKategoriler.Add(new Kategoriler { Id = 0, KategoriAd = "Tümü" });
            aramaKategoriler.AddRange(kategoriler);//burayı anlamadım!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            ktgriCmbox.DataSource = aramaKategoriler;
            ktgriCmbox.DisplayMember = "KategoriAd";
            ktgriCmbox.ValueMember = "Id";
        }

        private void ListeyiYenile()
        {

            List<KitapViewModel> liste = _db.Kitaplar
                .Select(x => new KitapViewModel
                {
                    Id = x.Id,
                    BarkodNo = x.BarkodNo,
                    KitapAd = x.KitapAd,
                    Yazar = x.Yazar,
                    SayfaSayisi = x.SayfaSayisi,
                    YayinYili = x.YayinYili,
                    KategoriAd = x.Kategoriler.KategoriAd,
                    KapakFotografi = x.KapakFotografi
                })
                .ToList();

            dataGridView1.DataSource = liste;

            if (dataGridView1.Columns["colGuncelle"] != null)
                dataGridView1.Columns["colGuncelle"].DisplayIndex = dataGridView1.Columns.Count - 2;
            if (dataGridView1.Columns["colSil"] != null)
                dataGridView1.Columns["colSil"].DisplayIndex = dataGridView1.Columns.Count - 1;
        }

        private void BtnFotografSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Kapak Fotoğrafı Seç";

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                secilenFotografYolu = ofd.FileName; 
                txtKapak.Text = Path.GetFileName(ofd.FileName);
                pictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            if (BtnKitapEkle.Text == "Güncelle")
            {
                var kitap = _db.Kitaplar.Find(secilenKitapId);

                kitap.BarkodNo = txtBarkodNo.Text;
                kitap.KitapAd = txtKitapAd.Text;
                kitap.Yazar = txtYazar.Text;
                kitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayısı.Text);
                kitap.YayinYili = Convert.ToInt32(txtYayınYılı.Text);
                kitap.KategoriId = (int)cmbKategori.SelectedValue;
                kitap.ToplamStok = Convert.ToInt32(txtToplamStok.Text);
                kitap.MevcutStok = Convert.ToInt32(txtToplamStok.Text);

                if (secilenFotografYolu != "")
                {
                    string hedefKlasor = Application.StartupPath + "\\Kapaklar\\";
                    if (!Directory.Exists(hedefKlasor))
                        Directory.CreateDirectory(hedefKlasor);

                    string dosyaadi = Path.GetFileName(secilenFotografYolu);
                    string hedefTamYol = hedefKlasor + dosyaadi;

                    if (secilenFotografYolu != hedefTamYol)
                    {
                        File.Copy(secilenFotografYolu, hedefTamYol, true);
                    }
                    kitap.KapakFotografi = dosyaadi;
                }

                _db.SaveChanges();
                MessageBox.Show("Kitap bilgileri güncellendi!");
                ListeyiYenile();
                Temizle();
                return;
            }



            if (txtKitapAd.Text == "" || txtYazar.Text == "" || txtBarkodNo.Text == "")
            {
                MessageBox.Show("Lütfen Barkod No, Kitap Adı ve Yazar alanlarını doldurunuz!");
                return;
            }

            Kitaplar yeniKitap = new Kitaplar();

            yeniKitap.BarkodNo = txtBarkodNo.Text;
            yeniKitap.KitapAd = txtKitapAd.Text;
            yeniKitap.Yazar = txtYazar.Text;
            yeniKitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayısı.Text);
            yeniKitap.YayinYili = Convert.ToInt32(txtYayınYılı.Text);
            yeniKitap.KategoriId = (int)cmbKategori.SelectedValue;
            yeniKitap.ToplamStok = Convert.ToInt32(txtToplamStok.Text);
            yeniKitap.MevcutStok = Convert.ToInt32(txtToplamStok.Text);

            string kapakDosyaAdi = "";
            if (secilenFotografYolu != "")
            {
                string hedefKlasor = Application.StartupPath + "\\Kapaklar\\";
                if (!Directory.Exists(hedefKlasor))
                    Directory.CreateDirectory(hedefKlasor);

                kapakDosyaAdi = Path.GetFileName(secilenFotografYolu);
                string hedefTamYol = hedefKlasor + kapakDosyaAdi;

                if (secilenFotografYolu != hedefTamYol)
                {
                    File.Copy(secilenFotografYolu, hedefTamYol, true);
                }
            }

            yeniKitap.KapakFotografi = kapakDosyaAdi;

            _db.Kitaplar.Add(yeniKitap);
            _db.SaveChanges();

            MessageBox.Show(yeniKitap.KitapAd + " başarıyla eklendi!");
            ListeyiYenile();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
            secilenKitapId = Convert.ToInt32(satir.Cells["Id"].Value);

            if (e.ColumnIndex == dataGridView1.Columns["colGuncelle"].Index)
            {
                txtBarkodNo.Text = satir.Cells["BarkodNo"].Value.ToString();
                txtKitapAd.Text = satir.Cells["KitapAd"].Value.ToString();
                txtYazar.Text = satir.Cells["Yazar"].Value.ToString();
                txtSayfaSayısı.Text = satir.Cells["SayfaSayisi"].Value.ToString();
                txtYayınYılı.Text = satir.Cells["YayinYili"].Value.ToString();
                txtKapak.Text = satir.Cells["KapakFotografi"].Value.ToString();

                var kitap = _db.Kitaplar.Find(secilenKitapId);
                cmbKategori.SelectedValue = kitap.KategoriId;
                txtToplamStok.Text = kitap.ToplamStok.ToString();

                string kapakYolu = Application.StartupPath + "\\Kapaklar\\" + txtKapak.Text;

                if (System.IO.File.Exists(kapakYolu))
                {
                    using (var stream = new System.IO.FileStream(kapakYolu, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Image = null;
                }

                BtnKitapEkle.Text = "Güncelle";
            }

            if (e.ColumnIndex == dataGridView1.Columns["colSil"].Index)
            {
                DialogResult onay = MessageBox.Show(
                    "Bu kitabı silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo);

                if (onay == DialogResult.Yes)
                {
                    var kitap = _db.Kitaplar.Find(secilenKitapId);
                    if (kitap != null)
                    {
                        _db.Kitaplar.Remove(kitap);
                        _db.SaveChanges();
                        MessageBox.Show("Kitap silindi.");
                        ListeyiYenile();
                        Temizle();
                    }
                }
            }
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            var sorgu = _db.Kitaplar.AsQueryable();

            if (textBox1.Text != "")
                sorgu = sorgu.Where(x => x.Yazar.ToLower().Contains(textBox1.Text.ToLower()));

            int minYil;
            if (int.TryParse(minTextBox.Text, out minYil))
            {
                sorgu = sorgu.Where(x => x.YayinYili >= minYil); //
            }

            int maxYil;
            if (int.TryParse(maxTextBox.Text, out maxYil))
            {
                sorgu = sorgu.Where(x => x.YayinYili <= maxYil);
            }

            int secilenKategoriId = (int)ktgriCmbox.SelectedValue;
            if (secilenKategoriId > 0)
                sorgu = sorgu.Where(x => x.KategoriId == secilenKategoriId);

            dataGridView1.DataSource = sorgu
                .Select(x => new KitapViewModel
                {
                    Id = x.Id,
                    BarkodNo = x.BarkodNo,
                    KitapAd = x.KitapAd,
                    Yazar = x.Yazar,
                    SayfaSayisi = x.SayfaSayisi,
                    YayinYili = x.YayinYili,
                    KategoriAd = x.Kategoriler.KategoriAd,
                    KapakFotografi = x.KapakFotografi
                })
                .ToList();

            if (dataGridView1.Columns["colGuncelle"] != null)
                dataGridView1.Columns["colGuncelle"].DisplayIndex = dataGridView1.Columns.Count - 2;
            if (dataGridView1.Columns["colSil"] != null)
                dataGridView1.Columns["colSil"].DisplayIndex = dataGridView1.Columns.Count - 1;
        }

        private void Temizle()
        {
            txtBarkodNo.Text = "";
            txtKitapAd.Text = "";
            txtYazar.Text = "";
            txtSayfaSayısı.Text = "";
            txtYayınYılı.Text = "";
            txtKapak.Text = "";
            txtToplamStok.Text = "";
            pictureBox1.Image = null;
            secilenKitapId = 0;
            secilenFotografYolu = "";
            BtnKitapEkle.Text = "Ekle";
            cmbKategori.SelectedIndex = 0;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Dosyası|*.pdf";
            sfd.FileName = "KitapListesi";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document pdf = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(pdf, new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create));
                    pdf.Open();

                    iTextSharp.text.Font baslikFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                    pdf.Add(new Paragraph("Kitap Listesi", baslikFont));
                    pdf.Add(new Paragraph(" "));

                    PdfPTable tablo = new PdfPTable(6);
                    tablo.WidthPercentage = 100;

                    iTextSharp.text.Font sutunFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                    tablo.AddCell(new PdfPCell(new Phrase("Barkod No", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Kitap Adı", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Yazar", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Sayfa", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Yayın Yılı", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Kategori", sutunFont)));

                    iTextSharp.text.Font veriFont = FontFactory.GetFont("Arial", 9);
                    foreach (DataGridViewRow satir in dataGridView1.Rows)
                    {
                        if (satir.IsNewRow) continue;

                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["BarkodNo"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["KitapAd"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["Yazar"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["SayfaSayisi"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["YayinYili"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["KategoriAd"].Value?.ToString(), veriFont)));
                    }

                    pdf.Add(tablo);
                    pdf.Close();

                    MessageBox.Show("PDF başarıyla oluşturuldu!");
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF oluşturulurken hata: " + ex.Message);
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Dosyası|*.xlsx";
            sfd.FileName = "KitapListesi";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Kitaplar");

                    worksheet.Cell(1, 1).Value = "Barkod No";
                    worksheet.Cell(1, 2).Value = "Kitap Adı";
                    worksheet.Cell(1, 3).Value = "Yazar";
                    worksheet.Cell(1, 4).Value = "Sayfa Sayısı";
                    worksheet.Cell(1, 5).Value = "Yayın Yılı";
                    worksheet.Cell(1, 6).Value = "Kategori";

                    worksheet.Row(1).Style.Font.Bold = true;

                    int satirNo = 2;
                    foreach (DataGridViewRow satir in dataGridView1.Rows)
                    {
                        if (satir.IsNewRow) continue;

                        worksheet.Cell(satirNo, 1).Value = satir.Cells["BarkodNo"].Value?.ToString();
                        worksheet.Cell(satirNo, 2).Value = satir.Cells["KitapAd"].Value?.ToString();
                        worksheet.Cell(satirNo, 3).Value = satir.Cells["Yazar"].Value?.ToString();
                        worksheet.Cell(satirNo, 4).Value = satir.Cells["SayfaSayisi"].Value?.ToString();
                        worksheet.Cell(satirNo, 5).Value = satir.Cells["YayinYili"].Value?.ToString();
                        worksheet.Cell(satirNo, 6).Value = satir.Cells["KategoriAd"].Value?.ToString();

                        satirNo++;
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(sfd.FileName);

                    MessageBox.Show("Excel başarıyla oluşturuldu!");
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel oluşturulurken hata: " + ex.Message);
                }
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}