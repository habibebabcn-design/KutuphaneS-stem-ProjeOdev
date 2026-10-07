using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
namespace KutuphaneSıstemıProjeOdev
{
    public partial class FrmLogin : Form
    {
        KutuphaneDBEntities _db = new KutuphaneDBEntities();
        public FrmLogin()
        {
            foreach (var process in System.Diagnostics.Process.GetProcessesByName(
        System.Diagnostics.Process.GetCurrentProcess().ProcessName))
            {
                if (process.Id != System.Diagnostics.Process.GetCurrentProcess().Id)
                {
                    process.Kill();
                }
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = klncbox.Text;
            string sifre = prlbox.Text;

            var kullanici = _db.Kullanicilar.Where(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre)
                .FirstOrDefault();

            if (kullanici != null) 
            {
                MessageBox.Show("Giriş Başarılı! Hoşgeldin " + kullanici.KullaniciAdi);

                FrmAnaMenu frm = new FrmAnaMenu();
                    frm.kullaniciRolId = (int)kullanici.RolId;
                    frm.Show();
                    this.Hide();
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı! Lütfen tekrar deneyin.");
            }
        }
    }
}
