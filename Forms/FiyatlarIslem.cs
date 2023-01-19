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
    public partial class FiyatlarIslem : Form
    {
        FiyatTanimlaKontrolSql sqlQrys = new FiyatTanimlaKontrolSql();
        public Price price = new Price();
        public FiyatlarForm anafrm;
        public int no;
        public FiyatlarIslem()
        {
            InitializeComponent();
        }

        private void FiyatlarIslem_Load(object sender, EventArgs e)
        {
            fiyatTanimlama();
        }
        private void fiyatTanimlama()
        {
            //güncellemeyse ilgili nesnenin bilgileri ekrana yazdırılır
            if (no == 2)
            {
                baslik_txtbox.Text = price.baslik.ToString();
                gun_txtbox.Text = price.gun.ToString();
                tl_txtbox.Text = price.tl.ToString();
                gbp_txtbox.Text = price.gbp.ToString();
                euro_txtbox.Text = price.euro.ToString();
                usd_txtbox.Text = price.usd.ToString();

            }

        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            //ekleme
            if (no == 1)
            {
                price.baslik = baslik_txtbox.Text;
                price.gun = Convert.ToInt32(gun_txtbox.Text);
                price.tl = Convert.ToInt32(tl_txtbox.Text);
                price.gbp = Convert.ToInt32(gbp_txtbox.Text);
                price.euro = Convert.ToInt32(euro_txtbox.Text);
                price.usd = Convert.ToInt32(usd_txtbox.Text);
                sqlQrys.addPrice(price);
                MessageBox.Show("Başarıyla Eklendi!");
                anafrm.dtgrdGuncelle();
                this.Close();
            }
            //güncelleme
            else if (no == 2)
            {
                price.baslik = baslik_txtbox.Text;
                price.gun = Convert.ToInt32(gun_txtbox.Text);
                price.tl = Convert.ToInt32(tl_txtbox.Text);
                price.gbp = Convert.ToInt32(gbp_txtbox.Text);
                price.euro = Convert.ToInt32(euro_txtbox.Text);
                price.usd = Convert.ToInt32(usd_txtbox.Text);

                sqlQrys.uptadePrice(price);
                anafrm.dtgrdGuncelle();
                this.Close();
            }
            else
                MessageBox.Show("Hata!");
        }
    }

}
