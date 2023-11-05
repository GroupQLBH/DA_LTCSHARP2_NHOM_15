using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class DardBoard : Form
    {
        public DardBoard()
        {
            InitializeComponent();
        }

        private void DardBoard_Load(object sender, EventArgs e)
        {
        }

        private void MenuQLNguoiDung_Click(object sender, EventArgs e)
        {
            UserControl1 a = new UserControl1();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(a);
        }
    }
}
