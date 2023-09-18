namespace QuanLyNhaHang
{
    partial class frmThoiGianTuyChinh
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
            this.customCalendar1 = new CustomControlThongKe.MyCustomCalendar();
            this.SuspendLayout();
            // 
            // customCalendar1
            // 
            this.customCalendar1.Location = new System.Drawing.Point(6, -1);
            this.customCalendar1.Name = "customCalendar1";
            this.customCalendar1.Size = new System.Drawing.Size(487, 366);
            this.customCalendar1.TabIndex = 0;
            // 
            // frmThoiGianTuyChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 358);
            this.Controls.Add(this.customCalendar1);
            this.Name = "frmThoiGianTuyChinh";
            this.Text = "frmThoiGianTuyChinh";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlThongKe.MyCustomCalendar customCalendar1;
    }
}