using System;
using System.Collections.Generic;
using System.Text;
using MAVA.Entitys;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MAVA.SqlQuerys
{
    class KullanicilarKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz

        //bütün kullanıcıların listesini döndürür.
         public List<User> getAllUser()
        {
            List<User> users = new List<User>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from OTELUSER", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    User user = new User();
                    user.id = Convert.ToInt32(read["USERID"]);
                    user.ad = read["ADI"].ToString();
                    user.soyad = read["SOYADI"].ToString();
                    user.departman = read["DEPARTMANKODU"].ToString();
                    user.tel = read["TEL"].ToString();
                    user.mail = read["MAIL"].ToString();
                    user.kadi = read["KADI"].ToString();   
                    user.sifre = read["SIFRE"].ToString();
                    user.yetki = read["YETKI"].ToString();
                    users.Add(user);

                }
                baglanti.Close();
                return users;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        //kullanıcı ekleme
        public void addUser(User user)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO OTELUSER (ADI,SOYADI,DEPARTMANKODU,TEL,MAIL,KADI,SIFRE,YETKI,OTELKODU,SUBEKODU) VALUES " +
                    "(@ADI,@SOYADI,@DEPARTMANKODU,@TEL,@MAIL,@KADI,@SIFRE,@YETKI,@OTELKODU,@SUBEKODU)", baglanti);
                komut.Parameters.AddWithValue("@ADI", user.ad);
                komut.Parameters.AddWithValue("@SOYADI", user.soyad);
                komut.Parameters.AddWithValue("@DEPARTMANKODU", user.departman);
                komut.Parameters.AddWithValue("@TEL", user.tel);
                komut.Parameters.AddWithValue("@MAIL", user.mail);
                komut.Parameters.AddWithValue("@KADI", user.kadi);
                komut.Parameters.AddWithValue("@SIFRE", user.sifre);
                komut.Parameters.AddWithValue("@YETKI", user.yetki);
                komut.Parameters.AddWithValue("@OTELKODU", ConfigurationManager.AppSettings["OTELKODU"]);
                komut.Parameters.AddWithValue("@SUBEKODU", ConfigurationManager.AppSettings["SUBEKODU"]);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        //kullanıcı çıkar
        public void removeUser(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM OTELUSER WHERE id= @id", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        //kullanıcı güncelleme
        public void uptadeUser(User user)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE OTELUSER SET ADI = @ADI, SOYADI = @SOYADI, DEPARTMANKODU = @DEPARTMANKODU, TEL = @TEL, MAIL = @MAIL, KADI = @KADI, SIFRE = @SIFRE, YETKI = @YETKI  where USERID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", user.id);
                komut.Parameters.AddWithValue("@ADI", user.ad);
                komut.Parameters.AddWithValue("@SOYADI", user.soyad);
                komut.Parameters.AddWithValue("@DEPARTMANKODU", user.departman);
                komut.Parameters.AddWithValue("@TEL", user.tel);
                komut.Parameters.AddWithValue("@MAIL", user.mail);
                komut.Parameters.AddWithValue("@KADI", user.kadi);
                komut.Parameters.AddWithValue("@SIFRE", user.sifre);
                komut.Parameters.AddWithValue("@YETKI", user.yetki);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
