
namespace MAVA.Forms
{
    partial class CihazTanimlaForm
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
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.role,
            this.ip,
            this.port});
            this.dtGrdViewCihazlar.Location = new System.Drawing.Point(4, 47);
            this.dtGrdViewCihazlar.MultiSelect = false;
            this.dtGrdViewCihazlar.Name = "dtGrdViewCihazlar";
            this.dtGrdViewCihazlar.RowHeadersWidth = 15;
            this.dtGrdViewCihazlar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrdViewCihazlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewCihazlar.Size = new System.Drawing.Size(783, 499);
            this.dtGrdViewCihazlar.TabIndex = 9;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.HeaderText = "ROLE";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ip.HeaderText = "IP";
            this.ip.MinimumWidth = 6;
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // port
            // 
            this.port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.port.HeaderText = "PORT";
            this.port.MinimumWidth = 6;
            this.port.Name = "port";
            this.port.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 38);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // CihazTanimlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mavi_renkli_arka_plan_duvar_kagidi_blue_color_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 558);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtGrdViewCihazlar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CihazTanimlaForm";
            this.Load += new System.EventHandler(this.CihazTanimlaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewCihazlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrdViewCihazlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}