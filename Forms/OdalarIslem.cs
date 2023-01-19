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
    public partial class OdalarIslem : Form
    {
        OdalarKontrolSql sqlQrys = new OdalarKontrolSql();
        public Room roomgnclle = new Room();
        public OdalarForm anafrm;
        public int no;
        public OdalarIslem()
        {
            InitializeComponent();
        }

        private void OdalarIslem_Load(object sender, EventArgs e)
        {
            cihazOdaTanimlama();
        }

        private void cihazOdaTanimlama()
        {
            if (no == 2)
            {
                ekle_btn.Text = "GUNCELLE";
                odano_txtbox.Text = roomgnclle.odano.ToString();
                odatipi_txtbox.Text = roomgnclle.odatipi.Trim();
                kisi_txtbox.Text = roomgnclle.kisi.Trim();
                bina_txtbox.Text = roomgnclle.bina.Trim();
                kat_txtbox.Text = roomgnclle.kat.ToString();
            }
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (no == 1)
            {
                Room room = new Room();
                room.odano = odano_txtbox.Text.Trim();
                room.odatipi = odatipi_txtbox.Text.Trim();
                room.kisi = kisi_txtbox.Text.Trim();
                room.bina = bina_txtbox.Text.Trim();
                room.kat = kat_txtbox.Text.Trim();
                sqlQrys.addRoom(room);
                MessageBox.Show("Başarıyla Eklendi!");
                anafrm.dtgrdGuncelle();
                this.Close();
            }
            else if (no == 2)
            {
                roomgnclle.odano = odano_txtbox.Text.Trim();
                roomgnclle.odatipi = odatipi_txtbox.Text.Trim();
                roomgnclle.kisi = kisi_txtbox.Text.Trim();
                roomgnclle.bina = bina_txtbox.Text.Trim();
                roomgnclle.kat = kat_txtbox.Text.Trim();

                sqlQrys.uptadeRoom(roomgnclle);
                anafrm.dtgrdGuncelle();
                this.Close();
            }
            else
                MessageBox.Show("Hata!");

        }
    }
}
