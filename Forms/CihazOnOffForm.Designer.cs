
namespace MAVA.Forms
{
    partial class CihazOnOffForm
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
            this.dtGrdViewOnOff = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_off = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewOnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdViewOnOff
            // 
            this.dtGrdViewOnOff.AllowUserToResizeRows = false;
            this.dtGrdViewOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewOnOff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewOnOff.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdViewOnOff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrdViewOnOff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGrdViewOnOff.ColumnHeadersHeight = 30;
            this.dtGrdViewOnOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGrdViewOnOff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.no,
            this.role_on,
            this.role_off});
            this.dtGrdViewOnOff.Location = new System.Drawing.Point(2, 44);
            this.dtGrdViewOnOff.MultiSelect = false;
            this.dtGrdViewOnOff.Name = "dtGrdViewOnOff";
            this.dtGrdViewOnOff.RowHeadersWidth = 15;
            this.dtGrdViewOnOff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrdViewOnOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewOnOff.Size = new System.Drawing.Size(783, 464);
            this.dtGrdViewOnOff.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            // 
            // role_on
            // 
            this.role_on.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role_on.HeaderText = "ON";
            this.role_on.MinimumWidth = 6;
            this.role_on.Name = "role_on";
            this.role_on.ReadOnly = true;
            // 
            // role_off
            // 
            this.role_off.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role_off.HeaderText = "OFF";
            this.role_off.MinimumWidth = 6;
            this.role_off.Name = "role_off";
            this.role_off.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 39);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // CihazOnOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mavi_renkli_arka_plan_duvar_kagidi_blue_color_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 513);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtGrdViewOnOff);
            this.Name = "CihazOnOffForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewOnOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdViewOnOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_off;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}