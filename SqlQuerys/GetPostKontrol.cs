using MAVA.Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Linq;

namespace MAVA.SqlQuerys
{
    class GetPostKontrol
    {
        static SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz
        //sql fonksiyonlarının olduğu sınıfın nesnesini oluşturuyoruz
        CihazTanimlaKontrolSql sqlQuery = new CihazTanimlaKontrolSql();

        //değişkenlerimiz
        Role_input_kontrol item = new Role_input_kontrol();
        private static List<OpenPort> ports = new List<OpenPort>();
        WebBrowser webPage = new WebBrowser();

        public void GetKontrol(int islem, string role, string no)
        {
            //gönderiler parametrelere göre 
            item.role = role;
            item.no = no;
            item.id = Convert.ToInt32(no);

            try
            {
                //role numarasına göre ip ve port değerlerini alır ev
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT ip,port FROM role WHERE role= @role", baglanti);
                komut.Parameters.AddWithValue("@role", role);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    item.ip = read["ip"].ToString();
                    item.port = read["port"].ToString();
                }
                baglanti.Close();

                //gönderilen idye göre role_input değerlerini alır ve item nesnesine atar
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("SELECT* FROM role_input WHERE id= @id", baglanti);
                komut1.Parameters.AddWithValue("@id", item.id);
                SqlDataReader read1 = komut1.ExecuteReader();
                while (read1.Read())
                {
                    item.input_on = read1["input_on"].ToString();
                    item.input_off = read1["input_off"].ToString();
                }
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

            //islem kısmı için fonksiyonumuza item nesnesini gönderiyoruz
            Islem(islem);            
        }

        public void Islem(int islem)
        {
            //inputun içini temiliyoruz
            string input=" ";
            //islem 1 ise cihazın açılması
            if (islem == 1)
            {
                //cihazın açma değeri inputa aktarılır
                input = item.input_on;
            }
            //işlem 2 ise cihazın kapatılması
            else if (islem == 2)
            {
                //cihazın kapatma değeri inputa aktarılır
                input = item.input_off;
            }
            else
                MessageBox.Show("İslem Türü Hata!");

            //url tanımlıyoruz
            string url = "http://"+ item.ip + ":" + item.port + "/" + input;
            //webpage kısmına urlmizi gönderip arka kısımda açıyoruz böylelikle açma,kapama isteği yapılmış oluyor
            webPage.Navigate(url);

        }

        //fiziksel cihazlara erişim kontrolü
        public void OpenPortKontrol()
        {
            try
            {
                //kontrol için roleların hepsini diziye atıyoruz
                List<Role> roles = sqlQuery.getAllRole();
                foreach (Role r in roles)
                {
                    OpenPort p = new OpenPort();
                    p.id = Convert.ToInt32(r.role);
                    p.role = r.role;
                    p.port = r.port;
                    p.ip = r.ip;
                    //fiziksel cihazla bağlantısının kurulup kurulmadığının kontrolü
                    p.statu = IsDomainAlive(r.ip,Convert.ToInt32(r.port), 1);
                    //bilgileri alındıktan sonra listeye eklendi.
                    ports.Add(p);
                }               
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static bool IsDomainAlive(string aDomain,int port, int aTimeoutSeconds)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    var result = client.BeginConnect(aDomain, port, null, null);
                    
                    var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(aTimeoutSeconds));

                    if (!success)
                    {
                        //bağlantı yok
                        return false;
                    }

                    // bağlantı açıldı
                    client.EndConnect(result);
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        //gönderilen role numarasına göre bağlantı durumunu döndürür
        public bool ipCheck(string role)
        {
            foreach (OpenPort p in ports)
            {
                if (role == p.role)
                {
                    return p.statu;
                }
                
            }
            return false;
        }

        //güncel port listesini döndürür
        public List<OpenPort> returnPorts()
        {
            return ports.ToList();
        }
    }
}
