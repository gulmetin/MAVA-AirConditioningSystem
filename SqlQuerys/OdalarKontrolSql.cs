using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using MAVA.Entitys;
using System.Configuration;
using System.Text;

namespace MAVA.SqlQuerys
{
    class OdalarKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz

        //Bütün odaların bilgisini Room sınıfından türetilen nesneye atayıp, bu nesnelerin listesini döndürür
        public List<Room> getAllRoom()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from ODALAR", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise yetki değişkenini dolduruyor. yoksa yetki null kalıyor
                {
                    Room room = new Room();
                    room.id = Convert.ToInt32(read["ODAID"]);
                    room.odano = read["ODANO"].ToString();
                    room.odatipi = read["ODATIPI"].ToString();
                    room.bina = read["BINA"].ToString();
                    room.kat = read["KAT"].ToString();
                    room.kisi = read["KISI"].ToString();
                    rooms.Add(room);

                }
                baglanti.Close();
                return rooms;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        //yeni bir oda ekleme
        public void addRoom(Room room)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO ODALAR (ODANO,ODATIPI,BINA,KAT,KISI,OTELKODU,SUBEKODU) VALUES " +
                    "(@ODANO,@ODATIPI,@BINA,@KAT,@KISI,@OTELKODU,@SUBEKODU)", baglanti);
                komut.Parameters.AddWithValue("@ODANO", room.odano);
                komut.Parameters.AddWithValue("@ODATIPI", room.odatipi);
                komut.Parameters.AddWithValue("@BINA", room.bina);
                komut.Parameters.AddWithValue("@KAT", room.kat);
                komut.Parameters.AddWithValue("@KISI", room.kisi);
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
        //oda çıkarma
        public void removeRoom(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM ODALAR WHERE ODAID= @id", baglanti);
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
        //oda güncelleme
        public void uptadeRoom(Room room)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE ODALAR SET ODANO = @ODANO, ODATIPI = @ODATIPI, BINA = @BINA, KAT = @KAT, KISI = @KISI " +
                    "where ODAID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", room.id);
                komut.Parameters.AddWithValue("@ODANO", room.odano);
                komut.Parameters.AddWithValue("@ODATIPI", room.odatipi);
                komut.Parameters.AddWithValue("@BINA", room.bina);
                komut.Parameters.AddWithValue("@KAT", room.kat);
                komut.Parameters.AddWithValue("@KISI", room.kisi);
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
