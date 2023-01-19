using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using MAVA.Entitys;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace MAVA.SqlQuerys
{
    class AnaSayfaKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz
        List<Page> pagesyetki = new List<Page>();

        //admin için menu strip dizisi oluşturur
        public Array gettingmenuStripAdmin()
        {
            int i = 0;
            string[,] Menu = new string[10,10];
            List<int> idler = new List<int>();

            baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
            SqlCommand komut = new SqlCommand("Select adi,id from modul", baglanti);//sorgumuz
            SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
            while (read.Read())
            {
                int id = (int)read["id"];
                Menu[i,0] = (string)read["adi"];
                idler.Add(id);
                i++;
            }
            baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor

            i = 0;
            foreach (int p in idler)
            {
                int j = 1;
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("Select * from link where modulid = @id", baglanti);
                komut1.Parameters.AddWithValue("@id",p);
                SqlDataReader read1 = komut1.ExecuteReader();
                while (read1.Read())
                {
                    Menu[i, j] = (string)read1["adi"];
                    j++;
                }
                baglanti.Close();
                i++;
            }

            return Menu;
        }

        //kullanıcılar için menu strip dizisi oluşturur
        public List<List<string>> gettingMenuStrip()
        {
            getyetki();
            //string[,] Menu = new string[10, 10];
            List<List<string>> menu = new List<List<string>>();
            string[] checkmodul = new string[10];
            int sayac = 0;

            foreach (Page p in pagesyetki)
            {
                if(checkmodul[p.modulid]==null)
                {
                    checkmodul[p.modulid] = Convert.ToString(sayac);
                    List<string> a = new List<string>();
                    a.Add(p.moduladi);
                    a.Add(p.adi);
                    sayac++;
                    menu.Add(a);
                }
                else
                {
                    int yer = Convert.ToInt32(checkmodul[p.modulid]);
                    menu[yer].Add(p.adi);
                }
            }
            return menu;
        }

        //yetkilendirilen sayfaların listesini oluşturur.
        private void getyetki()
        {
            
            baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
            SqlCommand komut = new SqlCommand("Select YETKI from OTELUSER where USERID = @id", baglanti);//sorgumuz
            komut.Parameters.AddWithValue("@id", Properties.Settings.Default.USERID);
            SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
            while (read.Read())
            {
                dynamic stuff = JObject.Parse((string)read["YETKI"]);
                foreach(dynamic st in stuff)
                {
                    Page newp = new Page();
                    newp.id = st.Value["sayfaid"];
                    if(st.Value["C"] == null && st.Value["E"] == null && st.Value["D"] == null)
                    {
                        newp.cikar = true;
                        newp.ekle = true;
                        newp.guncelle = true;
                    }
                    else
                    {
                        newp.cikar = st.Value["C"];
                        newp.ekle = st.Value["E"];
                        newp.guncelle = st.Value["D"];
                    } 
                    pagesyetki.Add(newp);
                }
                
            }
            baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor

            foreach(Page p in pagesyetki)
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut1 = new SqlCommand("Select * from link where id = @id", baglanti);
                SqlCommand komut2 = new SqlCommand("Select * from modul where id = @id", baglanti);
                komut1.Parameters.AddWithValue("@id", p.id);
                SqlDataReader read1 = komut1.ExecuteReader();
                while (read1.Read())
                {
                    p.adi= (string)read1["adi"];
                    p.modulid = Convert.ToInt32(read1["modulid"]);
                }
                //baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
                
                
                komut2.Parameters.AddWithValue("@id", p.modulid);
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    p.moduladi = (string)read2["adi"];
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor

            }
        }

        //bütün sayfaları alır (yetki tanımla treesi için)
        public List<Page> getAllPage()
        {
            List<Page> pages = new List<Page>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from link", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Page page = new Page();
                    page.id = Convert.ToInt32(read["id"]);
                    page.modulid = Convert.ToInt32(read["modulid"]);
                    page.adi = read["adi"].ToString();
                    page.moduladi = read["modul"].ToString();               
                    pages.Add(page);

                }
                baglanti.Close();
                return pages;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }


        //yetkilendirilen sayfaları döndürür
        public List<Page> getpagelist()
        {
            getyetki();
            return pagesyetki;
        }

        public List<Page> getusersyetki(int id)
        {
            List<Page> usersyetki = new List<Page>();
            baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
            SqlCommand komut = new SqlCommand("Select YETKI from OTELUSER where USERID = @id", baglanti);//sorgumuz
            komut.Parameters.AddWithValue("@id", id);
            SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
            while (read.Read())
            {
                dynamic stuff = JObject.Parse((string)read["YETKI"]);
                foreach (dynamic st in stuff)
                {
                    Page newp = new Page();
                    newp.id = st.Value["sayfaid"];
                    if (st.Value["C"] == null)
                    {
                        newp.cikar = true;
                        newp.ekle = true;
                        newp.guncelle = true;
                    }
                    else
                    {
                        newp.cikar = st.Value["C"];
                        newp.ekle = st.Value["E"];
                        newp.guncelle = st.Value["D"];
                    }
                    usersyetki.Add(newp);
                }

            }
            baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor

            foreach (Page p in usersyetki)
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut1 = new SqlCommand("Select * from link where id = @id", baglanti);
                komut1.Parameters.AddWithValue("@id", p.id);
                SqlDataReader read1 = komut1.ExecuteReader();
                while (read1.Read())
                {
                    p.adi = (string)read1["adi"];
                    p.modulid = Convert.ToInt32(read1["modulid"]);
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor

                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut2 = new SqlCommand("Select * from modul where id = @id", baglanti);
                komut2.Parameters.AddWithValue("@id", p.modulid);
                SqlDataReader read2 = komut1.ExecuteReader();
                while (read2.Read())
                {
                    p.moduladi = (string)read2["adi"];
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor     
            }
            return usersyetki;
        }
    }
}