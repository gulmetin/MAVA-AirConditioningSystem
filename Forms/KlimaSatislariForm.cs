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
    public partial class KlimaSatislariForm : Form
    {
        KlimaSatislariKontrolSql sqlQrys = new KlimaSatislariKontrolSql();
        public KlimaSatislariForm()
        {
            InitializeComponent();
            dtgrdGuncelle();
        }

        public void dtgrdGuncelle()
        {
            dataGridViewSatislarListele(sqlQrys.getAllSatis());
        }

        //listeleme
        private void dataGridViewSatislarListele(List<Satis> satislar)
        {
            dataGridViewSatislar.Rows.Clear();
            for (int i = 0; i < satislar.Count; i++)
            {
                dataGridViewSatislar.Rows.Add();
                dataGridViewSatislar.Rows[i].Cells[0].Value = satislar[i].satisid;
                dataGridViewSatislar.Rows[i].Cells[1].Value = satislar[i].odano;
                dataGridViewSatislar.Rows[i].Cells[2].Value = satislar[i].statu;
                dataGridViewSatislar.Rows[i].Cells[3].Value = satislar[i].bastar;
                dataGridViewSatislar.Rows[i].Cells[4].Value = satislar[i].bittar;
                dataGridViewSatislar.Rows[i].Cells[5].Value = satislar[i].bitsaat;
                dataGridViewSatislar.Rows[i].Cells[6].Value = satislar[i].tutar;
                dataGridViewSatislar.Rows[i].Cells[7].Value = satislar[i].doviz;
                dataGridViewSatislar.Rows[i].Cells[8].Value = satislar[i].cihazno;
                dataGridViewSatislar.Rows[i].Cells[9].Value = satislar[i].cihazport;
                dataGridViewSatislar.Rows[i].Cells[10].Value = satislar[i].klimano;
                dataGridViewSatislar.Rows[i].Cells[11].Value = satislar[i].degisim;
            }
        }
    }
}
