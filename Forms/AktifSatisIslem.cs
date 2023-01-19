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
    public partial class AktifSatisIslem : Form
    {
        KlimaSatislariKontrolSql sqlQrys1 = new KlimaSatislariKontrolSql();
        KlimaSatisKontrolSql sqlQrys = new KlimaSatisKontrolSql();
        //gönderilen satis idsi
        public int id;
        Satis satis = new Satis();
        public AktifSatisIslem()
        {
            InitializeComponent();
            //geçerli tobControl sayfası
            this.AktifSatisTabControl.SelectedTab = DefaultPage;
            
        }

        //form ilk yüklendiğinde çalıştırılan fonksiyon
        private void AktifSatisIslem_Load(object sender, EventArgs e)
        {
            //gönderilen id ile o satışın bilgilerini gönderir
            satis = sqlQrys1.getSatis(id);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //gün uzatma radio buton
            this.AktifSatisTabControl.SelectedTab = GunUzatmaPage;
            blankbas.Text = satis.bastar.ToString();
            blankbit.Text = satis.bittar.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //satis kapatma radio buton
            this.AktifSatisTabControl.SelectedTab = SatisKapatmaPage;
            blank1.Text = satis.bastar.ToString();
            blank2.Text = satis.bittar.ToString();
            blank3.Text = satis.odano.ToString();
            blank4.Text = satis.tutar.ToString();
            blank5.Text = satis.doviz.ToString();
            blank6.Text = satis.cihazno.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //klima no değiştirme radio buton
            this.AktifSatisTabControl.SelectedTab = KlimaDegistirPage;
            blank_klimano.Text = satis.klimano.ToString();
            klimanodegistir_combobox.Items.Clear();
            foreach (string a in sqlQrys.searchklimano(satis.odano, satis.klimano))
            {
                klimanodegistir_combobox.Items.Add(a);
            }

        }

        private void gunuzat_btn_Click(object sender, EventArgs e)
        {
            

            satis.bittar = satis.bittar.AddDays(Convert.ToInt32(numeric_gun.Value));
            satis.bittar = satis.bittar.AddHours(Convert.ToInt32(numeric_saat.Value));
            satis.bittar = satis.bittar.AddMinutes(Convert.ToInt32(numeric_dakika.Value));

            satis.bitsaat = satis.bittar.ToLongTimeString();

            sqlQrys1.satisGuncelle(id, satis.bittar, satis.bitsaat);
            MessageBox.Show("Satış güncellenmiştir.");

            KlimaSatisForm klimasatis = new KlimaSatisForm();
            klimasatis.Show();
            this.Close();

        }

        private void satiskapat_btn_Click(object sender, EventArgs e)
        {
            sqlQrys1.satisKapat(id,satis.cihazno,satis.cihazport);
            MessageBox.Show("Satış kapatılmıştır.");

            KlimaSatisForm klimasatis = new KlimaSatisForm();
            klimasatis.Show();
            this.Close();
        }

        private void klimadegis_btn_Click(object sender, EventArgs e)
        {
            int klimano = Convert.ToInt32(klimanodegistir_combobox.SelectedItem);
            sqlQrys1.klimanoDegistir(id, klimano);
            MessageBox.Show("Klima no değiştirilmiştir.");

            KlimaSatisForm klimasatis = new KlimaSatisForm();
            klimasatis.Show();
            this.Close();
        }
    }
}
