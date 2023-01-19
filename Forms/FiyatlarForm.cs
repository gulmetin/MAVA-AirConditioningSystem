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
    public partial class FiyatlarForm : Form
    {
        FiyatTanimlaKontrolSql sqlQrys = new FiyatTanimlaKontrolSql();
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();
        Price price = new Price();
        public string adi;
        public FiyatlarForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.USERID == 0)
            {
                Button btn = new Button();
                btn.Width = 120;
                btn.Height = 30;
                btn.Text = "EKLE";
                btn.Name = "ekleform_btn";
                btn.Click += new EventHandler(ekleform_btn_Click);
                flowLayoutPanel1.Controls.Add(btn);
                Button btn1 = new Button();
                btn1.Width = 120;
                btn1.Height = 30;
                btn1.Text = "ÇIKAR";
                btn1.Name = "cikar_btn";
                btn1.Click += new EventHandler(cikar_btn_Click);
                flowLayoutPanel1.Controls.Add(btn1);
                Button btn2 = new Button();
                btn2.Width = 120;
                btn2.Height = 30;
                btn2.Text = "GÜNCELLE";
                btn2.Name = "gnclle_btn";
                btn2.Click += new EventHandler(gnclle_btn_Click);
                flowLayoutPanel1.Controls.Add(btn2);

            }
            else
            {
                List<Page> pages = anasayfaQrys.getpagelist();
                foreach (Page p in pages)
                {
                    if (p.adi == "Cihaz Oda Tanımlama")
                    {
                        if (p.ekle == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "EKLE";
                            btn.Name = "ekleform_btn";
                            btn.Click += new EventHandler(ekleform_btn_Click);
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                        if (p.cikar == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "ÇIKAR";
                            btn.Name = "cikar_btn";
                            btn.Click += new EventHandler(cikar_btn_Click);
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                        if (p.guncelle == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "GÜNCELLE";
                            btn.Name = "gnclle_btn";
                            btn.Click += new EventHandler(gnclle_btn_Click);
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                    }
                }
            }
            dtgrdGuncelle();
        }
        //listeleme fonksiyonunu çağırma
        public void dtgrdGuncelle()
        {
            dataGridViewFiyatListele(sqlQrys.getAllPrice());
        }
        //listeleme
        private void dataGridViewFiyatListele(List<Price> prices)
        {
            dtGrdViewFiyatlar.Rows.Clear();
            for (int i = 0; i < prices.Count; i++)
            {
                dtGrdViewFiyatlar.Rows.Add();
                dtGrdViewFiyatlar.Rows[i].Cells[0].Value = prices[i].id;
                dtGrdViewFiyatlar.Rows[i].Cells[1].Value = prices[i].gun;
                dtGrdViewFiyatlar.Rows[i].Cells[2].Value = prices[i].tl;
                dtGrdViewFiyatlar.Rows[i].Cells[3].Value = prices[i].gbp;
                dtGrdViewFiyatlar.Rows[i].Cells[4].Value = prices[i].euro;
                dtGrdViewFiyatlar.Rows[i].Cells[5].Value = prices[i].usd;
                dtGrdViewFiyatlar.Rows[i].Cells[6].Value = prices[i].baslik;
            }
        }

        //ekleme
        private void ekleform_btn_Click(object sender, EventArgs e)
        {
            FiyatlarIslem ekleFrm = new FiyatlarIslem();
            ekleFrm.anafrm = this;
            ekleFrm.no = 1;
            ekleFrm.Show();
        }

        //çıkarma
        private void cikar_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewFiyatlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                int id = Convert.ToInt32(dtGrdViewFiyatlar.SelectedRows[0].Cells[0].Value);
                sqlQrys.removePrice(id);
                MessageBox.Show("Başarıyla Silindi!");
                dtgrdGuncelle();
            }
        }

        //güncelleme
        private void gnclle_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewFiyatlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                price.id = Convert.ToInt32(dtGrdViewFiyatlar.SelectedRows[0].Cells[0].Value);
                price.gun = Convert.ToInt32(dtGrdViewFiyatlar.SelectedRows[0].Cells[1].Value.ToString());
                price.tl = Convert.ToInt32(dtGrdViewFiyatlar.SelectedRows[0].Cells[2].Value.ToString());
                price.gbp = Convert.ToInt32(dtGrdViewFiyatlar.SelectedRows[0].Cells[3].Value.ToString());
                price.euro = Convert.ToInt32(dtGrdViewFiyatlar.SelectedRows[0].Cells[4].Value.ToString());
                price.usd = Convert.ToInt32(dtGrdViewFiyatlar.SelectedRows[0].Cells[5].Value.ToString());
                price.baslik = dtGrdViewFiyatlar.SelectedRows[0].Cells[6].Value.ToString();

                FiyatlarIslem gnclleFrm = new FiyatlarIslem();
                gnclleFrm.price = price;
                gnclleFrm.no = 2;
                gnclleFrm.anafrm = this;
                gnclleFrm.Show();
            }
        }

    }
}
