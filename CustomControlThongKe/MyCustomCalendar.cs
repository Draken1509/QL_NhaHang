using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomControlThongKe
{
    public partial class MyCustomCalendar : UserControl
    {
        private DateTime startDate;
        private DateTime endDate;
        private bool selectingStartDate = true;

        public MyCustomCalendar()
        {
            InitializeComponent();
           
        }

        private void CustomCalendar_Load(object sender, EventArgs e)
        {
            // Khởi tạo màu cho khoảng thời gian
            myMonthCalendar.SelectionStart = startDate = DateTime.Today;
            myMonthCalendar.SelectionEnd = endDate = DateTime.Today;

            // Đặt sự kiện DateSelected cho MonthCalendar
            myMonthCalendar.DateSelected += Calendar_DateSelected;

            // Tô màu khoảng thời gian mặc định
            HighlightDateRange(startDate, endDate);
        }


        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (selectingStartDate)
            {
                startDate = e.Start;
                selectingStartDate = false;
            }
            else
            {
                endDate = e.Start;
                selectingStartDate = true;
            }

            // Tô màu khoảng thời gian đã chọn
            HighlightDateRange(startDate, endDate);

            // Hiển thị thông tin về khoảng thời gian đã chọn
            ShowDateRangeInfo(startDate, endDate);
        }
         private void HighlightDateRange(DateTime start, DateTime end)
        {
            myMonthCalendar.RemoveAllBoldedDates();

            // Thêm ngày bắt đầu và kết thúc vào danh sách để tô màu
            while (start <= end || start <= end)
            {
                myMonthCalendar.AddBoldedDate(start);
                start = start.AddDays(1);
            }
            myMonthCalendar.UpdateBoldedDates();
        }

        private void ShowDateRangeInfo(DateTime start, DateTime end)
        {
            string formattedDateStart = start.ToString("dd/MM/yyyy");
            string formattedDateEnd = end.ToString("dd/MM/yyyy");

            lbl_ngayBatDau.Text = formattedDateStart;
            lbl_ngayKetThuc.Text = formattedDateEnd;
            int tsn = Math.Abs((end - start).Days + 1);
            lblTongSoNgay.Text = tsn.ToString();

         /*   MessageBox.Show($"Ngày bắt đầu: {start.ToShortDateString()}\n" +
                            $"Ngày kết thúc: {end.ToShortDateString()}\n" +
                            $"Số ngày trong khoảng: {(end - start).Days + 1} ngày",
                            "Thông tin khoảng thời gian",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }
    }
}
