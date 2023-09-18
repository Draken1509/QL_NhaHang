using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaHang
{
     
    public partial class frmThongKeTongQuan : Form
    {
        frmThoiGianTuyChinh frmtgtc;
        public frmThongKeTongQuan()
        {           
            InitializeComponent();

          
            this.Load += frmThongKeTongQuan_Load;
            //
           
                                    
        }
        public void frmThongKeTongQuan_Load(object sender, EventArgs e)
        {
             // Tạo một loạt dữ liệu cho biểu đồ
            Series series = new Series("Dữ liệu biểu đồ");
            series.Points.AddXY("Mục 1", 10);
            series.Points.AddXY("Mục 2", 20);
            series.Points.AddXY("Mục 3", 15);
            series.Points.AddXY("Mục 4", 30);

            // Đặt loại biểu đồ thành biểu đồ cột
            series.ChartType = SeriesChartType.Column;

            // Thêm loạt dữ liệu vào biểu đồ
            chart1.Series.Add(series);

            // Đặt tiêu đề cho biểu đồ và các trục
            chart1.Titles.Add("Biểu đồ cột đơn giản");
            chart1.ChartAreas[0].AxisX.Title = "X-Axis";
            chart1.ChartAreas[0].AxisY.Title = "Y-Axis";
        }

        private void panel_chart_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        
        }
              
      
        private void cbo_thonngke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_thonngke.SelectedIndex == 0)
            {
                frmtgtc = new frmThoiGianTuyChinh();
                frmtgtc.StartPosition = FormStartPosition.CenterScreen;
                frmtgtc.Show();
            }
        }
                                     
    }
}
