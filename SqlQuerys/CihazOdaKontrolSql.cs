using System;
using System.Collections.Generic;
using System.Text;
using MAVA.Entitys;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MAVA.SqlQuerys
{
    class CihazOdaKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz

        //Cihaz Oda Tanımlama
        public List<Device> getAllDevice()
        {
            List<Device> devices = new List<Device>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from rodalar", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Device deviceS = new Device();
                    deviceS.id = Convert.ToInt32(read["id"]);
                    deviceS.odano = read["odano"].ToString();
                    deviceS.cihazno = read["role"].ToString();
                    deviceS.cihazport = read["role_input_no"].ToString();
                    deviceS.klimano = read["klimano"].ToString();
                    devices.Add(deviceS);

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

        public List<string> getRoomNumber()
        {
            try
            {
                baglanti.Open();
                List<string> rooms = new List<string>();
                SqlCommand komut = new SqlCommand("Select ODANO from ODALAR ", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise yetki değişkenini dolduruyor. yoksa yetki null kalıyor
                {
                    rooms.Add(read["odano"].ToString());
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

        public List<string> getDevicePortNumber()
        {
            try
            {
                baglanti.Open();
                List<string> ports = new List<string>();
                SqlCommand komut = new SqlCommand("Select no from role_input ", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise yetki değişkenini dolduruyor. yoksa yetki null kalıyor
                {
                    ports.Add(read["no"].ToString());
                }
                baglanti.Close();
                return ports;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

        }

        public List<string> getDeviceNo()
        {
            try
            {
                baglanti.Open();
                List<string> deviceno = new List<string>();
                SqlCommand komut = new SqlCommand("Select role from role ", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise yetki değişkenini dolduruyor. yoksa yetki null kalıyor
                {
                    deviceno.Add(read["role"].ToString());
                }
                baglanti.Close();
                return deviceno;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

        }

        public void addDevice(Device device)
        {
            string katno = getroomfloor(device.odano);
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO rodalar (odano,role,role_input_no,klimano,kat,OTELKODU,SUBEKODU) VALUES " +
                    "(@odano,@role,@role_input_no,@klimano,@kat,@OTELKODU,@SUBEKODU)", baglanti);
                komut.Parameters.AddWithValue("@odano", device.odano);
                komut.Parameters.AddWithValue("@role", device.cihazno);
                komut.Parameters.AddWithValue("@role_input_no", device.cihazport);
                komut.Parameters.AddWithValue("@klimano", device.klimano);
                komut.Parameters.AddWithValue("@kat", katno);
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

        public void removeDevice(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM rodalar WHERE id= @id", baglanti);
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

        public void uptadeDevice(Device device)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE rodalar SET odano = @odano, role = @role, role_input_no = @role_input_no, klimano = @klimano " +
                    "where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", device.id);
                komut.Parameters.AddWithValue("@odano", device.odano);
                komut.Parameters.AddWithValue("@role", device.cihazno);
                komut.Parameters.AddWithValue("@role_input_no", device.cihazport);
                komut.Parameters.AddWithValue("@klimano", device.klimano);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public string getroomfloor(string odano)
        {
            string katno = "NULL";
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT KAT FROM ODALAR WHERE ODANO= @odano", baglanti);
                komut.Parameters.AddWithValue("@odano", odano);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    katno = read["KAT"].ToString();
                }
                baglanti.Close();
                return katno;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        public List<string> getUsedPort(string role)
        {
            try
            {
                baglanti.Open();
                List<string> role_inputs = new List<string>();
                SqlCommand komut = new SqlCommand("Select role_input_no from rodalar where role = @role", baglanti);
                komut.Parameters.AddWithValue("@role", role);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise yetki değişkenini dolduruyor. yoksa yetki null kalıyor
                {
                    role_inputs.Add(read["role_input_no"].ToString());
                }
                baglanti.Close();
                return role_inputs;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }

        }
    }
}
