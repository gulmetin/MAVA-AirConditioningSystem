using MAVA.Entitys;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace MAVA.SqlQuerys
{
    class KlimaSatisKontrolSql
    {
        static SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz
        GetPostKontrol sqlQuery = new GetPostKontrol();
        Satis satis = new Satis();
        WebBrowser webPage = new WebBrowser();

        public List<string> getDay_Price(string doviz)
        {
            List<string> list = new List<string>();
            try
            {
                baglanti.Open();
                List<string> rooms = new List<string>();
                SqlCommand komut = new SqlCommand("Select* from fiyatlar", baglanti);
                //komut.Parameters.AddWithValue("@doviz", doviz);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    list.Add(read["gun"].ToString() + " GUN -> " + read[doviz].ToString() + " " + doviz);
                }
                baglanti.Close();
                return list;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

        }

        //yeni sipariş oluşturma
        public void addSatis(Satis satis1)
        {
            satis = satis1;
            fillsatisinfo();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO siparis (odano,role,role_port,klimano,tutar,doviz,bastar,bittar,bitsaat,statu,OTELKODU,SUBEKODU,degisim) VALUES " +
                    "(@odano,@role,@role_port,@klimano,@tutar,@doviz,@bastar,@bittar,@bitsaat,@statu,@OTELKODU,@SUBEKODU,@degisim)", baglanti);
                komut.Parameters.AddWithValue("@odano", satis1.odano);
                komut.Parameters.AddWithValue("@role", satis1.cihazno);
                komut.Parameters.AddWithValue("@role_port", satis1.cihazport);
                komut.Parameters.AddWithValue("@klimano", satis1.klimano);
                komut.Parameters.AddWithValue("@tutar", satis1.tutar);
                komut.Parameters.AddWithValue("@doviz", satis1.doviz);
                komut.Parameters.AddWithValue("@bastar", satis1.bastar);
                komut.Parameters.AddWithValue("@bittar", satis1.bittar);
                komut.Parameters.AddWithValue("@bitsaat", satis1.bitsaat);
                komut.Parameters.AddWithValue("@statu", satis1.statu);
                komut.Parameters.AddWithValue("@degisim", "acıldı");
                komut.Parameters.AddWithValue("@OTELKODU", ConfigurationManager.AppSettings["OTELKODU"]);
                komut.Parameters.AddWithValue("@SUBEKODU", ConfigurationManager.AppSettings["SUBEKODU"]);
                komut.ExecuteNonQuery();
                baglanti.Close();

                //cihaz açma
                sqlQuery.GetKontrol(1, satis1.cihazno, satis1.cihazport);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        //boş kalan satış bilgilerini doldurur
        private void fillsatisinfo()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from rodalar where id = @id ", baglanti);
                komut.Parameters.AddWithValue("@id", satis.id);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    satis.odano = read["odano"].ToString();
                    satis.cihazno = read["role"].ToString();
                    satis.cihazport = read["role_input_no"].ToString();
                    satis.klimano = read["klimano"].ToString();
                }
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        //satış yapılabilen bütün cihazların listesini döndürür
        public List<ButonDevice> getAllButonDevice()
        {
            List<ButonDevice> devices = new List<ButonDevice>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from rodalar", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    ButonDevice deviceS = new ButonDevice();
                    deviceS.id = Convert.ToInt32(read["id"]);
                    deviceS.odano = read["odano"].ToString();
                    deviceS.cihazno = read["role"].ToString();
                    deviceS.cihazport = read["role_input_no"].ToString();
                    deviceS.klimano = read["klimano"].ToString();
                    deviceS.durum = "BOŞ";
                    deviceS.renk = Color.Blue;
                    devices.Add(deviceS);

                }
                baglanti.Close();
                StatuKontrol();
                sqlQuery.OpenPortKontrol();
                //doluluk kontrolü
                baglanti.Open();
                foreach (ButonDevice d in devices)
                {
                    SqlCommand komut1 = new SqlCommand("Select* from siparis where odano = @odano AND klimano = @klimano AND statu = @statu ", baglanti);
                    komut1.Parameters.AddWithValue("@odano", d.odano);
                    komut1.Parameters.AddWithValue("@klimano", d.klimano);
                    komut1.Parameters.AddWithValue("@statu", "true");
                    SqlDataReader read1 = komut1.ExecuteReader();
                    while (read1.Read())
                    {
                        d.renk = Color.Green;
                        d.durum = "DOLU";
                        d.satisid = Convert.ToInt32(read1["id"]);
                    }
                    //bağlantı arızası durumu
                    if (false == sqlQuery.ipCheck(d.cihazno))
                    {
                        d.renk = Color.Red;
                    }
                }
                baglanti.Close();
                return devices;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        //comboboxta odanın diğer klimalarının nosuna ulaşmak için 
        public List<string> searchklimano(string odano, string klimano)
        {
            List<string> list = new List<string>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from rodalar where odano = @odano AND klimano != @klimano ", baglanti);
                komut.Parameters.AddWithValue("@odano", odano);
                komut.Parameters.AddWithValue("@klimano", klimano);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    list.Add(read["klimano"].ToString());
                }
                baglanti.Close();
                return list;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        
        //bitiş tarihi geçmiş satışların statüsünü false yapar
        public void StatuKontrol()
        {
            try
            {

                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("UPDATE siparis SET statu = 'false' WHERE bittar < @tarih AND statu = 'true' ", baglanti);
                komut1.Parameters.AddWithValue("@tarih", DateTime.Now.Date);
                komut1.ExecuteNonQuery();
                //  SqlDataReader read = komut1.ExecuteReader();
                /* while (read.Read())
                 {
                     //satış kapatma
                     sqlQuery.GetKontrol(2, read["role"].ToString(), read["klimano"].ToString());
                 }*/
                baglanti.Close();


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //proje her çalıştığında kapalı olma durumuna karşılık satışı aktif olan cihazları açar
        public void OpenCloseCheck()
        {
            try
            {
               
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from siparis", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    if (read["statu"].ToString() == "true")
                    {
                        sqlQuery.GetKontrol(1, read["role"].ToString(), read["klimano"].ToString());
                    }
                }
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        
        /*public void OpenClose()
        {
            try
            {
                List<OpenPort> prts = sqlQuery.returnPorts();
                foreach (OpenPort p in prts)
                {
                    if (p.statu == true)
                    {
                        var url = new Uri("http://"+p.ip+":"+p.port); // Textboxa yazılan username'i alarak url oluşturdum
                        var client = new WebClient();
                        var html = client.DownloadString(url);
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(html);
                        for (int tbl = 0; tbl < 2; tbl++)
                        {
                            for(int i = 1; i < 9; i++)
                            {
                                var veri = doc.DocumentNode.SelectNodes("/html/body/tabel[tbl]/tbody/tr[tr]/td[2]"); // siteden istedigim verinin kopyaladıgım xpath'ini buraya yapıştırdım
                                if (veri != null)
                                {
                                    MessageBox.Show("a");
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

        }*/
    }
}
