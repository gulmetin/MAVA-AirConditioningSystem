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
    public partial class CihazTanimlaForm : Form
    {
        //Sql fonksiyonlarını kullanmak için o fonksiyonun bulunduğu sınıfın nesnesini oluşturuyoruz.
        CihazTanimlaKontrolSql sqlQrys = new CihazTanimlaKontrolSql();      
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();

        Role rolee = new Role();

        public CihazTanimlaForm()
        {
            InitializeComponent();
        }

        private void CihazTanimlaForm_Load(object sender, EventArgs e)
        {
            //admin kontrolü eğer userid 0 ise admindir. Bütün butonlar oluşturulur.
            if (Properties.Settings.Default.USERID == 0)
            {
                Button btn = new Button();
                btn.Width = 120;
                btn.Height = 30;
                btn.Text = "EKLE";
                btn.Name = "ekleform_btn";
                btn.Click += new EventHandler(eklecihaztanimla_btn_Click);
                flowLayoutPanel1.Controls.Add(btn);
                Button btn1 = new Button();
                btn1.Width = 120;
                btn1.Height = 30;
                btn1.Text = "ÇIKAR";
                btn1.Name = "cikar_btn";
                btn1.Click += new EventHandler(cikarcihaztanimla_btn_Click);
                flowLayoutPanel1.Controls.Add(btn1);
                Button btn2 = new Button();
                btn2.Width = 120;
                btn2.Height = 30;
                btn2.Text = "GÜNCELLE";
                btn2.Name = "gnclle_btn";
                btn2.Click += new EventHandler(gncllecihaztanimla_btn_Click);
                flowLayoutPanel1.Controls.Add(btn2);

            }
            //0dan farklıysa admin değildir
            else
            {
                List<Page> pages = anasayfaQrys.getpagelist();
                foreach (Page p in pages)
                {
                    if (p.adi == "Cihaz Tanımlama")
                    {
                        if (p.ekle == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "EKLE";
                            btn.Name = "ekleform_btn";
                            btn.Click += new EventHandler(eklecihaztanimla_btn_Click);
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                        if (p.cikar == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "ÇIKAR";
                            btn.Name = "cikar_btn";
                            btn.Click += new EventHandler(cikarcihaztanimla_btn_Click);
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                        if (p.guncelle == true)
                        {
                            Button btn = new Button();
                            btn.Width = 120;
                            btn.Height = 30;
                            btn.Text = "GÜNCELLE";
                            btn.Name = "gnclle_btn";
                            btn.Click += new EventHandler(gncllecihaztanimla_btn_Click);
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                    }
                }
            }
            dtgrdGuncelle();
        }

        private void dataGridViewCihazListele(List<Role> roles)
        {
            dtGrdViewCihazlar.Rows.Clear();
            for (int i = 0; i < roles.Count; i++)
            {
                dtGrdViewCihazlar.Rows.Add();
                dtGrdViewCihazlar.Rows[i].Cells[0].Value = roles[i].id;
                dtGrdViewCihazlar.Rows[i].Cells[1].Value = roles[i].role;
                dtGrdViewCihazlar.Rows[i].Cells[2].Value = roles[i].ip;
                dtGrdViewCihazlar.Rows[i].Cells[3].Value = roles[i].port;
            }
        }
        
        //Cihaz Tanımla
        private void eklecihaztanimla_btn_Click(object sender, EventArgs e)
        {
            CihazTanimlaIslem ekleFrm = new CihazTanimlaIslem();
            ekleFrm.anafrm = this;
            //ekleme olduğunu belirtmek için 1 gönderiyoruz
            ekleFrm.number = 1;
            ekleFrm.Show();
        }

        private void gncllecihaztanimla_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewCihazlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden role seçiniz!");
            }
            else
            {
                rolee.id = Convert.ToInt32(dtGrdViewCihazlar.SelectedRows[0].Cells[0].Value);
                rolee.role = dtGrdViewCihazlar.SelectedRows[0].Cells[1].Value.ToString();
                rolee.ip = dtGrdViewCihazlar.SelectedRows[0].Cells[2].Value.ToString();
                rolee.port = dtGrdViewCihazlar.SelectedRows[0].Cells[3].Value.ToString();

                CihazTanimlaIslem ekleFrm = new CihazTanimlaIslem();
                ekleFrm.anafrm = this;
                //guncelleme olduğunu belirtmek içiin 
                ekleFrm.number = 2;
                ekleFrm.role = rolee;
                ekleFrm.Show();
            }
        }

        private void cikarcihaztanimla_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewCihazlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                int id = Convert.ToInt32(dtGrdViewCihazlar.SelectedRows[0].Cells[0].Value);
                sqlQrys.removeRole(id);
                MessageBox.Show("Başarıyla Silindi!");
                dtgrdGuncelle();
            }
        }

        public void dtgrdGuncelle()
        {
            dataGridViewCihazListele(sqlQrys.getAllRole());
        }

    }
}
