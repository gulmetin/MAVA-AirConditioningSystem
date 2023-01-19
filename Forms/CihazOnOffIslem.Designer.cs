
namespace MAVA.Forms
{
    partial class CihazOnOffIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CihazOnOffIslem));
            this.eklecihaztanimla_btn = new System.Windows.Forms.Button();
            this.off_txtbox = new System.Windows.Forms.TextBox();
            this.on_txtbox = new System.Windows.Forms.TextBox();
            this.no_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eklecihaztanimla_btn
            // 
            this.eklecihaztanimla_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eklecihaztanimla_btn.Image = ((System.Drawing.Image)(resources.GetObject("eklecihaztanimla_btn.Image")));
            this.eklecihaztanimla_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.eklecihaztanimla_btn.Location = new System.Drawing.Point(151, 141);
            this.eklecihaztanimla_btn.Name = "eklecihaztanimla_btn";
            this.eklecihaztanimla_btn.Size = new System.Drawing.Size(83, 33);
            this.eklecihaztanimla_btn.TabIndex = 27;
            this.eklecihaztanimla_btn.Text = "EKLE";
            this.eklecihaztanimla_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eklecihaztanimla_btn.UseVisualStyleBackColor = true;
            this.eklecihaztanimla_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // off_txtbox
            // 
            this.off_txtbox.Location = new System.Drawing.Point(109, 101);
            this.off_txtbox.Name = "off_txtbox";
            this.off_txtbox.Size = new System.Drawing.Size(168, 23);
            this.off_txtbox.TabIndex = 26;
            // 
            // on_txtbox
            // 
            this.on_txtbox.Location = new System.Drawing.Point(109, 69);
            this.on_txtbox.Name = "on_txtbox";
            this.on_txtbox.Size = new System.Drawing.Size(168, 23);
            this.on_txtbox.TabIndex = 25;
            // 
            // no_txtbox
            // 
            this.no_txtbox.Location = new System.Drawing.Point(109, 36);
            this.no_txtbox.Name = "no_txtbox";
            this.no_txtbox.Size = new System.Drawing.Size(168, 23);
            this.no_txtbox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "OFF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "ON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "NO";
            // 
            // CihazOnOffIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mava_2;
            this.ClientSize = new System.Drawing.Size(347, 191);
            this.Controls.Add(this.eklecihaztanimla_btn);
            this.Controls.Add(this.off_txtbox);
            this.Controls.Add(this.on_txtbox);
            this.Controls.Add(this.no_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CihazOnOffIslem";
            this.Load += new System.EventHandler(this.CihazOnOffIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eklecihaztanimla_btn;
        private System.Windows.Forms.TextBox off_txtbox;
        private System.Windows.Forms.TextBox on_txtbox;
        private System.Windows.Forms.TextBox no_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}