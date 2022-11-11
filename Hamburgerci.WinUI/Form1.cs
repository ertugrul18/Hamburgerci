using Hamburgerci.BL.Abstract;
using Hamburgerci.BL.Concrete;
using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.DAL.EF.Concrete;
using Hamburgerci.Entities.Concrete;

namespace Hamburgerci.WinUI
{
    public partial class Form1 : Form
    {
        readonly IKullaniciManager kullaniciManager;
        public Form1()
        {
            InitializeComponent();
            kullaniciManager = new KullaniciManager();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //    int sonuc = kullaniciDAL.Add(new Kullanici()
            //    {
            //        Adi = txtkullaniciAdi.Text,
            //        SoyAdi = "",
            //        KullaniciAdi = txtkullaniciAdi.Text,
            //        Sifre = txtSifre.Text
            //    });
            //    if (sonuc > 0)
            //    {
            //        MessageBox.Show("Kayýt Baþarýlý");

            //    }
            //    else
            //    {
            //        MessageBox.Show("Hata Oluþtu");
            //    }
            int sonuc = kullaniciManager.Add(new Kullanici()
            {
                Adi = txtkullaniciAdi.Text,
                SoyAdi = "yilmaz",
                KullaniciAdi = txtkullaniciAdi.Text,
                Sifre = txtSifre.Text
            });
            if (sonuc > 0)
            {
                MessageBox.Show("Kayýt Baþarýlý");
            }
            else
            {
                MessageBox.Show("Hata Oluþtu");
            }

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            var kullanici = kullaniciManager
                .FindByUserName(txtkullaniciAdi
                .Text, txtSifre.Text);
            if (kullanici != null)
            {
                MessageBox.Show(kullanici.Adi + " " + kullanici.SoyAdi);
            }

        }
    }
}