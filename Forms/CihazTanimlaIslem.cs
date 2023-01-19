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
    public partial class CihazTanimlaIslem : Form
    {
        CihazTanimlaKontrolSql sqlQrys = new CihazTanimlaKontrolSql();
        public Role role = new Role();
        public CihazTanimlaForm anafrm;
        public int number=0;
        public CihazTanimlaIslem()
        {
            InitializeComponent();
        }

        private void CihazTanimlaIslem_Load(object sender, EventArgs e)
        {
            //ekle
            if (number == 1)
            {
                eklecihaztanimla_btn.Visible = true;
            }
            //guncelle
            else if (number == 2)
            {
                gncllecihaztanimla_btn.Visible = true;
                role_txtbox.Text= role.role;
                ip_txtbox.Text= role.ip;
                port_txtbox.Text= role.port;
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }
        //yeni eklemeyse bu buton gözükür
        private void eklecihaztanimla_btn_Click(object sender, EventArgs e)
        {
            //boş bırakmama kontrolü
            if(role_txtbox.Text =="" && ip_txtbox.Text =="" && port_txtbox.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız!");
            }
            else
            {
                role.role = role_txtbox.Text;
                role.ip = ip_txtbox.Text;
                role.port = port_txtbox.Text;
                sqlQrys.addRole(role);
            }
        }

        //güncellemeyse bu buton ekranda gözükür
        private void gncllecihaztanimla_btn_Click(object sender, EventArgs e)
        {
            role.role = role_txtbox.Text;
            role.ip = ip_txtbox.Text;
            role.port = port_txtbox.Text;

            sqlQrys.uptadeRole(role);
            anafrm.dtgrdGuncelle();
            this.Close();
        }
    }
}
