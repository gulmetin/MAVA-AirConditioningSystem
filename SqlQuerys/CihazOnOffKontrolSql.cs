using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using MAVA.Entitys;
using System.Configuration;

namespace MAVA.SqlQuerys
{
    class CihazOnOffKontrolSql
    {
        SqlConnection baglanti = new SqlConnection(Program.SqlConnectionString);//sql bağlantısını tanımlıyoruz

        //Fiyat Tanimlama
        public List<Role_input> getAllInput()
        {
            List<Role_input> inputs = new List<Role_input>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select* from role_input", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Role_input input = new Role_input();
                    input.id = Convert.ToInt32(read["id"]);
                    input.no = read["no"].ToString();
                    input.input_on = read["input_on"].ToString();
                    input.input_off = read["input_off"].ToString();
                    inputs.Add(input);

                }
                baglanti.Close();
                return inputs;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }


        public void addInput(Role_input input)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO role_input (input_on,input_off,no,OTELKODU,SUBEKODU) VALUES " +
                    "(@input_on,@v,@no,@OTELKODU,@SUBEKODU)", baglanti);
                komut.Parameters.AddWithValue("@input_on", input.input_on);
                komut.Parameters.AddWithValue("@input_off", input.input_off);
                komut.Parameters.AddWithValue("@no", input.no);
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

        public void removeInput(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM role_input WHERE id= @id", baglanti);
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

        public void uptadeInput(Role_input input)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE role_input SET input_on = @input_on, input_off = @input_off, no = @no " +
                    "where id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", input.id);
                komut.Parameters.AddWithValue("@input_on", input.input_on);
                komut.Parameters.AddWithValue("@input_off", input.input_off);
                komut.Parameters.AddWithValue("@no", input.no);
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
