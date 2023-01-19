
namespace MAVA.Forms
{
    partial class FiyatlarForm
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
            this.dtGrdViewFiyatlar = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewFiyatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdViewFiyatlar
            // 
            this.dtGrdViewFiyatlar.AllowUserToResizeRows = false;
            this.dtGrdViewFiyatlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewFiyatlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewFiyatlar.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdViewFiyatlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrdViewFiyatlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGrdViewFiyatlar.ColumnHeadersHeight = 30;
            this.dtGrdViewFiyatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGrdViewFiyatlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.gun,
            this.tl,
            this.gbp,
            this.euro,
            this.usd,
            this.baslik});
            this.dtGrdViewFiyatlar.Location = new System.Drawing.Point(2, 44);
            this.dtGrdViewFiyatlar.MultiSelect = false;
            this.dtGrdViewFiyatlar.Name = "dtGrdViewFiyatlar";
            this.dtGrdViewFiyatlar.RowHeadersWidth = 15;
            this.dtGrdViewFiyatlar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrdViewFiyatlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewFiyatlar.Size = new System.Drawing.Size(890, 528);
            this.dtGrdViewFiyatlar.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(888, 36);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.FillWeight = 177.665F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // gun
            // 
            this.gun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gun.FillWeight = 87.05584F;
            this.gun.HeaderText = "GUN";
            this.gun.MinimumWidth = 6;
            this.gun.Name = "gun";
            this.gun.ReadOnly = true;
            // 
            // tl
            // 
            this.tl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tl.FillWeight = 87.05584F;
            this.tl.HeaderText = "TL";
            this.tl.MinimumWidth = 6;
            this.tl.Name = "tl";
            this.tl.ReadOnly = true;
            // 
            // gbp
            // 
            this.gbp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gbp.FillWeight = 87.05584F;
            this.gbp.HeaderText = "GBP";
            this.gbp.MinimumWidth = 6;
            this.gbp.Name = "gbp";
            this.gbp.ReadOnly = true;
            // 
            // euro
            // 
            this.euro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.euro.FillWeight = 87.05584F;
            this.euro.HeaderText = "EURO";
            this.euro.MinimumWidth = 6;
            this.euro.Name = "euro";
            this.euro.ReadOnly = true;
            // 
            // usd
            // 
            this.usd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usd.FillWeight = 87.05584F;
            this.usd.HeaderText = "USD";
            this.usd.Name = "usd";
            // 
            // baslik
            // 
            this.baslik.FillWeight = 87.05584F;
            this.baslik.HeaderText = "BASLIK";
            this.baslik.Name = "baslik";
            // 
            // FiyatlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mavi_renkli_arka_plan_duvar_kagidi_blue_color_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 575);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtGrdViewFiyatlar);
            this.Name = "FiyatlarForm";
            this.Text = "FiyatlarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewFiyatlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdViewFiyatlar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gun;
        private System.Windows.Forms.DataGridViewTextBoxColumn tl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gbp;
        private System.Windows.Forms.DataGridViewTextBoxColumn euro;
        private System.Windows.Forms.DataGridViewTextBoxColumn usd;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslik;
    }
}