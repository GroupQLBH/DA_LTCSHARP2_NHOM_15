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
    public partial class FrmDangNhap : Form
    {
        DangNhapBLL DangNhapBLL_CT = new DangNhapBLL();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = false;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (DangNhapBLL_CT.TimTaiKhoanMK(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim())==null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu vui lòng kiểm tra lại !","Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Tài khoản "+ txtTenDangNhap.Text.Trim() + " đăng nhập thành công !", "Thông báo");

                DardBoard dardBoard = new DardBoard(txtTenDangNhap.Text.Trim());
                dardBoard.Show();
            }

            
        }



        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập !","Thông báo");
                txtTenDangNhap.Text.Trim();
                return;
            }    
            if(DangNhapBLL_CT.TimTaiKhoan(txtTenDangNhap.Text.Trim()) == null)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại !","Thông báo");
                return;
            }
            btnDoiMatKhau.Enabled = false;
            btnXacNhan.Enabled = true;
            btnDangNhap.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.PlaceholderText = "Nhập Mật Khẩu Mới";
            txtMatKhau.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận đổi mật khẩu ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                btnDoiMatKhau.Enabled=true;
                btnXacNhan.Enabled = false;
                btnDangNhap.Enabled = true;
                txtTenDangNhap.Enabled = true;
                txtMatKhau.PlaceholderText = "Nhập Mật Khẩu";
                txtTenDangNhap.Focus();
                QL_NguoiDung QL = new QL_NguoiDung();
                QL.TenDangNhap = txtTenDangNhap.Text;
                QL.MatKhau = txtMatKhau.Text;
                QL.HoatDong = false;
                DangNhapBLL_CT.SuaTaiKhoan(QL);
                MessageBox.Show("Đã đổi mật khẩu !", "Thông báo");

            }
              
        }
    }
}
