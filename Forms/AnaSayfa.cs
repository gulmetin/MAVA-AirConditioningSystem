using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MAVA.SqlQuerys;

namespace MAVA.Forms
{
    public partial class AnaSayfa : Form
    {
        //Sql fonksiyonlarını kullanmak için o fonksiyonun bulunduğu sınıfın nesnesini oluşturuyoruz.
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();

        public AnaSayfa()
        {
            InitializeComponent();
            //kaydedilen USERID 0 ise admindir
            if (Properties.Settings.Default.USERID == 0)
            {
                //admin için kontolsüz bütün sayfalar ekrana getirilir
                AdminMenuStrip();
            }
            else
            {
                //admin değilse yetki kontrolü yapılır
                UserMenuStrip();
            }
           
        }

        private void UserMenuStrip()
        {
            //ilk liste ilk modülü ve itemlerini, ikinci liste ikinci modülün ve itemlerinin listesini... tutar
            List<List<string>> menu = anasayfaQrys.gettingMenuStrip();

            foreach(List<string> modul in menu)
            {
                ToolStripMenuItem stripItem = new ToolStripMenuItem(modul[0]);
                foreach (string link in modul)
                {
                    if (link == modul[0])
                    {
                        continue;
                    }
                    stripItem.DropDownItems.Add(link);
                }
                //menustrip itemlerinin tıklanma fonksiyonunun eklenmesi
                stripItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(stripDropDownItem_Click);
                menuStrip.Items.Add(stripItem);

            }

        }
        //admin için menustripte bütün sayfaların eklenmesi6+6+99999
        private void AdminMenuStrip()
        {
            string[,] Menu = new string[10, 10];
            Menu = (string[,])anasayfaQrys.gettingmenuStripAdmin();
            for (int i = 0; i < 10; i++)
            {
                if (Menu[i, 0] != null)
                {
                    ToolStripMenuItem stripItem = new ToolStripMenuItem(Menu[i, 0]);

                    for (int k = 1; k < 10; k++)
                    {
                        if (Menu[i, k] != null)
                        {
                            stripItem.DropDownItems.Add(Menu[i, k]);
                        }
                        else
                            break;
                    }
                    //menustrip itemlerinin tıklanma fonksiyonunun eklenmesi
                    stripItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(stripDropDownItem_Click);
                    menuStrip.Items.Add(stripItem);
                }
                else
                    break; ;
            }
        }
        private void stripDropDownItem_Click(Object sender, ToolStripItemClickedEventArgs e)
        {
            //var menuItem = sender as MenuStrip;
            string menuText = e.ClickedItem.Text;

            //tıklanılan sekmenin yazısıyla, açılacak formun yazısını eşleştirme
            switch (menuText)
            {
                case "Cihaz Oda Tanımlama":
                    CihazOdaTanimlaForm cihazoda = new CihazOdaTanimlaForm();
                    cihazoda.Show();
                    break;

                case "Cihaz Tanımlama":
                    CihazTanimlaForm cihaztanimla = new CihazTanimlaForm();
                    cihaztanimla.Show();
                    break;
                case "Odalar":
                    OdalarForm odalar = new OdalarForm();
                    odalar.Show();
                    break;
                case "Fiyat Tanımlama":
                    FiyatlarForm fiyatlar = new FiyatlarForm();
                    fiyatlar.Show();
                    break;
                case "Cihaz On Off":
                    CihazOnOffForm inputs = new CihazOnOffForm();
                    inputs.Show();
                    break;
                case "Kullanıcılar":
                    KullanicilarForm kullanici = new KullanicilarForm();
                    kullanici.Show();
                    break;
                case "Klima Satış":

                    KlimaSatisForm klimasatis = new KlimaSatisForm();
                    klimasatis.Show();
                    break;
                case "Klima Satışları":
                    KlimaSatislariForm klimasatislari = new KlimaSatislariForm();
                    klimasatislari.Show();
                    break;
            }
        }

      
    }
}
