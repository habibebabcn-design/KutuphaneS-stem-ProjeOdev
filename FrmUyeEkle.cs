using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KutuphaneSıstemıProjeOdev
{
    public partial class FrmUyeEkle : Form
    {
        KutuphaneDBEntities _db = new KutuphaneDBEntities();
        string secilenProfilFoto = "";

        int secilenUyeId = 0;

        public FrmUyeEkle()
        {
            InitializeComponent();
        }


        private void FrmUyeEkle_Load(object sender, EventArgs e)
        {
            // DateTimePicker'ların başlangıç değeri bugün olsun
            dateTimeBaslngc.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {

            dgvUyeler.DataSource = _db.Uyeler
                .Where(x => x.AktifMi == true)
                .Select(x => new
                {
                    Id = x.Id,
                    TcNo = x.TcNo,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    Telefon = x.Telefon,
                    KayitTarihi = x.KayitTarihi
                })
                .ToList();

            dgvUyeler.Columns["colGüncelle"].DisplayIndex =dgvUyeler.Columns.Count - 2;
            dgvUyeler.Columns["colSil"].DisplayIndex =dgvUyeler.Columns.Count - 1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Güncelle")
            {
                var uye = _db.Uyeler.Find(secilenUyeId);
                uye.TcNo = txtTcNo.Text;
                uye.Ad = txtAd.Text;
                uye.Soyad = txtSoyad.Text;
                uye.Telefon = txtTelefon.Text;
                if (secilenProfilFoto != "")
                {
                    string hedefKlasor = System.IO.Path.Combine(Application.StartupPath, "Profiller");
                    if (!Directory.Exists(hedefKlasor))
                        Directory.CreateDirectory(hedefKlasor);

                    string dosyaadi = Path.GetFileName(secilenProfilFoto);
                    File.Copy(secilenProfilFoto, System.IO.Path.Combine(hedefKlasor, dosyaadi), true);
                    uye.ProfilFoto= dosyaadi;
                }

                _db.SaveChanges();
                MessageBox.Show("Üye bilgileri güncellendi!");
                ListeyiYenile();
                Temizle();
                return;
            }

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTcNo.Text == "")
            {
                MessageBox.Show("Lütfen Ad, Soyad ve TC No alanlarını doldurunuz!");
                return;
            }

            Uyeler yeniUye = new Uyeler();
            yeniUye.TcNo = txtTcNo.Text;
            yeniUye.Ad = txtAd.Text;
            yeniUye.Soyad = txtSoyad.Text;
            yeniUye.Telefon = txtTelefon.Text;
            yeniUye.KayitTarihi = DateTime.Now; 
            yeniUye.AktifMi = true;


            _db.Uyeler.Add(yeniUye);
            string profilDosyaAdi = "";
            if (secilenProfilFoto != "")
            {
                string hedefKlasor = System.IO.Path.Combine(Application.StartupPath, "Profiller");

                if (!Directory.Exists(hedefKlasor))
                    Directory.CreateDirectory(hedefKlasor);

                profilDosyaAdi = Path.GetFileName(secilenProfilFoto);

                string tamHedefYol = System.IO.Path.Combine(hedefKlasor, profilDosyaAdi);
                File.Copy(secilenProfilFoto, tamHedefYol, true);
            }

            yeniUye.ProfilFoto = profilDosyaAdi;


            _db.SaveChanges();

            MessageBox.Show(yeniUye.Ad + " " + yeniUye.Soyad + " başarıyla eklendi!");
            ListeyiYenile();
            Temizle();
        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow satir = dgvUyeler.Rows[e.RowIndex];

            // Tıklanan satırın üye Id'si
            secilenUyeId = Convert.ToInt32(satir.Cells["Id"].Value);

            if (e.ColumnIndex == dgvUyeler.Columns["colGüncelle"].Index)
            {
                txtTcNo.Text = satir.Cells["TcNo"].Value.ToString();
                txtAd.Text = satir.Cells["Ad"].Value.ToString();
                txtSoyad.Text = satir.Cells["Soyad"].Value.ToString();
                txtTelefon.Text = satir.Cells["Telefon"].Value.ToString();

                btnEkle.Text = "Güncelle";

                var uye = _db.Uyeler.Find(secilenUyeId);
                if (uye.ProfilFoto != null && uye.ProfilFoto != "")
                {
                    string fotoYolu = System.IO.Path.Combine(Application.StartupPath, "Profiller", uye.ProfilFoto);
                    if (System.IO.File.Exists(fotoYolu))
                    {
                        pictFoto.Image =System.Drawing.Image.FromFile(fotoYolu);
                        pictFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    pictFoto.Image = null;
                }
            }

            // SİL 
            if (e.ColumnIndex == dgvUyeler.Columns["colSil"].Index)
            {
                DialogResult onay = MessageBox.Show(
                    "Bu üyeyi silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo);

                if (onay == DialogResult.Yes)
                {
                    var uye = _db.Uyeler.Find(secilenUyeId);

                    uye.AktifMi = false;
                    _db.SaveChanges();

                    MessageBox.Show("Üye pasife alındı.");
                    ListeyiYenile();
                    Temizle();
                }
            }
        }




        private void btnArama_Click(object sender, EventArgs e)
        {
            var sorgu = _db.Uyeler.AsQueryable();

           
            if (txtAramaAd.Text!= "")
                sorgu = sorgu.Where(x =>
                    x.Ad.ToLower().Contains(txtAramaAd.Text.ToLower()));

            if (txtAramaSoyad.Text != "")
                sorgu = sorgu.Where(x => x.Soyad.ToLower().Contains(txtAramaSoyad.Text.ToLower()));

            DateTime bitisTarihi = dateTimeBitis.Value.AddDays(1);
            sorgu = sorgu.Where(x =>
                x.KayitTarihi >= dateTimeBaslngc.Value &&
                x.KayitTarihi <= bitisTarihi);

            if (checkBox1.Checked)
                sorgu = sorgu.Where(x => x.AktifMi == true);

            dgvUyeler.DataSource = sorgu
                .Select(x => new
                {
                     x.Id,
                     x.TcNo,
                     x.Ad,
                     x.Soyad,
                     x.Telefon,
                     x.KayitTarihi
                })
                .ToList();

            if (dgvUyeler.Columns["colGüncelle"] != null)
                dgvUyeler.Columns["colGüncelle"].DisplayIndex =dgvUyeler.Columns.Count - 2;

            if (dgvUyeler.Columns["colSil"] != null)
                dgvUyeler.Columns["colSil"].DisplayIndex =dgvUyeler.Columns.Count - 1;
        }

        
        private void Temizle()
        {
            txtTcNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            secilenUyeId = 0;
            btnEkle.Text = "Ekle";

            if (pictFoto.Image != null)
            {
                pictFoto.Image.Dispose();//resmi tamamen siler.
                pictFoto.Image = null;
            }
            secilenProfilFoto = "";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Dosyası|*.pdf";
            sfd.FileName = "UyeListesi";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document pdf = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(pdf, new System.IO.FileStream(
                        sfd.FileName, System.IO.FileMode.Create));
                    pdf.Open();

                    
                    iTextSharp.text.Font baslikFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                    pdf.Add(new Paragraph("Üye Listesi", baslikFont));
                    pdf.Add(new Paragraph(" "));

                    PdfPTable tablo = new PdfPTable(5);
                    tablo.WidthPercentage = 100;

                 
                    iTextSharp.text.Font sutunFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                    tablo.AddCell(new PdfPCell(new Phrase("TC No", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Ad", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Soyad", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Telefon", sutunFont)));
                    tablo.AddCell(new PdfPCell(new Phrase("Kayıt Tarihi", sutunFont)));

                    
                    iTextSharp.text.Font veriFont = FontFactory.GetFont("Arial", 9);
                    foreach (DataGridViewRow satir in dgvUyeler.Rows)
                    {
                        if (satir.IsNewRow) continue;

                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["TcNo"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["Ad"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["Soyad"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["Telefon"].Value?.ToString(), veriFont)));
                        tablo.AddCell(new PdfPCell(new Phrase(satir.Cells["KayitTarihi"].Value?.ToString(), veriFont)));
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
            sfd.FileName = "UyeListesi";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    var workbook = new XLWorkbook();
                    
                    var worksheet = workbook.Worksheets.Add("Üyeler");//üyeler sayfası

                    worksheet.Cell(1, 1).Value = "TC No";
                    worksheet.Cell(1, 2).Value = "Ad";
                    worksheet.Cell(1, 3).Value = "Soyad";
                    worksheet.Cell(1, 4).Value = "Telefon";
                    worksheet.Cell(1, 5).Value = "Kayıt Tarihi";

                    
                    worksheet.Row(1).Style.Font.Bold = true;

                    
                    int satirNo = 2;
                    foreach (DataGridViewRow satir in dgvUyeler.Rows)
                    {
                        if (satir.IsNewRow) continue;

                        worksheet.Cell(satirNo, 1).Value =
                            satir.Cells["TcNo"].Value?.ToString();
                        worksheet.Cell(satirNo, 2).Value =
                            satir.Cells["Ad"].Value?.ToString();
                        worksheet.Cell(satirNo, 3).Value =
                            satir.Cells["Soyad"].Value?.ToString();
                        worksheet.Cell(satirNo, 4).Value =
                            satir.Cells["Telefon"].Value?.ToString();
                        worksheet.Cell(satirNo, 5).Value =
                            satir.Cells["KayitTarihi"].Value?.ToString();

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

        private void buttonFotoSec_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Profil Fotoğrafı Seç";
               
                pictFoto.SizeMode = PictureBoxSizeMode.Zoom;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    secilenProfilFoto = ofd.FileName;

                    txtFotoYolu.Text = Path.GetFileName(ofd.FileName);

                pictFoto.Image = System.Drawing.Image.FromFile(ofd.FileName);
                pictFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}