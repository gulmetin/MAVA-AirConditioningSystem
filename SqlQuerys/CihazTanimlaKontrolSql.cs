using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using MAVA.Entitys;
using System.Configuration;

namespace MAVA.SqlQuerys
{
    class CihazTanimlaKontrolSql
    {
        static SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz

        // Cihaz Tanımlama
        public List<Role> getAllRole()
        {
            List<Role> roles = new List<Role>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from role", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Role role = new Role();
                    role.id = Convert.ToInt32(read["id"]);
                    role.role = read["role"].ToString();
                    role.ip = read["ip"].ToString();
                    role.port = read["port"].ToString();
                    roles.Add(role);

                }
                baglanti.Close();
                return roles;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        public void addRole(Role role)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO role (role,ip,port,OTELKODU,SUBEKODU) VALUES " +
                    "(@role,@ip,@port,@OTELKODU,@SUBEKODU)", baglanti);
                komut.Parameters.AddWithValue("@role", role.role);
                komut.Parameters.AddWithValue("@ip", role.ip);
                komut.Parameters.AddWithValue("@port", role.port);
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

        public void removeRole(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM role WHERE id= @id", baglanti);
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

        public void uptadeRole(Role role)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE role SET role = @role, ip = @ip, port = @port " +
                    "where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", role.id);
                komut.Parameters.AddWithValue("@role", role.role);
                komut.Parameters.AddWithValue("@ip", role.ip);
                komut.Parameters.AddWithValue("@port", role.port);
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
