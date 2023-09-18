using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class btnMenu : Form
    {
        frmTaiQuay frmtaiquay;
        frmTaiBan frmtaiban;
        frmBaoCao frmbaocao;
        frmVoucher frmvoucher;
        frmNhapHang frmnhaphang;
        frmThongKeTongQuan frmthongKeTongQuan;
        frmThongKeHangHoa frmthongKeHangHoa;
        frmThem frmthem;
        public btnMenu()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232,234,237);
        }
        bool menuExpand = false;


        bool sidebarExpand = true;
        private void btnMenu2_Click(object sender, EventArgs e)
        {
            change();
        }
        private void btnTaiQuay_Click(object sender, EventArgs e)
        {
           //viet lại ik lỡ xóa rồi :)
        }
        private void btnTaiBan_Click(object sender, EventArgs e)
        {
            if (frmtaiban == null)
            {
                frmtaiban = new frmTaiBan();
                frmtaiban.FormClosed += Frmtaiban_FormClosed;
                frmtaiban.MdiParent = this;
                frmtaiban.Dock = DockStyle.Fill;
                frmtaiban.Show();
            }
            else {
                frmtaiban.Activate();
            }
        }

        private void Frmtaiban_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmtaiban = null;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (frmnhaphang == null)
            {
                frmnhaphang = new frmNhapHang();
                frmnhaphang.FormClosed += Frmnhaphang_FormClosed;
                frmnhaphang.MdiParent = this;
                frmnhaphang.Dock = DockStyle.Fill;
                frmnhaphang.Show();
            }
            else
            {
                frmnhaphang.Activate();
            }
        }

        private void Frmnhaphang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmnhaphang = null;
        }
        private void btn_tongQuan_Click(object sender, EventArgs e)
        {
            if (frmthongKeTongQuan == null)
            {
                frmthongKeTongQuan = new frmThongKeTongQuan();
                frmthongKeTongQuan.MdiParent = this;
                frmthongKeTongQuan.Dock = DockStyle.Fill;
                frmthongKeTongQuan.Show();
            }
            else
            {
                frmthongKeTongQuan.Activate();
            }
        }
        private void btn_sanPhamBanChay_Click(object sender, EventArgs e)
        {
            if (frmthongKeHangHoa == null)
            {
                frmthongKeHangHoa = new frmThongKeHangHoa();
                frmthongKeHangHoa.FormClosed += frmthongKeHangHoa_FormClosed;
                frmthongKeHangHoa.MdiParent = this;
                frmthongKeHangHoa.Dock = DockStyle.Fill;
                frmthongKeHangHoa.Show();
            }
            else
            {
                frmthongKeHangHoa.Activate();
            }
        }

        void frmthongKeHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btn_doanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            if (frmvoucher == null)
            {
                frmvoucher = new frmVoucher();
                frmvoucher.FormClosed += frmvoucher_FormClosed;
                frmvoucher.MdiParent = this;
                frmvoucher.Dock = DockStyle.Fill;
                frmvoucher.Show();
            }
            else
            {
                frmvoucher.Activate();
            }
        }

        void frmvoucher_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (frmthem == null)
            {
                frmthem = new frmThem();
                frmthem.FormClosed += frmthem_FormClosed;
                frmthem.MdiParent = this;
                frmthem.Dock = DockStyle.Fill;
                frmthem.Show();
            }
            else
            {
                frmthem.Activate();
            }
        }

        void frmthem_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void change()
        {
            while (true)
            {
                if (sidebarExpand)
                {
                    sidebar.Width -= 10;
                    if (sidebar.Width <= 60)
                    {
                        sidebar.Width = 60;
                        sidebarExpand = false;

                        btnTaiBan.Width = sidebar.Width;
                        btnTaiQuay.Width = sidebar.Width;
                        btnBaoCao.Width = sidebar.Width;
                        btnKhachHang.Width = sidebar.Width;
                        btnThem.Width = sidebar.Width;
                        btnNhapHang.Width = sidebar.Width;
                        break;
                    }
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width >= 275)
                    {
                        sidebar.Width = 275;
                        sidebarExpand = true;

                        btnTaiBan.Width = sidebar.Width;
                        btnTaiQuay.Width = sidebar.Width;
                        btnBaoCao.Width = sidebar.Width;
                        btnKhachHang.Width = sidebar.Width;
                        btnThem.Width = sidebar.Width;
                        btnNhapHang.Width = sidebar.Width;
                        break;
                    }
                }
            }

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // reduce flickering when switching mdi child forms (see also WndProc)
                //cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED (which is essentially double buffered)

                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED (which is essentially double buffered)

                return cp;
            }
        }

    }
}
