using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSıstemıProjeOdev
{
    public partial class FrmAnaMenu : Form
    {
        public int kullaniciRolId;
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void BtnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmUyeEkle frm = new FrmUyeEkle();
            frm.ShowDialog();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            if (kullaniciRolId == 1)
            {
                BtnKıtapEkle.Visible = true;
                BtnUyeEkle.Visible = true;
                BtnOduncislem.Visible = true;
                BtnKullaniciYonetim.Visible = true;
            }
            else if (kullaniciRolId == 2)
            {
                BtnKıtapEkle.Visible = false; 
                BtnUyeEkle.Visible = false;
                BtnKullaniciYonetim.Visible = false;  
                BtnOduncislem.Visible = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOduncIslem frm = new FrmOduncIslem();

            frm.ShowDialog();
        }

        private void BtnKıtapEkle_Click(object sender, EventArgs e)
        {
            FrmKitapEkle frm = new FrmKitapEkle();
            frm.ShowDialog();
        }
        private void BtnKullaniciYonetim_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle frm = new FrmKullaniciEkle();
            frm.ShowDialog();
        }

        private void btnKitapDegerlendirme_Click(object sender, EventArgs e)
        {
            FrmKitapDegerlendirme frm = new FrmKitapDegerlendirme();
            frm.ShowDialog();
        }
    }
}