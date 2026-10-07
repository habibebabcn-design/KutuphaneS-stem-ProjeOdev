using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSıstemıProjeOdev
{
    internal class GlobalFunc
    {
        // Sınıfın içine veritabanı bağlantımızı ekliyoruz
        KutuphaneDBEntities _db = new KutuphaneDBEntities();

        // Hocanın DonemDoldur metodunun Kütüphane versiyonu:
        public void UyeDoldur(ComboBox cmb)
        {
            // Her seferinde taze veri çekmek için yeni bağlantı açıyoruz
            _db = new KutuphaneDBEntities();

         var uyeListesi = _db.Uyeler
        .Where(x => x.AktifMi == true)
        .Select(x => new
        {
            Id= x.Id,
            AdSoyad = x.Ad + " " + x.Soyad
        })
        .ToList();
            
            cmb.DisplayMember = "AdSoyad";
            cmb.ValueMember = "Id";
            cmb.DataSource = uyeListesi;
        }

        // Hocanın DersDoldur metodunun Kütüphane versiyonu:
        public void KitapDoldur(ComboBox cmb)
        {
            // Her seferinde taze veri çekmek için yeni bağlantı açıyoruz
            _db = new KutuphaneDBEntities();

            var kitapListesi = _db.Kitaplar
                .Select(x => new
                {
                    Id = x.Id,
                    KitapAd = x.KitapAd + " (Stok: " + x.MevcutStok + ")"
                })
                .ToList();

            
            cmb.DisplayMember = "KitapAd";
            cmb.ValueMember = "Id";
            cmb.DataSource = kitapListesi;
        }
    }
}
