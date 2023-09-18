﻿using System;
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
    public partial class frmThongKeHangHoa : Form
    {
        public frmThongKeHangHoa()
        {
            InitializeComponent();
            this.Load += frmThongKeHangHoa_Load;
        }
     
        void frmThongKeHangHoa_Load(object sender, EventArgs e)
        {
            // Tạo một biểu đồ tròn
            Chart chart = new Chart();
            chart.Width = 400;
            chart.Height = 300;

            // Tạo một ChartArea
            ChartArea chartArea = new ChartArea("MyChartArea");
            chart.ChartAreas.Add(chartArea);
            chart.Dock = DockStyle.Fill;
            // Tạo một loạt dữ liệu
            Series series = new Series("Data");
            series.Points.AddXY("Category 1", 30);
            series.Points.AddXY("Category 2", 50);
            series.Points.AddXY("Category 3", 20);

            // Đặt loại biểu đồ là biểu đồ tròn
            series.ChartType = SeriesChartType.Pie;

            // Thêm loạt dữ liệu vào biểu đồ
            chart.Series.Add(series);

            // Đặt chú thích (legend)
            Legend legend = new Legend("MyLegend");
            chart.Legends.Add(legend);


            // Thêm biểu đồ vào form
            panel_chart.Controls.Add(chart);
        }

        private void cbo_thonngke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_thonngke.SelectedIndex == 0)
            {
                frmThoiGianTuyChinh tgtc = new frmThoiGianTuyChinh();
                 tgtc.StartPosition =FormStartPosition.CenterScreen;
                tgtc.Show();
            }
        }

     
    }
}
