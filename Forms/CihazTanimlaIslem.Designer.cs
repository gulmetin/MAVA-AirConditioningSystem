
namespace MAVA.Forms
{
    partial class CihazTanimlaIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CihazTanimlaIslem));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.role_txtbox = new System.Windows.Forms.TextBox();
            this.ip_txtbox = new System.Windows.Forms.TextBox();
            this.port_txtbox = new System.Windows.Forms.TextBox();
            this.eklecihaztanimla_btn = new System.Windows.Forms.Button();
            this.gncllecihaztanimla_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "ROLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "PORT";
            // 
            // role_txtbox
            // 
            this.role_txtbox.Location = new System.Drawing.Point(136, 45);
            this.role_txtbox.Name = "role_txtbox";
            this.role_txtbox.Size = new System.Drawing.Size(168, 23);
            this.role_txtbox.TabIndex = 15;
            // 
            // ip_txtbox
            // 
            this.ip_txtbox.Location = new System.Drawing.Point(136, 78);
            this.ip_txtbox.Name = "ip_txtbox";
            this.ip_txtbox.Size = new System.Drawing.Size(168, 23);
            this.ip_txtbox.TabIndex = 16;
            // 
            // port_txtbox
            // 
            this.port_txtbox.Location = new System.Drawing.Point(136, 110);
            this.port_txtbox.Name = "port_txtbox";
            this.port_txtbox.Size = new System.Drawing.Size(168, 23);
            this.port_txtbox.TabIndex = 17;
            // 
            // eklecihaztanimla_btn
            // 
            this.eklecihaztanimla_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eklecihaztanimla_btn.Image = ((System.Drawing.Image)(resources.GetObject("eklecihaztanimla_btn.Image")));
            this.eklecihaztanimla_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.eklecihaztanimla_btn.Location = new System.Drawing.Point(178, 150);
            this.eklecihaztanimla_btn.Name = "eklecihaztanimla_btn";
            this.eklecihaztanimla_btn.Size = new System.Drawing.Size(83, 33);
            this.eklecihaztanimla_btn.TabIndex = 19;
            this.eklecihaztanimla_btn.Text = "EKLE";
            this.eklecihaztanimla_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eklecihaztanimla_btn.UseVisualStyleBackColor = true;
            this.eklecihaztanimla_btn.Visible = false;
            this.eklecihaztanimla_btn.Click += new System.EventHandler(this.eklecihaztanimla_btn_Click);
            // 
            // gncllecihaztanimla_btn
            // 
            this.gncllecihaztanimla_btn.BackColor = System.Drawing.Color.Transparent;
            this.gncllecihaztanimla_btn.Image = ((System.Drawing.Image)(resources.GetObject("gncllecihaztanimla_btn.Image")));
            this.gncllecihaztanimla_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gncllecihaztanimla_btn.Location = new System.Drawing.Point(162, 150);
            this.gncllecihaztanimla_btn.Name = "gncllecihaztanimla_btn";
            this.gncllecihaztanimla_btn.Size = new System.Drawing.Size(99, 35);
            this.gncllecihaztanimla_btn.TabIndex = 20;
            this.gncllecihaztanimla_btn.Text = "GÜNCELLE";
            this.gncllecihaztanimla_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gncllecihaztanimla_btn.UseVisualStyleBackColor = false;
            this.gncllecihaztanimla_btn.Visible = false;
            this.gncllecihaztanimla_btn.Click += new System.EventHandler(this.gncllecihaztanimla_btn_Click);
            // 
            // CihazTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 221);
            this.Controls.Add(this.gncllecihaztanimla_btn);
            this.Controls.Add(this.eklecihaztanimla_btn);
            this.Controls.Add(this.port_txtbox);
            this.Controls.Add(this.ip_txtbox);
            this.Controls.Add(this.role_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CihazTanimla";
            this.Load += new System.EventHandler(this.CihazTanimlaIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox role_txtbox;
        private System.Windows.Forms.TextBox ip_txtbox;
        private System.Windows.Forms.TextBox port_txtbox;
        private System.Windows.Forms.Button eklecihaztanimla_btn;
        private System.Windows.Forms.Button gncllecihaztanimla_btn;
    }
}