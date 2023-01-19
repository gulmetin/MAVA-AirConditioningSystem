using MAVA.Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MAVA.SqlQuerys
{
    class KlimaSatislariKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz
        GetPostKontrol sqlQuery = new GetPostKontrol();
        //bütün siparişleri satış sınıfı nesnesi şeklinde döndürür
        public List<Satis> getAllSatis()
        {
            List<Satis> satislar = new List<Satis>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from siparis", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Satis satis = new Satis();
                    satis.satisid = Convert.ToInt32(read["id"]);
                    satis.odano = read["odano"].ToString();
                    satis.cihazno = read["role"].ToString();
                    satis.cihazport = read["role_port"].ToString();
                    satis.klimano = read["klimano"].ToString();
                    satis.bastar = Convert.ToDateTime(read["bastar"].ToString());
                    satis.bittar = Convert.ToDateTime(read["bittar"].ToString());
                    satis.bitsaat = read["bitsaat"].ToString();
                    satis.tutar = Convert.ToInt32(read["tutar"].ToString());
                    satis.doviz = read["doviz"].ToString();
                    satis.statu = read["statu"].ToString();
                    satis.degisim = read["degisim"].ToString();
                    satislar.Add(satis);

                }
                baglanti.Close();
                return satislar;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        //Aktif Satiş İşlem Fonksiyonları
        public Satis getSatis(int id)
        {
            Satis satis = new Satis();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from siparis where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    satis.satisid = Convert.ToInt32(read["id"]);
                    satis.odano = read["odano"].ToString();
                    satis.cihazno = read["role"].ToString();
                    satis.cihazport = read["role_port"].ToString();
                    satis.klimano = read["klimano"].ToString();
                    satis.bastar = Convert.ToDateTime(read["bastar"].ToString());
                    satis.bittar = Convert.ToDateTime(read["bittar"].ToString());
                    satis.bitsaat = read["bitsaat"].ToString();
                    satis.tutar = Convert.ToInt32(read["tutar"].ToString());
                    satis.doviz = read["doviz"].ToString();
                    satis.statu = read["statu"].ToString();
                    satis.degisim = read["degisim"].ToString();

                }
                baglanti.Close();
                return satis;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

            
        }
        //sipariş güncelleme(biriş tarihi uzatma)
        public void satisGuncelle(int id, DateTime bittar, string saat)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE siparis SET bittar = @bittar, bitsaat = @saat, degisim += '-gun,saat uzatıldı'  where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@bittar", bittar);
                komut.Parameters.AddWithValue("@saat",saat);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        //siparişin son tarihinden önce cihazı kapatma
        public void satisKapat(int id,string role,string no)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE siparis SET statu = 'false', degisim += '-kapatıldı'  where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                //satış kapatma
                sqlQuery.GetKontrol(2, role, no);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        //klimanın nosunu değiştirme
        public void klimanoDegistir(int id, int klimano)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE siparis SET klimano = @klimano, degisim += '-klimano degistirildi'  where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@klimano", klimano);
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
