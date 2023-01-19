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
    public partial class CihazOnOffForm : Form
    {
        CihazOnOffKontrolSql sqlQrys = new CihazOnOffKontrolSql();
        Role_input input = new Role_input();
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();
        public CihazOnOffForm()
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
                    if (p.adi == "Cihaz On Off")
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

        public void dtgrdGuncelle()
        {
            dataGridViewFiyatListele(sqlQrys.getAllInput());
        }

        //listeleme
        private void dataGridViewFiyatListele(List<Role_input> inputs)
        {
            dtGrdViewOnOff.Rows.Clear();
            for (int i = 0; i < inputs.Count; i++)
            {
                dtGrdViewOnOff.Rows.Add();
                dtGrdViewOnOff.Rows[i].Cells[0].Value = inputs[i].id;
                dtGrdViewOnOff.Rows[i].Cells[1].Value = inputs[i].no;
                dtGrdViewOnOff.Rows[i].Cells[2].Value = inputs[i].input_on;
                dtGrdViewOnOff.Rows[i].Cells[3].Value = inputs[i].input_off;
            }
        }
        //buton ekleme
        private void ekleform_btn_Click(object sender, EventArgs e)
        {
            CihazOnOffIslem ekleFrm = new CihazOnOffIslem();
            ekleFrm.anafrm = this;
            ekleFrm.no = 1;
            ekleFrm.Show();
        }

        //buton çıkarma
        private void cikar_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewOnOff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                int id = Convert.ToInt32(dtGrdViewOnOff.SelectedRows[0].Cells[0].Value);
                sqlQrys.removeInput(id);
                MessageBox.Show("Başarıyla Silindi!");
                dtgrdGuncelle();
            }
        }
        //buton güncelleme
        private void gnclle_btn_Click(object sender, EventArgs e)
        {
            if (dtGrdViewOnOff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Önce listeden cihaz seçiniz!");
            }
            else
            {
                input.id = Convert.ToInt32(dtGrdViewOnOff.SelectedRows[0].Cells[0].Value);
                input.no = dtGrdViewOnOff.SelectedRows[0].Cells[1].Value.ToString();
                input.input_on = dtGrdViewOnOff.SelectedRows[0].Cells[2].Value.ToString();
                input.input_off = dtGrdViewOnOff.SelectedRows[0].Cells[3].Value.ToString();

                CihazOnOffIslem gnclleFrm = new CihazOnOffIslem();
                gnclleFrm.input = this.input;
                gnclleFrm.no = 2;
                gnclleFrm.anafrm = this;
                gnclleFrm.Show();
            }
        }

    }
}
