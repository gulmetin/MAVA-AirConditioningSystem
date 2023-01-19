using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using MAVA.Entitys;
using System.Configuration;

namespace MAVA.SqlQuerys
{
    class FiyatTanimlaKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz

        //Fiyat Tanimlama
        public List<Price> getAllPrice()
        {
            List<Price> prices = new List<Price>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from fiyatlar", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Price price = new Price();
                    price.id = Convert.ToInt32(read["id"]);
                    price.gun = Convert.ToInt32(read["gun"]);
                    price.tl = Convert.ToInt32(read["TL"]);
                    price.gbp = Convert.ToInt32(read["GBP"]);
                    price.euro = Convert.ToInt32(read["EURO"]);
                    price.usd = Convert.ToInt32(read["USD"]);
                    price.baslik = read["baslik"].ToString();
                    prices.Add(price);

                }
                baglanti.Close();
                return prices;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        public void removePrice(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM fiyatlar WHERE id= @id", baglanti);
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

        public void addPrice(Price price)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO fiyatlar (gun,baslik,TL,GBP,EURO,USD,OTELKODU,SUBEKODU) VALUES " +
                    "(@gun,@baslik,@tl,@gbp,@euro,@usd,@OTELKODU,@SUBEKODU)", baglanti);
                komut.Parameters.AddWithValue("@gun", price.gun);
                komut.Parameters.AddWithValue("@baslik", price.baslik);
                komut.Parameters.AddWithValue("@tl", price.tl);
                komut.Parameters.AddWithValue("@gbp", price.gbp);
                komut.Parameters.AddWithValue("@euro", price.euro);
                komut.Parameters.AddWithValue("@usd", price.usd);
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

        public void uptadePrice(Price price)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE fiyatlar SET gun = @gun, baslik = @baslik, TL = @tl, GBP = @gbp, EURO = @euro, USD = @usd " +
                    "where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", price.id);
                komut.Parameters.AddWithValue("@gun", price.gun);
                komut.Parameters.AddWithValue("@baslik", price.baslik);
                komut.Parameters.AddWithValue("@tl", price.tl);
                komut.Parameters.AddWithValue("@gbp", price.gbp);
                komut.Parameters.AddWithValue("@euro", price.euro);
                komut.Parameters.AddWithValue("@usd", price.usd);
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
