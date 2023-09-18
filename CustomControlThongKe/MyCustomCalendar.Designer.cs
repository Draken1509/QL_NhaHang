namespace CustomControlThongKe
{
    partial class MyCustomCalendar
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
            this.myMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ngayKetThuc = new System.Windows.Forms.Label();
            this.lbl_ngayBatDau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongSoNgay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMonthCalendar
            // 
            this.myMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myMonthCalendar.Location = new System.Drawing.Point(195, 23);
            this.myMonthCalendar.Name = "myMonthCalendar";
            this.myMonthCalendar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.lblTongSoNgay);
            this.panel1.Controls.Add(this.lbl_ngayKetThuc);
            this.panel1.Controls.Add(this.lbl_ngayBatDau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 361);
            this.panel1.TabIndex = 1;
            // 
            // lbl_ngayKetThuc
            // 
            this.lbl_ngayKetThuc.AutoSize = true;
            this.lbl_ngayKetThuc.Location = new System.Drawing.Point(84, 121);
            this.lbl_ngayKetThuc.Name = "lbl_ngayKetThuc";
            this.lbl_ngayKetThuc.Size = new System.Drawing.Size(46, 17);
            this.lbl_ngayKetThuc.TabIndex = 1;
            this.lbl_ngayKetThuc.Text = "label4";
            // 
            // lbl_ngayBatDau
            // 
            this.lbl_ngayBatDau.AutoSize = true;
            this.lbl_ngayBatDau.Location = new System.Drawing.Point(84, 65);
            this.lbl_ngayBatDau.Name = "lbl_ngayBatDau";
            this.lbl_ngayBatDau.Size = new System.Drawing.Size(46, 17);
            this.lbl_ngayBatDau.TabIndex = 0;
            this.lbl_ngayBatDau.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỦY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "OK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTongSoNgay
            // 
            this.lblTongSoNgay.AutoSize = true;
            this.lblTongSoNgay.Location = new System.Drawing.Point(67, 214);
            this.lblTongSoNgay.Name = "lblTongSoNgay";
            this.lblTongSoNgay.Size = new System.Drawing.Size(91, 17);
            this.lblTongSoNgay.TabIndex = 2;
            this.lblTongSoNgay.Text = "TongSoNgay";
            // 
            // CustomCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myMonthCalendar);
            this.Name = "CustomCalendar";
            this.Size = new System.Drawing.Size(480, 361);
            this.Load += new System.EventHandler(this.CustomCalendar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar myMonthCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ngayKetThuc;
        private System.Windows.Forms.Label lbl_ngayBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongSoNgay;
    }
}
