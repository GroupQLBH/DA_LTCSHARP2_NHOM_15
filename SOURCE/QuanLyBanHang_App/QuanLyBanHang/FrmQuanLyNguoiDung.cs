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
    public partial class FrmQuanLyNguoiDung : UserControl
    {
        QuanLyNguoiDungBLL QuanLyNguoiDungBLL_CT = new QuanLyNguoiDungBLL();
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
        }
        static int fla = 1;
        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHang_DataSet);

        }

        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.quanLyBanHang_DataSet.NhanVien);
            enableControl(false);
            btnThem.Enabled = true;
            txtTimKiem.Enabled = true;
   
        }
        public void enableControl(bool ena)
        {
            foreach(Control item in this.Controls)
            {
                item.Enabled = ena;
            }    
            nhanVienDataGridView.Enabled = true;

        }

        private void nhanVienDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maNhanVienTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[0].Value.ToString();
            hoTenTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[1].Value.ToString();
            chucVuTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[2].Value.ToString();
            cCCDTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[3].Value.ToString();
            soDienThoaiTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[4].Value.ToString();
            luongTextBox.Text = nhanVienDataGridView.CurrentRow.Cells[5].Value.ToString();
            qL_NguoiDungDataGridView.DataSource = null;
            qL_NguoiDungDataGridView.Rows.Clear();

            // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
            this.qL_NguoiDungTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_NguoiDung);

            // Gán nguồn dữ liệu mới cho DataGridView
            qL_NguoiDungDataGridView.DataSource = QuanLyNguoiDungBLL_CT.TimTaiKhoan(maNhanVienTextBox.Text);

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            nhanVienDataGridView.Rows[nhanVienDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;
            enableControl(true);
            btnSua.Enabled=btnXoa.Enabled=btnTaiKhoan.Enabled=false;
            maNhanVienTextBox.Enabled = false;
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }    
            }
            nhanVienDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            maNhanVienTextBox.Text = QuanLyNguoiDungBLL_CT.MaNhanVienTuDong();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa nhân viên " + maNhanVienTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                {
                    QuanLyNguoiDungBLL_CT.XoaNhanVien(maNhanVienTextBox.Text);
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
            btnThem.Enabled = btnXoa.Enabled = btnTaiKhoan.Enabled = false;
            maNhanVienTextBox.Enabled = false;
            nhanVienDataGridView.Enabled = false;
            btnLuu.Enabled = true;
        }

       
        public bool IsValidCCCD(string cccd)
        {
            string pattern = @"^\d{12}$";
            return Regex.IsMatch(cccd, pattern);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^0\d{9,}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(hoTenTextBox.Text.Trim()==null || luongTextBox.Text.Trim() == null || cCCDTextBox.Text.Trim() == null || soDienThoaiTextBox.Text.Trim()==null || chucVuTextBox.Text.Trim()==null)
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }
                if(!IsValidCCCD(cCCDTextBox.Text.Trim()))
                {
                    MessageBox.Show("Căn cước công dân phải đủ 12 số !", "Thông báo");
                    return;
                }
                if (!IsValidPhoneNumber(soDienThoaiTextBox.Text.Trim()))
                {
                    MessageBox.Show("vui lòng nhập một số điện thoại hợp lệ !", "Thông báo");
                    return;
                }
                
                NhanVien NV = new NhanVien();
                NV.MaNhanVien = maNhanVienTextBox.Text.Trim();  
                NV.ChucVu = chucVuTextBox.Text.Trim();
                NV.Luong = Convert.ToDecimal(luongTextBox.Text.Trim());
                NV.HoTen = hoTenTextBox.Text.Trim();
                NV.CCCD = cCCDTextBox.Text.Trim();
                NV.SoDienThoai = soDienThoaiTextBox.Text.Trim();

                if(fla ==1)
                { 
                    
                    QuanLyNguoiDungBLL_CT.ThemNhanVien(NV);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLyNguoiDungBLL_CT.SuaNhanVien(NV);
                    MessageBox.Show("Sửa thành công !", "Thông báo");
                }
                ReloadDataGridView();
                enableControl(false);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                txtTimKiem.Enabled = true;
            }
            catch {
                MessageBox.Show("Lưu Không thành công ! ", "Lỗi");
            }
        }

        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                nhanVienDataGridView.DataSource = null;
                nhanVienDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.nhanVienTableAdapter.Fill(this.quanLyBanHang_DataSet.NhanVien);

                // Gán nguồn dữ liệu mới cho DataGridView
                nhanVienDataGridView.DataSource = quanLyBanHang_DataSet.NhanVien;
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
                nhanVienDataGridView.DataSource = null;
                nhanVienDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.nhanVienTableAdapter.Fill(this.quanLyBanHang_DataSet.NhanVien);

                // Gán nguồn dữ liệu mới cho DataGridView
                nhanVienDataGridView.DataSource = QuanLyNguoiDungBLL_CT.TimNhanVienTheoThuocTinh(txtTimKiem.Text.Trim());
            }
            catch 
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy nhân viên này","Thông báo");
                ReloadDataGridView();
            }
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm tài khoản với mật khẩu mặt định là 123 cho nhân viên "+ maNhanVienTextBox.Text + " không ?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {

                QL_NguoiDung TK = new QL_NguoiDung();
                TK.TenDangNhap = maNhanVienTextBox.Text;
                TK.MatKhau = "123";
                TK.HoatDong = false;
                QuanLyNguoiDungBLL_CT.ThemTaiKhoan(TK);
                MessageBox.Show("Thêm thành công !", "Thông báo");
            }
        }

        private void luongTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số và không phải ký tự điều khiển
            }
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            ReloadDataGridViewWhenSearch();
        }


    }
}
