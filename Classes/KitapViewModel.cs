using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace KutuphaneSıstemıProjeOdev.Classes
 {
        // Bu sınıf bir tabloya karşılık gelmiyor!
        // Sadece ekranda göstermek istediğimiz
        // alanları bir araya topluyor.
     public class KitapViewModel
     {
            public int Id { get; set; }
            public string BarkodNo { get; set; }
            public string KitapAd { get; set; }
            public string Yazar { get; set; }
            public int? SayfaSayisi { get; set; }
            public int? YayinYili { get; set; }

            // Dikkat! KategoriId değil, KategoriAd yazıyoruz
            // Kategoriler tablosundan birleştireceğiz
            public string KategoriAd { get; set; }
            public string KapakFotografi { get; set; }
     }
}

