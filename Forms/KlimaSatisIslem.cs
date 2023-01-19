using MAVA.Entitys;
using MAVA.SqlQuerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MAVA.Forms
{
    public partial class KlimaSatisIslem : Form
    {
        KlimaSatisKontrolSql sqlQrys = new KlimaSatisKontrolSql();
        public int id;
        public KlimaSatisIslem()
        {
            InitializeComponent();
        }

        //döviz seçimi için manuel olarak döviz ekleme
        private void KlimaSatisIslem_Load(object sender, EventArgs e)
        {
            doviz_combobox.Items.Add("TL");
            doviz_combobox.Items.Add("GBP");
            doviz_combobox.Items.Add("EURO");
            doviz_combobox.Items.Add("USD");
            
        }

        //döviz seçimine göre fiyat getirme
        private void doviz_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gun_combobox.Items.Clear();
            foreach (string a in sqlQrys.getDay_Price(doviz_combobox.SelectedItem.ToString()))
            {
                gun_combobox.Items.Add(a);
            }
        }

        //seçilen döviz, gün ve fiyatla birlikte yeni satış oluşturma
        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.doviz = doviz_combobox.SelectedItem.ToString();

            string text = gun_combobox.SelectedItem.ToString();
            string[] splittext = text.Split();

            //baslangıç tarihi için şuanın tarihini alma ve bitiş tarihi için günü ekleme
            satis.bastar = DateTime.Now;
            satis.bittar = DateTime.Now.AddDays(Convert.ToInt32(splittext[0]));
            satis.bitsaat = DateTime.Now.ToLongTimeString();

            satis.id = id;
            satis.statu = "true";
            satis.tutar = Convert.ToInt32(splittext[3]);

            sqlQrys.addSatis(satis);
            MessageBox.Show("Satışınız başarıyla gerçekleşmiştir.");

            //klima satış formuna geri dönülmesi
            KlimaSatisForm klimasatis = new KlimaSatisForm();
            klimasatis.Show();
            this.Close();

        }

        
    }
}
