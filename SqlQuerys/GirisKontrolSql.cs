using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MAVA.SqlQuerys
{
    public class GirisKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz
        public bool girisKontrol(string kadi, string sifre)
        {
            //admin girişi olup olmadığının kontrolü
            bool admincheck = false;
            
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select * from admin where kullanici_adi = @KullaniciAdi and sifre = @Sifre", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("@KullaniciAdi", kadi);//parametreler
                komut.Parameters.AddWithValue("@Sifre", sifre);
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())
                {
                    //admin girişi
                    admincheck = true;
                    Properties.Settings.Default.USERID = 0;//USERID yi diğer ekranlarda kullanmak için properties kısmına kaydettim                  
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

            //admin girmiştir
            if (admincheck == true)
            {
                return admincheck;
            }
            //admin değildir o yüzden kullanıcı databaseinden kontrol yapılır
            else {
                try
                {
                    baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                    SqlCommand komut = new SqlCommand("Select * from OTELUSER where KADI = @KullaniciAdi and SIFRE = @Sifre", baglanti);//sorgumuz
                    komut.Parameters.AddWithValue("@KullaniciAdi", kadi);//parametreler
                    komut.Parameters.AddWithValue("@Sifre", sifre);
                    SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                    while (read.Read())
                    {
                        Properties.Settings.Default.USERID = Convert.ToInt32(read["USERID"]);//USERID yi diğer ekranlarda kullanmak için properties kısmına kaydettim                  
                        return true;
                    }
                    baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
                    return false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.ToString());
                    throw;
                }
            }

        }
    }
}
