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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
            
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ContextMenuStripChanged(object sender, EventArgs e)
        {
           
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            cbo_themnhom.DroppedDown = true;
        }

    }
}
