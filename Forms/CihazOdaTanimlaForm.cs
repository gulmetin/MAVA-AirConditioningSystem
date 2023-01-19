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
    public partial class CihazOdaTanimlaForm : Form
    {
        //Sql fonksiyonlarını kullanmak için o fonksiyonun bulunduğu sınıfın nesnesini oluşturuyoruz.
        CihazOdaKontrolSql sqlQrys = new CihazOdaKontrolSql();
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();
        //cihazın bilgilerini tutacağımız Device nesnesi global olarak oluşturuyoruz
        Device device = new Device();

        public CihazOdaTanimlaForm()
        {
            InitializeComponent();
        }

        private void CihazOdaTanimlaForm_Load(object sender, EventArgs e)
        {
            //admin kontrolü eğer userid 0 ise admindir. Bütün butonlar oluşturulur.
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
            //0dan farklıysa admin değildir
            else
            {
                //idmize göre yetkilerimizin bulunduğu sayfaların Page listesini alıyoruz
                List<Page> pages = anasayfaQrys.getpagelist();
                foreach (Page p in pages)
                {
                    //sayfaların içinden "Cihaz Oda Tanımlama" olanını buluyoruz
                    if (p.adi == "Cihaz Oda Tanımlama")
                    {
                        //ekle butonu için yeki kontrolü
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
                        //cikar butonu için yeki kontrolü
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
                        //guncelle butonu için yeki kontrolü
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

        private void ekleform_btn_Click(object sender, EventArgs e)
        {
            CihazOdaIslem ekleFrm = new CihazOdaIslem();
            //dtgrdGuncelle fonksiyonunu kullanmak için bu formu CihazOdaIslem formuna gönderiyoruz
            ekleFrm.anafrm = this;
            //ekleme olduğunu belirtmek için 1 gönderiyoruz
            ekleFrm.no = 1;
            ekleFrm.Show();
        }

        private void cikar_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewCihazlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                int id = Convert.ToInt32(dtGrdViewCihazlar.SelectedRows[0].Cells[0].Value);
                //seçilen cihazın idsini, cihazı silmek için parametre olarak gönderir.
                sqlQrys.removeDevice(id);
                MessageBox.Show("Başarıyla Silindi!");
                dtgrdGuncelle();
            }
        }

        private void gnclle_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewCihazlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                //secilen cihazın bilgilerini, oluşturduğumuz device nesnesine atıyoruz
                device.id = Convert.ToInt32(dtGrdViewCihazlar.SelectedRows[0].Cells[0].Value);
                device.odano = dtGrdViewCihazlar.SelectedRows[0].Cells[1].Value.ToString();
                device.cihazno = dtGrdViewCihazlar.SelectedRows[0].Cells[2].Value.ToString();
                device.cihazport = dtGrdViewCihazlar.SelectedRows[0].Cells[3].Value.ToString();
                device.klimano = dtGrdViewCihazlar.SelectedRows[0].Cells[4].Value.ToString();
                         
                CihazOdaIslem gnclleFrm = new CihazOdaIslem();
                //device nesnesini forma gönderiyoruz
                gnclleFrm.devicegnclle = device;
                //guncelleme olduğunu belirtmek için 2 gönderiyoruz
                gnclleFrm.no = 2;
                gnclleFrm.anafrm = this;
                gnclleFrm.Show();
            }            
        }

        public void dtgrdGuncelle()
        {
           dataGridViewCihazOdaListele(sqlQrys.getAllDevice());
        }                        
                                                    
        private void dataGridViewCihazOdaListele(List<Device> devices)
        {
            //Cihazları listeleme
            dtGrdViewCihazlar.Rows.Clear();
            for (int i = 0; i < devices.Count; i++)
            {
                dtGrdViewCihazlar.Rows.Add();
                dtGrdViewCihazlar.Rows[i].Cells[0].Value = devices[i].id;
                dtGrdViewCihazlar.Rows[i].Cells[1].Value = devices[i].odano;
                dtGrdViewCihazlar.Rows[i].Cells[2].Value = devices[i].cihazno;
                dtGrdViewCihazlar.Rows[i].Cells[3].Value = devices[i].cihazport;
                dtGrdViewCihazlar.Rows[i].Cells[4].Value = devices[i].klimano;
            }
        }

    }                                                                       
}
                                                                                                                          