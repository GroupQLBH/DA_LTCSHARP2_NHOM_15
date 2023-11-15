using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang_BLL;
namespace QuanLyBanHang
{
    public partial class FrmQuanLyKhachHang : UserControl
    {
        QuanLyKhachHangBLL QuanLyKhachHangBLL_CT = new QuanLyKhachHangBLL();
        static int fla = 1;
        static string TenNhanVienQuay;
        public FrmQuanLyKhachHang(string TenNhanVien)
        {
            TenNhanVienQuay = TenNhanVien.Trim();
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHang_DataSet);

        }

        private void FrmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Fill(this.quanLyBanHang_DataSet.KhachHang);
            if(QuanLyKhachHangBLL_CT.TimNhomNguoiDung(TenNhanVienQuay)!="NN01")
            {
                btnXoa.Visible = false;
            }
            enableControl(false);
            btnThem.Enabled = true;
            txtTimKiem.Enabled = true;
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^0\d{9,}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public bool IsValidEmail(string email)
        {
            // Pattern cho một địa chỉ email đơn giản
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Kiểm tra xem địa chỉ email phù hợp với pattern không
            Match match = Regex.Match(email, pattern);

            return match.Success;
        }
        public void enableControl(bool ena)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = ena;
            }
            khachHangDataGridView.Enabled = true;

        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                khachHangDataGridView.DataSource = null;
                khachHangDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.khachHangTableAdapter.Fill(this.quanLyBanHang_DataSet.KhachHang);

                // Gán nguồn dữ liệu mới cho DataGridView
                khachHangDataGridView.DataSource = quanLyBanHang_DataSet.KhachHang;
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
                khachHangDataGridView.DataSource = null;
                khachHangDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.khachHangTableAdapter.Fill(this.quanLyBanHang_DataSet.KhachHang);

                // Gán nguồn dữ liệu mới cho DataGridView
                khachHangDataGridView.DataSource = QuanLyKhachHangBLL_CT.TimKhachHangTheoThuocTinh(txtTimKiem.Text.Trim());
            }
            catch
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy khách hàng này", "Thông báo");
                ReloadDataGridView();
            }
        }
        private void khachHangDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maKhachHangTextBox.Text = khachHangDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenKhachHangTextBox.Text = khachHangDataGridView.CurrentRow.Cells[1].Value.ToString();
            diaChiTextBox.Text = khachHangDataGridView.CurrentRow.Cells[2].Value.ToString();
            soDienThoaiTextBox.Text = khachHangDataGridView.CurrentRow.Cells[3].Value.ToString();
            emailTextBox.Text = khachHangDataGridView.CurrentRow.Cells[4].Value.ToString();
            ngaySinhDateTimePicker.Value =Convert.ToDateTime(khachHangDataGridView.CurrentRow.Cells[5].Value);
            gioiTinhTextBox.Text = khachHangDataGridView.CurrentRow.Cells[6].Value.ToString();
            taiKhoanDataGridView.DataSource = null;
            taiKhoanDataGridView.Rows.Clear();

            // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
            this.taiKhoanTableAdapter.Fill(this.quanLyBanHang_DataSet.TaiKhoan);

            // Gán nguồn dữ liệu mới cho DataGridView
            taiKhoanDataGridView.DataSource = QuanLyKhachHangBLL_CT.TimTaiKhoan(maKhachHangTextBox.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            khachHangDataGridView.Rows[khachHangDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;
            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maKhachHangTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            khachHangDataGridView.Enabled = false;
            btnThem.Enabled = false;
            txtTimKiem.Enabled = false;
            btnLuu.Enabled = true;
            maKhachHangTextBox.Text = QuanLyKhachHangBLL_CT.MaKhachHangTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khách hàng " + maKhachHangTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLyKhachHangBLL_CT.XoaKhachHang(maKhachHangTextBox.Text);
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
            maKhachHangTextBox.Enabled = false;
            khachHangDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenKhachHangTextBox.Text.Trim() == "" ||  soDienThoaiTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin (Họ Tên hoặc Số Điện Thoại) !", "Thông báo");
                    return;
                }
                
                if (!IsValidPhoneNumber(soDienThoaiTextBox.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập một số điện thoại hợp lệ !", "Thông báo");
                    return;
                }

                if (!IsValidEmail(emailTextBox.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập một email hợp lệ !", "Thông báo");
                    return;
                }

                KhachHang KH = new KhachHang();
                KH.MaKhachHang = maKhachHangTextBox.Text.Trim();
                KH.TenKhachHang = tenKhachHangTextBox.Text.Trim();
                KH.DiaChi = diaChiTextBox.Text.Trim();
                KH.GioiTinh = gioiTinhTextBox.SelectedItem.ToString();
                KH.Email = emailTextBox.Text.Trim();
                KH.SoDienThoai = soDienThoaiTextBox.Text.Trim();
                KH.NgaySinh = ngaySinhDateTimePicker.Value;
                if (fla == 1)
                {

                    QuanLyKhachHangBLL_CT.ThemKhachHang(KH);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLyKhachHangBLL_CT.SuaKhachHang(KH);
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
