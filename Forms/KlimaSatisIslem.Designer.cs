
namespace MAVA.Forms
{
    partial class KlimaSatisIslem
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doviz_combobox = new System.Windows.Forms.ComboBox();
            this.gun_combobox = new System.Windows.Forms.ComboBox();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(72, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "DÖVİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "GÜN SAYISI";
            // 
            // doviz_combobox
            // 
            this.doviz_combobox.FormattingEnabled = true;
            this.doviz_combobox.Location = new System.Drawing.Point(141, 57);
            this.doviz_combobox.Name = "doviz_combobox";
            this.doviz_combobox.Size = new System.Drawing.Size(273, 23);
            this.doviz_combobox.TabIndex = 21;
            this.doviz_combobox.SelectedIndexChanged += new System.EventHandler(this.doviz_combobox_SelectedIndexChanged);
            // 
            // gun_combobox
            // 
            this.gun_combobox.FormattingEnabled = true;
            this.gun_combobox.Location = new System.Drawing.Point(141, 93);
            this.gun_combobox.Name = "gun_combobox";
            this.gun_combobox.Size = new System.Drawing.Size(273, 23);
            this.gun_combobox.TabIndex = 22;
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(203, 142);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(125, 31);
            this.kaydet_btn.TabIndex = 26;
            this.kaydet_btn.Text = "KAYDET";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // KlimaSatisIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAVA.Properties.Resources.mava_2;
            this.ClientSize = new System.Drawing.Size(525, 219);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.gun_combobox);
            this.Controls.Add(this.doviz_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "KlimaSatisIslem";
            this.Text = "KlimaSatisIslem";
            this.Load += new System.EventHandler(this.KlimaSatisIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doviz_combobox;
        private System.Windows.Forms.ComboBox gun_combobox;
        private System.Windows.Forms.Button kaydet_btn;
    }
}