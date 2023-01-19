using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAVA.Forms;
using MAVA.SqlQuerys;

namespace MAVA
{
    public partial class Giris : Form
    {
        GirisKontrolSql girisQrys = new GirisKontrolSql();
        public Giris()
        {
            InitializeComponent();

            //giris formu açıldığında bilgilerin Properties kısmından ana ekrana getirilmesi
            if(Properties.Settings.Default.defaultUser != "")
            {
                kadi_textbox.Text = Properties.Settings.Default.defaultUser;
                if(Properties.Settings.Default.defaultUserPass != "Şifre")
                {
                    sifre_textbox.PasswordChar = Convert.ToChar("*");
                    benihatirla_checkbox.Checked = true;
                }                  
                sifre_textbox.Text = Properties.Settings.Default.defaultUserPass;
            }
        }


        //tıklandığında textbox içeriğini temizleme
        private void kadi_textbox_Click(object sender, EventArgs e)
        {
            kadi_textbox.Text = "";
        }

        private void sifre_textbox_Click(object sender, EventArgs e)
        {
            sifre_textbox.Text = "";
            sifre_textbox.PasswordChar = Convert.ToChar("*");
        }

        //giris butonu 
        private void giris_btn_Click(object sender, EventArgs e)
        {
            //sqlden giriş bilgilerini kontrol eder
            //giriş başarılıysa
            if(girisQrys.girisKontrol(kadi_textbox.Text.Trim(), sifre_textbox.Text.Trim()))
            {
                //beni hatırla kutucuğu kontrolü
                if (benihatirla_checkbox.Checked)
                {
                    //eğer beni hatırla kutucuğu işaretliyse kullanıcı adı ve şifreyi Properties kısmına kaydeder
                    Properties.Settings.Default.defaultUser = kadi_textbox.Text;
                    Properties.Settings.Default.defaultUserPass = sifre_textbox.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    //eğer seçili değilse default olarak ekranda gösterilecek içerikleri kaydeder
                    Properties.Settings.Default.defaultUser = "Kullanıcı Adı";
                    Properties.Settings.Default.defaultUserPass = "Şifre";
                    Properties.Settings.Default.Save();
                }
                //bu formu saklar
                this.Hide();

                //Anasayfaya formu açılır
                AnaSayfa anasayfaFrm = new AnaSayfa();
                anasayfaFrm.Show();
            }
            //başarılı değilse
            else
            {
                MessageBox.Show("Hatalı Giris Yaptınız");
            }
        }

    }
}
