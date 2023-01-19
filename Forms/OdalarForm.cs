using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MAVA.Entitys;
using MAVA.SqlQuerys;

namespace MAVA.Forms
{
    public partial class OdalarForm : Form
    {
        OdalarKontrolSql sqlQrys = new OdalarKontrolSql();
        Room room = new Room();
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();

        public OdalarForm()
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
                    if (p.adi == "Odalar")
                    {
                        if (p.ekle==true)
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

        public void dtgrdGuncelle()
        {
            dataGridViewOdaListele(sqlQrys.getAllRoom());
        }
        private void dataGridViewOdaListele(List<Room> rooms)
        {
            dtGrdViewOdalar.Rows.Clear();
            for (int i = 0; i < rooms.Count; i++)
            {
                dtGrdViewOdalar.Rows.Add();
                dtGrdViewOdalar.Rows[i].Cells[0].Value = rooms[i].id;
                dtGrdViewOdalar.Rows[i].Cells[1].Value = rooms[i].odano;
                dtGrdViewOdalar.Rows[i].Cells[2].Value = rooms[i].odatipi;
                dtGrdViewOdalar.Rows[i].Cells[3].Value = rooms[i].kisi;
                dtGrdViewOdalar.Rows[i].Cells[4].Value = rooms[i].bina;
                dtGrdViewOdalar.Rows[i].Cells[5].Value = rooms[i].kat;
            }
        }

        private void ekleform_btn_Click(object sender, EventArgs e)
        {
            OdalarIslem ekleFrm = new OdalarIslem();
            ekleFrm.anafrm = this;
            ekleFrm.no = 1;
            ekleFrm.Show();
        }

        private void cikar_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                int id = Convert.ToInt32(dtGrdViewOdalar.SelectedRows[0].Cells[0].Value);
                sqlQrys.removeRoom(id);
                MessageBox.Show("Başarıyla Silindi!");
                dtgrdGuncelle();
            }
        }

        private void gnclle_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewOdalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                room.id = Convert.ToInt32(dtGrdViewOdalar.SelectedRows[0].Cells[0].Value);
                room.odano = dtGrdViewOdalar.SelectedRows[0].Cells[1].Value.ToString();
                room.odatipi = dtGrdViewOdalar.SelectedRows[0].Cells[2].Value.ToString();
                room.kisi = dtGrdViewOdalar.SelectedRows[0].Cells[3].Value.ToString();
                room.bina = dtGrdViewOdalar.SelectedRows[0].Cells[4].Value.ToString();
                room.kat= dtGrdViewOdalar.SelectedRows[0].Cells[5].Value.ToString();

                OdalarIslem gnclleFrm = new OdalarIslem();
                gnclleFrm.anafrm = this;
                gnclleFrm.roomgnclle = room;
                gnclleFrm.no = 2;
                gnclleFrm.Show();
            }
        }

    }

 
}
