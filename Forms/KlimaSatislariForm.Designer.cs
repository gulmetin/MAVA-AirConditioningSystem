
namespace MAVA.Forms
{
    partial class KlimaSatislariForm
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
            this.dataGridViewSatislar = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bastar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bittar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitsaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doviz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klimano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSatislar
            // 
            this.dataGridViewSatislar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSatislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatislar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSatislar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatislar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.odano,
            this.statu,
            this.bastar,
            this.bittar,
            this.bitsaat,
            this.tutar,
            this.doviz,
            this.role,
            this.port,
            this.klimano,
            this.degisim});
            this.dataGridViewSatislar.Location = new System.Drawing.Point(1, 12);
            this.dataGridViewSatislar.Name = "dataGridViewSatislar";
            this.dataGridViewSatislar.RowTemplate.Height = 25;
            this.dataGridViewSatislar.Size = new System.Drawing.Size(991, 557);
            this.dataGridViewSatislar.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // odano
            // 
            this.odano.FillWeight = 50F;
            this.odano.HeaderText = "ODA NO";
            this.odano.Name = "odano";
            // 
            // statu
            // 
            this.statu.HeaderText = "STATÜ";
            this.statu.Name = "statu";
            // 
            // bastar
            // 
            this.bastar.HeaderText = "BAS TARİH";
            this.bastar.Name = "bastar";
            // 
            // bittar
            // 
            this.bittar.HeaderText = "BİT TARİH";
            this.bittar.Name = "bittar";
            // 
            // bitsaat
            // 
            this.bitsaat.HeaderText = "BİT SAAT";
            this.bitsaat.Name = "bitsaat";
            // 
            // tutar
            // 
            this.tutar.FillWeight = 50F;
            this.tutar.HeaderText = "TUTAR";
            this.tutar.Name = "tutar";
            // 
            // doviz
            // 
            this.doviz.FillWeight = 50F;
            this.doviz.HeaderText = "DÖVİZ";
            this.doviz.Name = "doviz";
            // 
            // role
            // 
            this.role.FillWeight = 50F;
            this.role.HeaderText = "ROLE";
            this.role.Name = "role";
            // 
            // port
            // 
            this.port.FillWeight = 50F;
            this.port.HeaderText = "PORT";
            this.port.Name = "port";
            // 
            // klimano
            // 
            this.klimano.FillWeight = 50F;
            this.klimano.HeaderText = "KLİMA NO";
            this.klimano.Name = "klimano";
            // 
            // degisim
            // 
            this.degisim.FillWeight = 150F;
            this.degisim.HeaderText = "DEĞİŞİM";
            this.degisim.Name = "degisim";
            // 
            // KlimaSatislariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mavi_renkli_arka_plan_duvar_kagidi_blue_color_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 570);
            this.Controls.Add(this.dataGridViewSatislar);
            this.Name = "KlimaSatislariForm";
            this.Text = "KlimaSatislariForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSatislar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn odano;
        private System.Windows.Forms.DataGridViewTextBoxColumn statu;
        private System.Windows.Forms.DataGridViewTextBoxColumn bastar;
        private System.Windows.Forms.DataGridViewTextBoxColumn bittar;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitsaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn doviz;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewTextBoxColumn klimano;
        private System.Windows.Forms.DataGridViewTextBoxColumn degisim;
    }
}