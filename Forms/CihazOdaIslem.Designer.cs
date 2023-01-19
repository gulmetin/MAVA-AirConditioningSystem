
namespace MAVA.Forms
{
    partial class CihazOdaIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CihazOdaIslem));
            this.klimano_cmbBox = new System.Windows.Forms.ComboBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.cihazport_cmbBox = new System.Windows.Forms.ComboBox();
            this.cihazno_cmbBox = new System.Windows.Forms.ComboBox();
            this.odano_cmbBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // klimano_cmbBox
            // 
            this.klimano_cmbBox.FormattingEnabled = true;
            this.klimano_cmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.klimano_cmbBox.Location = new System.Drawing.Point(208, 60);
            this.klimano_cmbBox.Name = "klimano_cmbBox";
            this.klimano_cmbBox.Size = new System.Drawing.Size(226, 23);
            this.klimano_cmbBox.TabIndex = 19;
            // 
            // ekle_btn
            // 
            this.ekle_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ekle_btn.Image = ((System.Drawing.Image)(resources.GetObject("ekle_btn.Image")));
            this.ekle_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ekle_btn.Location = new System.Drawing.Point(262, 170);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(134, 33);
            this.ekle_btn.TabIndex = 18;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // cihazport_cmbBox
            // 
            this.cihazport_cmbBox.FormattingEnabled = true;
            this.cihazport_cmbBox.Location = new System.Drawing.Point(208, 130);
            this.cihazport_cmbBox.Name = "cihazport_cmbBox";
            this.cihazport_cmbBox.Size = new System.Drawing.Size(226, 23);
            this.cihazport_cmbBox.TabIndex = 17;
            // 
            // cihazno_cmbBox
            // 
            this.cihazno_cmbBox.FormattingEnabled = true;
            this.cihazno_cmbBox.Location = new System.Drawing.Point(208, 92);
            this.cihazno_cmbBox.Name = "cihazno_cmbBox";
            this.cihazno_cmbBox.Size = new System.Drawing.Size(226, 23);
            this.cihazno_cmbBox.TabIndex = 16;
            this.cihazno_cmbBox.SelectedIndexChanged += new System.EventHandler(this.cihazno_cmbBox_SelectedIndexChanged);
            // 
            // odano_cmbBox
            // 
            this.odano_cmbBox.FormattingEnabled = true;
            this.odano_cmbBox.Location = new System.Drawing.Point(208, 24);
            this.odano_cmbBox.Name = "odano_cmbBox";
            this.odano_cmbBox.Size = new System.Drawing.Size(226, 23);
            this.odano_cmbBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(109, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "CİHAZ PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "KLİMA NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "CİHAZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ODA NO";
            // 
            // CihazOdaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 222);
            this.Controls.Add(this.klimano_cmbBox);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.cihazport_cmbBox);
            this.Controls.Add(this.cihazno_cmbBox);
            this.Controls.Add(this.odano_cmbBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CihazOdaIslem";
            this.Load += new System.EventHandler(this.CihazOdaIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox klimano_cmbBox;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.ComboBox cihazport_cmbBox;
        private System.Windows.Forms.ComboBox cihazno_cmbBox;
        private System.Windows.Forms.ComboBox odano_cmbBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}