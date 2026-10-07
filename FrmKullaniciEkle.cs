using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneSıstemıProjeOdev
{
    public partial class FrmKullaniciEkle : Form
    {
        KutuphaneDBEntities _db = new KutuphaneDBEntities();

        int secilenKullaniciId = 0;
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void FrmKullaniciEkle_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            RolDoldur();
            ListeyiYenile();
        }
        private void RolDoldur()
        {
            var roller = _db.Roller.ToList();
            cmbRol.DisplayMember = "RolAd";
            cmbRol.ValueMember = "Id";
            cmbRol.DataSource = roller;
        }
        private void ListeyiYenile()
        {
            dgvKullanicilar.DataSource = _db.Kullanicilar.Select(x => new KullaniciViewModel
    {
        Id = x.Id,
        KullaniciAdi = x.KullaniciAdi,
        Rol = x.Roller.RolAd 
    })
    .ToList();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!");
                return;
            }
      
            var mevcutKullanici = _db.Kullanicilar
                .Where(x => x.KullaniciAdi == txtKullaniciAdi.Text)
                .FirstOrDefault();

            if (mevcutKullanici != null)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                return;
            }

            Kullanicilar yeniKullanici = new Kullanicilar();

            yeniKullanici.KullaniciAdi = txtKullaniciAdi.Text;
            yeniKullanici.Sifre = txtSifre.Text;

            yeniKullanici.RolId = (int)cmbRol.SelectedValue;

            _db.Kullanicilar.Add(yeniKullanici);
            _db.SaveChanges();

            MessageBox.Show("Kullanıcı başarıyla eklendi!");

            ListeyiYenile();
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                secilenKullaniciId = Convert.ToInt32(dgvKullanicilar.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }


        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
 
            if (secilenKullaniciId == 0)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı listeden seçiniz!");
                return;
            }

            DialogResult onay = MessageBox.Show(
                "Bu kullanıcıyı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo);

            if (onay == DialogResult.Yes)
            {
                var kullanici = _db.Kullanicilar.Find(secilenKullaniciId);
                if (kullanici != null)
                {
                    _db.Kullanicilar.Remove(kullanici);
                    _db.SaveChanges();

                    MessageBox.Show("Kullanıcı silindi.");
                    ListeyiYenile();
                    secilenKullaniciId = 0;
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                }
            }
        }

    }
}
