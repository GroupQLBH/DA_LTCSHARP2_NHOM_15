using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang_BLL;
namespace QuanLyBanHang
{
    public partial class FrmQuanLyLoaiSanPham : UserControl
    {
        static int fla = 1;
        LoaiSanPhamBLL LoaiSanPhamBLL_CT = new LoaiSanPhamBLL();
        public FrmQuanLyLoaiSanPham()
        {
            InitializeComponent();
        }

        private void FrmQuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            this.loaiSanPhamTableAdapter.Fill(this.quanLyBanHang_DataSet.LoaiSanPham);
            enableControl(false);
            btnThem.Enabled = true;
            txtTimKiem.Enabled = true;
        }
        public void enableControl(bool ena)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = ena;
            }
            loaiSanPhamDataGridView.Enabled = true;

        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                loaiSanPhamDataGridView.DataSource = null;
                loaiSanPhamDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.loaiSanPhamTableAdapter.Fill(this.quanLyBanHang_DataSet.LoaiSanPham);

                // Gán nguồn dữ liệu mới cho DataGridView
                loaiSanPhamDataGridView.DataSource = quanLyBanHang_DataSet.LoaiSanPham;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReloadDataGridViewWhenSearch()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                loaiSanPhamDataGridView.DataSource = null;
                loaiSanPhamDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.loaiSanPhamTableAdapter.Fill(this.quanLyBanHang_DataSet.LoaiSanPham);

                // Gán nguồn dữ liệu mới cho DataGridView
                loaiSanPhamDataGridView.DataSource = LoaiSanPhamBLL_CT.TimLoaiSanPhamTheoThuocTinh(txtTimKiem.Text.Trim());
            }
            catch
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy loại sản phẩm này", "Thông báo");
                ReloadDataGridView();
            }
        }

        private void loaiSanPhamDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maLoaiTextBox.Text = loaiSanPhamDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenLoaiTextBox.Text = loaiSanPhamDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            loaiSanPhamDataGridView.Rows[loaiSanPhamDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;
        
            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maLoaiTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            loaiSanPhamDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            txtTimKiem.Enabled = false;
            btnThem.Enabled = false;
            maLoaiTextBox.Text = LoaiSanPhamBLL_CT.MaLoaiSanPhamTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa loại sản phẩm " + maLoaiTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    LoaiSanPhamBLL_CT.XoaLoaiSanPham(maLoaiTextBox.Text.Trim());
                    ReloadDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Xóa Không thành công ! ", "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fla = 0;
            enableControl(true);
            btnThem.Enabled = btnXoa.Enabled = false;
            maLoaiTextBox.Enabled = false;
            loaiSanPhamDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenLoaiTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }

                if (LoaiSanPhamBLL_CT.TimTenLoaiSanPham(tenLoaiTextBox.Text.Trim()) != null)
                {
                    MessageBox.Show("Loại sản phẩm này đã tồn tại", "Thông báo");
                    return;

                }

                LoaiSanPham LSP = new LoaiSanPham();
                LSP.MaLoai = maLoaiTextBox.Text.Trim();
                LSP.TenLoai = tenLoaiTextBox.Text.Trim();

                if (fla == 1)
                {

                    LoaiSanPhamBLL_CT.ThemLoaiSanPham(LSP);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    LoaiSanPhamBLL_CT.SuaLoaiSanPham(LSP);
                    MessageBox.Show("Sửa thành công !", "Thông báo");
                }
                ReloadDataGridView();
                enableControl(false);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                txtTimKiem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lưu Không thành công ! ", "Lỗi");
            }
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            ReloadDataGridViewWhenSearch();
        }
    }
}
