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
    public partial class KullanicilarForm : Form
    {
        KullanicilarKontrolSql sqlQrys = new KullanicilarKontrolSql();
        User user = new User();
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();

        public KullanicilarForm()
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
                    if (p.adi == "Kullanıcılar")
                    {
                        if (p.ekle == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "YENİ KULLANICI";
                            btn.Name = "ekleform_btn";
                            btn.Click += new EventHandler(ekleform_btn_Click);
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                        if (p.cikar == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "KULLANICI ÇIKAR";
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

        public void dtgrdGuncelle()
        {
            dataGridViewKullaniciListele(sqlQrys.getAllUser());
        }
        //listeleme
        private void dataGridViewKullaniciListele(List<User> users)
        {
            dtGrdViewKullanicilar.Rows.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                //string sifre = new string('*', users[i].sifre.ToString().Length);
                dtGrdViewKullanicilar.Rows.Add();
                dtGrdViewKullanicilar.Rows[i].Cells[0].Value = users[i].id;
                dtGrdViewKullanicilar.Rows[i].Cells[1].Value = users[i].ad + " " + users[i].soyad;
                dtGrdViewKullanicilar.Rows[i].Cells[2].Value = users[i].departman;
                dtGrdViewKullanicilar.Rows[i].Cells[3].Value = users[i].tel;
                dtGrdViewKullanicilar.Rows[i].Cells[4].Value = users[i].mail;
                dtGrdViewKullanicilar.Rows[i].Cells[5].Value = users[i].kadi;
                dtGrdViewKullanicilar.Rows[i].Cells[6].Value = users[i].sifre;
                dtGrdViewKullanicilar.Rows[i].Cells[7].Value = users[i].yetki;
            }
        }

        //ekleme
        private void ekleform_btn_Click(object sender, EventArgs e)
        {
            YeniKullanici yeni = new YeniKullanici();
            yeni.frm = this;
            yeni.number = 1;
            yeni.Show();
        }
        //güncelleme
        private void gnclle_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden kullanici seçiniz!");
            }
            else
            {
                user.id = Convert.ToInt32(dtGrdViewKullanicilar.SelectedRows[0].Cells[0].Value);
                (user.ad,user.soyad) = adsoyadparse(dtGrdViewKullanicilar.SelectedRows[0].Cells[1].Value.ToString());
                user.departman = dtGrdViewKullanicilar.SelectedRows[0].Cells[2].Value.ToString();
                user.tel = dtGrdViewKullanicilar.SelectedRows[0].Cells[3].Value.ToString();
                user.mail = dtGrdViewKullanicilar.SelectedRows[0].Cells[4].Value.ToString();
                user.kadi = dtGrdViewKullanicilar.SelectedRows[0].Cells[5].Value.ToString();
                user.sifre = dtGrdViewKullanicilar.SelectedRows[0].Cells[6].Value.ToString();

                YeniKullanici yeni = new YeniKullanici();
                yeni.frm = this;
                yeni.userr = user;
                yeni.number = 2;
                yeni.Show();

            }
        }
        //ad soyad ayırma
        private (string,string) adsoyadparse(string v)
        {
            string ad = null, soyad=null;
            string[] words = v.Split();

            if(words.Length == 2)
            {
                ad = words[0];
                soyad = words[1];
            }
            else
            {
                for (int i=0; i < words.Length; i++)
                {
                    ad = ad + words[i];
                    if(i == words.Length - 1)
                    {
                        soyad = words[i];
                    }
                }
            }

            return (ad,soyad);
        }
        //çıkarma
        private void cikar_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden kullanici seçiniz!");
            }
            else
            {
                int id = Convert.ToInt32(dtGrdViewKullanicilar.SelectedRows[0].Cells[0].Value);
                sqlQrys.removeUser(id);
            }
        }

    }
}
