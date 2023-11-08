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
    public partial class FrmQuanLySanPham : UserControl
    {
        public FrmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void sanPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHang_DataSet);

        }
    }
}
