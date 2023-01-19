
namespace MAVA.Forms
{
    partial class CihazOdaTanimlaForm
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
            this.dtGrdViewCihazlar = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihaz_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihaz_port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klima_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewCihazlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdViewCihazlar
            // 
            this.dtGrdViewCihazlar.AllowUserToResizeRows = false;
            this.dtGrdViewCihazlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewCihazlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewCihazlar.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdViewCihazlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrdViewCihazlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGrdViewCihazlar.ColumnHeadersHeight = 30;
            this.dtGrdViewCihazlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGrdViewCihazlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.oda_no,
            this.cihaz_no,
            this.cihaz_port,
            this.klima_no});
            this.dtGrdViewCihazlar.Location = new System.Drawing.Point(0, 41);
            this.dtGrdViewCihazlar.MultiSelect = false;
            this.dtGrdViewCihazlar.Name = "dtGrdViewCihazlar";
            this.dtGrdViewCihazlar.RowHeadersWidth = 15;
            this.dtGrdViewCihazlar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrdViewCihazlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewCihazlar.Size = new System.Drawing.Size(988, 490);
            this.dtGrdViewCihazlar.TabIndex = 6;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Width = 43;
            // 
            // oda_no
            // 
            this.oda_no.HeaderText = "ODA NO";
            this.oda_no.MinimumWidth = 6;
            this.oda_no.Name = "oda_no";
            this.oda_no.ReadOnly = true;
            // 
            // cihaz_no
            // 
            this.cihaz_no.HeaderText = "CIHAZ NO";
            this.cihaz_no.MinimumWidth = 6;
            this.cihaz_no.Name = "cihaz_no";
            this.cihaz_no.ReadOnly = true;
            // 
            // cihaz_port
            // 
            this.cihaz_port.HeaderText = "CIHAZ PORT";
            this.cihaz_port.MinimumWidth = 6;
            this.cihaz_port.Name = "cihaz_port";
            this.cihaz_port.ReadOnly = true;
            // 
            // klima_no
            // 
            this.klima_no.HeaderText = "KLIMA NO";
            this.klima_no.MinimumWidth = 6;
            this.klima_no.Name = "klima_no";
            this.klima_no.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(988, 35);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // CihazOdaTanimlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mavi_renkli_arka_plan_duvar_kagidi_blue_color_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 531);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtGrdViewCihazlar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CihazOdaTanimlaForm";
            this.Load += new System.EventHandler(this.CihazOdaTanimlaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewCihazlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrdViewCihazlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn oda_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihaz_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihaz_port;
        private System.Windows.Forms.DataGridViewTextBoxColumn klima_no;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}