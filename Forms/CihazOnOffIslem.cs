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
    public partial class CihazOnOffIslem : Form
    {
        CihazOnOffKontrolSql sqlQrys = new CihazOnOffKontrolSql();
        public Role_input input = new Role_input();
        public CihazOnOffForm anafrm;
        public int no = 0;
        public CihazOnOffIslem()
        {
            InitializeComponent();
        }

        private void CihazOnOffIslem_Load(object sender, EventArgs e)
        {
            //güncellemeyse ilgili nesnenin bilgileri ekrana aktarılır
            if (no == 2)
            {
                
                no_txtbox.Text = input.no;
                on_txtbox.Text = input.input_on;
                off_txtbox.Text = input.input_off;
            }
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            //eklemeyse yeni nesne veritabanına eklenir
            if (no == 1)
            {
                Role_input role_i = new Role_input();
                role_i.no = no_txtbox.Text.Trim();
                role_i.input_on = on_txtbox.Text.Trim();
                role_i.input_off = off_txtbox.Text.Trim();
                sqlQrys.addInput(role_i);
                MessageBox.Show("Başarıyla Eklendi!");
                anafrm.dtgrdGuncelle();
                this.Close();
            }
            //güncellemeyse veritabanında da güncellenir
            else if (no == 2)
            {
                input.no = no_txtbox.Text.Trim();
                input.input_on = on_txtbox.Text.Trim();
                input.input_off = off_txtbox.Text.Trim();
                sqlQrys.uptadeInput(input);
                anafrm.dtgrdGuncelle();
                this.Close();
            }
            else
                MessageBox.Show("Hata!");

        }

    }
}
