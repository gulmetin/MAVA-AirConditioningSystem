
namespace MAVA.Forms
{
    partial class OdalarForm
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
            this.dtGrdViewOdalar = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdViewOdalar
            // 
            this.dtGrdViewOdalar.AllowUserToResizeRows = false;
            this.dtGrdViewOdalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewOdalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewOdalar.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdViewOdalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrdViewOdalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGrdViewOdalar.ColumnHeadersHeight = 30;
            this.dtGrdViewOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGrdViewOdalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.oda_no,
            this.oda_tipi,
            this.kisi,
            this.bina,
            this.kat});
            this.dtGrdViewOdalar.Location = new System.Drawing.Point(5, 43);
            this.dtGrdViewOdalar.MultiSelect = false;
            this.dtGrdViewOdalar.Name = "dtGrdViewOdalar";
            this.dtGrdViewOdalar.RowHeadersWidth = 15;
            this.dtGrdViewOdalar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrdViewOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewOdalar.Size = new System.Drawing.Size(895, 571);
            this.dtGrdViewOdalar.TabIndex = 10;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // oda_no
            // 
            this.oda_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oda_no.HeaderText = "ODA NO";
            this.oda_no.MinimumWidth = 6;
            this.oda_no.Name = "oda_no";
            this.oda_no.ReadOnly = true;
            // 
            // oda_tipi
            // 
            this.oda_tipi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oda_tipi.HeaderText = "ODA TIPI";
            this.oda_tipi.MinimumWidth = 6;
            this.oda_tipi.Name = "oda_tipi";
            this.oda_tipi.ReadOnly = true;
            // 
            // kisi
            // 
            this.kisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kisi.HeaderText = "KISI";
            this.kisi.MinimumWidth = 6;
            this.kisi.Name = "kisi";
            this.kisi.ReadOnly = true;
            // 
            // bina
            // 
            this.bina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bina.HeaderText = "BINA";
            this.bina.Name = "bina";
            // 
            // kat
            // 
            this.kat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kat.HeaderText = "KAT";
            this.kat.Name = "kat";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(896, 35);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // OdalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mavi_renkli_arka_plan_duvar_kagidi_blue_color_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 616);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtGrdViewOdalar);
            this.Name = "OdalarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewOdalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdViewOdalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn oda_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn oda_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bina;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}