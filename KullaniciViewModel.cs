using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSıstemıProjeOdev
{
    internal class KullaniciViewModel
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        // RolId yerine RolAd yazıyoruz
        // Ekranda "1" değil "Admin" görmek istiyoruz
        public string Rol { get; set; }
    }
}
