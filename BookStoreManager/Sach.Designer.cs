namespace BookStoreManager
{
    partial class Sach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBackground = new Guna.UI.WinForms.GunaPanel();
            this.labelSoluongdaban = new Guna.UI.WinForms.GunaLabel();
            this.richTextBoxTenSach = new System.Windows.Forms.RichTextBox();
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.labelGiaSach = new Guna.UI.WinForms.GunaLabel();
            this.picAnhSach = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackground.Controls.Add(this.labelSoluongdaban);
            this.panelBackground.Controls.Add(this.richTextBoxTenSach);
            this.panelBackground.Controls.Add(this.label);
            this.panelBackground.Controls.Add(this.labelGiaSach);
            this.panelBackground.Controls.Add(this.picAnhSach);
            this.panelBackground.Location = new System.Drawing.Point(16, 17);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(4);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(249, 336);
            this.panelBackground.TabIndex = 5;
            // 
            // labelSoluongdaban
            // 
            this.labelSoluongdaban.AutoSize = true;
            this.labelSoluongdaban.Font = new System.Drawing.Font("UTM Nyala", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoluongdaban.ForeColor = System.Drawing.Color.Navy;
            this.labelSoluongdaban.Location = new System.Drawing.Point(178, 302);
            this.labelSoluongdaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoluongdaban.Name = "labelSoluongdaban";
            this.labelSoluongdaban.Size = new System.Drawing.Size(22, 21);
            this.labelSoluongdaban.TabIndex = 5;
            this.labelSoluongdaban.Text = "10";
            // 
            // richTextBoxTenSach
            // 
            this.richTextBoxTenSach.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTenSach.Enabled = false;
            this.richTextBoxTenSach.Font = new System.Drawing.Font("UTM Nyala", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTenSach.Location = new System.Drawing.Point(21, 188);
            this.richTextBoxTenSach.Name = "richTextBoxTenSach";
            this.richTextBoxTenSach.Size = new System.Drawing.Size(209, 69);
            this.richTextBoxTenSach.TabIndex = 4;
            this.richTextBoxTenSach.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("UTM Nyala", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Navy;
            this.label.Location = new System.Drawing.Point(114, 302);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 21);
            this.label.TabIndex = 1;
            this.label.Text = "Đã bán:";
            // 
            // labelGiaSach
            // 
            this.labelGiaSach.AutoSize = true;
            this.labelGiaSach.Font = new System.Drawing.Font("UTM Nyala", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaSach.ForeColor = System.Drawing.Color.Navy;
            this.labelGiaSach.Location = new System.Drawing.Point(78, 267);
            this.labelGiaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGiaSach.Name = "labelGiaSach";
            this.labelGiaSach.Size = new System.Drawing.Size(31, 21);
            this.labelGiaSach.TabIndex = 3;
            this.labelGiaSach.Text = "Giá";
            // 
            // picAnhSach
            // 
            this.picAnhSach.BackgroundImage = global::BookStoreManager.Properties.Resources._4;
            this.picAnhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAnhSach.Location = new System.Drawing.Point(21, 4);
            this.picAnhSach.Margin = new System.Windows.Forms.Padding(4);
            this.picAnhSach.Name = "picAnhSach";
            this.picAnhSach.Size = new System.Drawing.Size(209, 177);
            this.picAnhSach.TabIndex = 0;
            this.picAnhSach.TabStop = false;
            this.picAnhSach.Click += new System.EventHandler(this.PicAnhSach_Click);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBackground);
            this.Name = "Sach";
            this.Size = new System.Drawing.Size(280, 370);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelBackground;
        private Guna.UI.WinForms.GunaLabel label;
        private Guna.UI.WinForms.GunaLabel labelGiaSach;
        public System.Windows.Forms.PictureBox picAnhSach;
        private System.Windows.Forms.RichTextBox richTextBoxTenSach;
        private Guna.UI.WinForms.GunaLabel labelSoluongdaban;
    }
}
