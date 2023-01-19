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
    public partial class YeniKullanici : Form
    {
        AnaSayfaKontrolSql anasayfaQrys = new AnaSayfaKontrolSql();
        KullanicilarKontrolSql sqlQrys = new KullanicilarKontrolSql();
       
        List<Page> yetkipages = new List<Page>();
        public User userr = new User();

        public KullanicilarForm frm;
        public int number = 0;
        public YeniKullanici()
        {
            InitializeComponent();
            Yetki_Tree_Tanimlama(anasayfaQrys.getAllPage());
        }

        private void YeniKullanici_Load(object sender, EventArgs e)
        {
            //guncelle
            if (number == 2)
            {

                yetkipages = anasayfaQrys.getusersyetki(userr.id);
                ad_txtbox.Text = userr.ad;
                soyad_txtbox.Text = userr.soyad;
                departman_txtbox.Text = userr.departman;
                tel_txtbox.Text = userr.tel;
                mail_txtbox.Text = userr.mail;
                kadi_txtbox.Text = userr.kadi;
                sifre_txtbox.Text = userr.sifre;

                for(int i =0; i< yetki_tree.Nodes.Count;i++)
                {
                    foreach (Page page in yetkipages)
                    {
                        if (yetki_tree.Nodes[i].Text == page.adi)
                        {
                            yetki_tree.Nodes[i].Checked = true;
                            yetki_tree.Nodes[i].Nodes[0].Checked = page.ekle;
                            yetki_tree.Nodes[i].Nodes[1].Checked = page.cikar;
                            yetki_tree.Nodes[i].Nodes[2].Checked = page.guncelle;
                        }
                    }
                }
            }
            
        }

        //yetki listesi için treeView oluşturur
        private void Yetki_Tree_Tanimlama(List<Page> pages)
        {
            yetki_tree.BeginUpdate();
            for (int i = 0; i < pages.Count; i++)
            {
                yetki_tree.Nodes.Add(pages[i].adi);
                yetki_tree.Nodes[i].Nodes.Add("Ekleme");
                yetki_tree.Nodes[i].Nodes.Add("Çıkarma");
                yetki_tree.Nodes[i].Nodes.Add("Güncelleme");
            }
            yetki_tree.EndUpdate();
        }

        //ekle butonunun kontrolü
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if(kadi_txtbox.Text=="" && sifre_txtbox.Text=="")
            {
                MessageBox.Show("Kullanici adi ve sifreyi bos bırakmayınız");
            }
            else
            { 
                //ekleme
                if (number == 1)
                {
                    User user = new User();
                    user.ad = ad_txtbox.Text;
                    user.soyad = soyad_txtbox.Text;
                    user.departman = departman_txtbox.Text;
                    user.tel = tel_txtbox.Text;
                    user.mail = mail_txtbox.Text;
                    user.kadi = kadi_txtbox.Text;
                    user.sifre = sifre_txtbox.Text;
                    user.yetki = get_checkedNodes(anasayfaQrys.getAllPage());

                    sqlQrys.addUser(user);
                    MessageBox.Show("Yeni kullanıcı eklendi!");
                }
                //guncelleme
                else if (number == 2)
                {
                    userr.ad = ad_txtbox.Text;
                    userr.soyad = soyad_txtbox.Text;
                    userr.departman = departman_txtbox.Text;
                    userr.tel = tel_txtbox.Text;
                    userr.mail = mail_txtbox.Text;
                    userr.kadi = kadi_txtbox.Text;
                    userr.sifre = sifre_txtbox.Text;
                    userr.yetki = get_checkedNodes(anasayfaQrys.getAllPage());
                    sqlQrys.uptadeUser(userr);
                    MessageBox.Show("Kullanıcı Güncellendi!");
                }
                
                frm.dtgrdGuncelle();
                this.Close();
            }
        }

        //yetki için page listesi oluşturur ve treeviewdan değerleri alır
        private string get_checkedNodes(List<Page> pages)
        {
            List<Page> s = new List<Page>();
            foreach (TreeNode myNode in yetki_tree.Nodes)
            {
                // Check whether the tree node is checked.
                if (myNode.Checked)
                {
                    foreach(Page page in pages)
                    {
                        if (myNode.Text.ToString() == page.adi)
                        {
                            page.ekle = myNode.Nodes[0].Checked;
                            page.cikar = myNode.Nodes[1].Checked;
                            page.guncelle = myNode.Nodes[2].Checked;
                            s.Add(page);
                        }
                    }
                }

            }
            return get_yetki_string(s);
        }

        //yetki stringinin json halini alır
        private string get_yetki_string(List<Page> pages)
        {
            string s="{";
            for (int i = 0; i < pages.Count; i++)
            {
                if(pages[i].ekle==true && pages[i].cikar==true && pages[i].guncelle == true)
                {
                    s = s + "\"" + pages[i].id + "\":{sayfaid:\"" + pages[i].id + "\"}";
                }
                else 
                {
                    s = s + "\"" + pages[i].id + "\":{sayfaid:\"" + pages[i].id + "\",\"C\":\"" + pages[i].cikar + "\",\"E\":\"" + pages[i].ekle + "\",\"D\":\"" + pages[i].guncelle + "\"}";
                }
                if (i != pages.Count - 1)
                {
                    s = s + ",";
                }
            }
            s = s + "}";
            return s;
        }


        //root checkboxlara tıklandıktan sonra düğümleri için de aynı check değeri atanır.
        private void yetki_tree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
            {
                node.Checked = e.Node.Checked;
            }
        }
    }
}