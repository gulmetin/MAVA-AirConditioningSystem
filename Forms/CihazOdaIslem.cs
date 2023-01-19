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
    public partial class CihazOdaIslem : Form
    {
        CihazOdaKontrolSql sqlQrys = new CihazOdaKontrolSql();
        public Device devicegnclle = new Device();
        public CihazOdaTanimlaForm anafrm;
        public int no;

        public CihazOdaIslem()
        {

            InitializeComponent();
        }

        private void CihazOdaIslem_Load(object sender, EventArgs e)
        {
            cihazOdaTanimlama();
        }

        private void cihazOdaTanimlama()
        {
            //ekle kısmındaki oda combobox listeleme
            foreach (string a in sqlQrys.getRoomNumber())
            {
                odano_cmbBox.Items.Add(a);
            }
            
            //ekle kısmındaki cihazno combobox listeleme
            foreach (string a in sqlQrys.getDeviceNo())
            {
                cihazno_cmbBox.Items.Add(a);
            }

            if (no == 2)
            {
                //gönderilen cihazın  bilgilerinin ekrana getirilmesi
                ekle_btn.Text = "GUNCELLE";
                odano_cmbBox.Text = devicegnclle.odano.ToString();
                cihazport_cmbBox.Text = devicegnclle.cihazport.Trim();
                cihazno_cmbBox.Text = devicegnclle.cihazno.Trim();
                klimano_cmbBox.Text = devicegnclle.klimano.Trim();
            }
        }

        //ekle buton kontrolü
        private void ekle_btn_Click(object sender, EventArgs e) 
        {
            if(cihazport_cmbBox.Text==" ")
            {
                MessageBox.Show("Port Boş Bırakılamaz!");
            }
            else
            {
                if (no == 1)
                {
                    //yeni bir nesne oluşturup bilgileri ekliyoruz ve sql sorgusuyla veritabanına kaydediyoruz
                    Device device = new Device();
                    device.odano = odano_cmbBox.SelectedItem.ToString();
                    device.cihazno = cihazno_cmbBox.SelectedItem.ToString();
                    device.cihazport = cihazport_cmbBox.SelectedItem.ToString();
                    device.klimano = klimano_cmbBox.SelectedItem.ToString();
                    sqlQrys.addDevice(device);
                    MessageBox.Show("Başarıyla Eklendi!");
                    //listeyi tekrar güncelliyoruz
                    anafrm.dtgrdGuncelle();
                    this.Close();
                }
                else if (no == 2)
                {
                    devicegnclle.odano = odano_cmbBox.Text;
                    devicegnclle.cihazport = cihazport_cmbBox.Text;
                    devicegnclle.cihazno = cihazno_cmbBox.Text;
                    devicegnclle.klimano = klimano_cmbBox.Text;

                    sqlQrys.uptadeDevice(devicegnclle);
                    anafrm.dtgrdGuncelle();
                    this.Close();
                }
                else
                    MessageBox.Show("Hata!");
            }

        }

        private void cihazno_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sqlden kullanılan cihaznoların listesi
            List<string> used = sqlQrys.getUsedPort(cihazno_cmbBox.SelectedItem.ToString());
            //bütün cihaznoların listesi
            List<string> ports = sqlQrys.getDevicePortNumber();
            //kullanılan portlara . koyma
            foreach (string item in used)
            {
                for (int i = 0; i < ports.Count; i++)
                {
                    if(ports[i] == item)
                    {
                        ports[i]=".";
                    }
                }
            }
            cihazport_cmbBox.Items.Clear();
            //ekle kısmındaki cihazport combobox listeleme
            foreach (string a in ports)
                // "." olanlar dışındakileri item olarak comboboxa ekleme
            {
                if (a != ".")
                {
                    cihazport_cmbBox.Items.Add(a);
                }
            }

        }
    }
}
