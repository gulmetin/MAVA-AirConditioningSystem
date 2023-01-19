
namespace MAVA.Forms
{
    partial class KullanicilarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGrdViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdViewKullanicilar
            // 
            this.dtGrdViewKullanicilar.AllowUserToResizeRows = false;
            this.dtGrdViewKullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdViewKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrdViewKullanicilar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGrdViewKullanicilar.ColumnHeadersHeight = 30;
            this.dtGrdViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGrdViewKullanicilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adsoyad,
            this.departman,
            this.tel,
            this.mail,
            this.kullanici_adi,
            this.sifre,
            this.yetki});
            this.dtGrdViewKullanicilar.Location = new System.Drawing.Point(2, 44);
            this.dtGrdViewKullanicilar.MultiSelect = false;
            this.dtGrdViewKullanicilar.Name = "dtGrdViewKullanicilar";
            this.dtGrdViewKullanicilar.RowHeadersWidth = 15;
            this.dtGrdViewKullanicilar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrdViewKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewKullanicilar.Size = new System.Drawing.Size(1186, 562);
            this.dtGrdViewKullanicilar.TabIndex = 10;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // adsoyad
            // 
            this.adsoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adsoyad.HeaderText = "Adı & Soyadı";
            this.adsoyad.MinimumWidth = 6;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.ReadOnly = true;
            // 
            // departman
            // 
            this.departman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departman.HeaderText = "Departman";
            this.departman.MinimumWidth = 6;
            this.departman.Name = "departman";
            this.departman.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tel.HeaderText = "Tel";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mail.HeaderText = "Mail";
            this.mail.MinimumWidth = 6;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullanici_adi.HeaderText = "Kullanici Adi";
            this.kullanici_adi.Name = "kullanici_adi";
            // 
            // sifre
            // 
            this.sifre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sifre.HeaderText = "Sifre";
            this.sifre.Name = "sifre";
            // 
            // yetki
            // 
            this.yetki.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yetki.HeaderText = "Yetki";
            this.yetki.Name = "yetki";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1181, 35);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // KullanicilarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mavi_renkli_arka_plan_duvar_kagidi_blue_color_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 611);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtGrdViewKullanicilar);
            this.Name = "KullanicilarForm";
            this.Text = "Kullanicilar";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdViewKullanicilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetki;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}