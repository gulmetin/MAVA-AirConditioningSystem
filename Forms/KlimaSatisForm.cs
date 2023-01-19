using MAVA.SqlQuerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MAVA.Entitys;
using System.Threading;

namespace MAVA.Forms
{
    public partial class KlimaSatisForm : Form
    {
        KlimaSatisKontrolSql sqlQuery = new KlimaSatisKontrolSql();
        GetPostKontrol sqlQuery1 = new GetPostKontrol();
        List<XButton> buttons = new List<XButton>();
        public KlimaSatisForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        

        //bütün cihazların listesi döndürülür
        List<ButonDevice> devices = sqlQuery.getAllButonDevice();

            foreach(ButonDevice d in devices)
            {
                //buton oluşturma
                XButton btn = new XButton();
                btn.Width = 120;
                btn.Height = 60;
                btn.Font = new Font("Georgia", 12);
                btn.Text = d.odano + "(" +d.klimano+")";
                btn.ForeColor = Color.White;
                btn.BackColor = d.renk;
                btn.satisid = d.satisid;
                btn.deviceid = d.id;
                btn.role = d.cihazno;
                btn.Name = d.id.ToString();
                btn.Click += new EventHandler(btn_Click);
                flowLayoutPanel1.Controls.Add(btn);
                buttons.Add(btn);
            }
            Thread thread = new Thread(new ThreadStart(btnKontrol));
            thread.Start();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            XButton btn = (XButton)sender;
            if(btn.BackColor == Color.Blue)
            {
                //yeni satış 
                KlimaSatisIslem form = new KlimaSatisIslem();
                form.id = btn.deviceid;
                form.Show();
                this.Close();
            }
            else if(btn.BackColor == Color.Green)
            {
                //aktif satış
                AktifSatisIslem form = new AktifSatisIslem();
                form.id = btn.satisid;
                form.Show();
                this.Close();
            }
            else if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Cihaz Arızalıdır.");
            }
        }


        //butonların renklerini 60 saniyede bir güncel duruma göre kontrol ediyor.
        private void btnKontrol()
        {
            while (true)
            {
                Thread.Sleep(60000);
                foreach (XButton xbtn in buttons)
                {
                    if (false == sqlQuery1.ipCheck(xbtn.role))
                    {
                        xbtn.BackColor = Color.Red;
                    }
                }
                
            }
        }
    }
}
