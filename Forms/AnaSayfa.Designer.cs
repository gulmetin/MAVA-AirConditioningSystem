
namespace MAVA.Forms
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tgdtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cihaz_tanimlama_panel = new System.Windows.Forms.Panel();
            this.gncllecihaztanimla_btn = new System.Windows.Forms.Button();
            this.eklecihaztanimla_btn = new System.Windows.Forms.Button();
            this.cikarcihaztanimla_btn = new System.Windows.Forms.Button();
            this.dtgrdViewCihazTanimla = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdytyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewCihazTanimla)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tgdtToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1151, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // tgdtToolStripMenuItem
            // 
            this.tgdtToolStripMenuItem.Name = "tgdtToolStripMenuItem";
            this.tgdtToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // cihaz_tanimlama_panel
            // 
            this.cihaz_tanimlama_panel.Location = new System.Drawing.Point(0, 0);
            this.cihaz_tanimlama_panel.Name = "cihaz_tanimlama_panel";
            this.cihaz_tanimlama_panel.Size = new System.Drawing.Size(200, 100);
            this.cihaz_tanimlama_panel.TabIndex = 0;
            // 
            // gncllecihaztanimla_btn
            // 
            this.gncllecihaztanimla_btn.Location = new System.Drawing.Point(0, 0);
            this.gncllecihaztanimla_btn.Name = "gncllecihaztanimla_btn";
            this.gncllecihaztanimla_btn.Size = new System.Drawing.Size(75, 23);
            this.gncllecihaztanimla_btn.TabIndex = 0;
            // 
            // eklecihaztanimla_btn
            // 
            this.eklecihaztanimla_btn.Location = new System.Drawing.Point(0, 0);
            this.eklecihaztanimla_btn.Name = "eklecihaztanimla_btn";
            this.eklecihaztanimla_btn.Size = new System.Drawing.Size(75, 23);
            this.eklecihaztanimla_btn.TabIndex = 0;
            // 
            // cikarcihaztanimla_btn
            // 
            this.cikarcihaztanimla_btn.Location = new System.Drawing.Point(0, 0);
            this.cikarcihaztanimla_btn.Name = "cikarcihaztanimla_btn";
            this.cikarcihaztanimla_btn.Size = new System.Drawing.Size(75, 23);
            this.cikarcihaztanimla_btn.TabIndex = 0;
            // 
            // dtgrdViewCihazTanimla
            // 
            this.dtgrdViewCihazTanimla.Location = new System.Drawing.Point(0, 0);
            this.dtgrdViewCihazTanimla.Name = "dtgrdViewCihazTanimla";
            this.dtgrdViewCihazTanimla.Size = new System.Drawing.Size(240, 150);
            this.dtgrdViewCihazTanimla.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // role
            // 
            this.role.Name = "role";
            // 
            // ip
            // 
            this.ip.Name = "ip";
            // 
            // port
            // 
            this.port.Name = "port";
            // 
            // tdytyToolStripMenuItem
            // 
            this.tdytyToolStripMenuItem.Name = "tdytyToolStripMenuItem";
            this.tdytyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 750);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnaSayfa";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewCihazTanimla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tgdtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tdytyToolStripMenuItem;
        private System.Windows.Forms.Panel cihaz_tanimlama_panel;
        private System.Windows.Forms.DataGridView dtgrdViewCihazTanimla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.Button gncllecihaztanimla_btn;
        private System.Windows.Forms.Button eklecihaztanimla_btn;
        private System.Windows.Forms.Button cikarcihaztanimla_btn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}