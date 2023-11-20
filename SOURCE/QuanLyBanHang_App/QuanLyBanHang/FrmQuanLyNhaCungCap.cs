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
    public partial class FrmQuanLyNhaCungCap : UserControl
    {
        static int fla = 1;
        QuanLyNhaCungCapBLL QuanLyNhaCungCapBLL_CT = new QuanLyNhaCungCapBLL();
        public FrmQuanLyNhaCungCap()
        {
           
            InitializeComponent();
        }

        public void enableControl(bool ena)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = ena;
            }
            nhaCungCapDataGridView.Enabled = true;

        }
        
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                nhaCungCapDataGridView.DataSource = null;
                nhaCungCapDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.nhaCungCapTableAdapter.Fill(this.quanLyBanHang_DataSet.NhaCungCap);

                // Gán nguồn dữ liệu mới cho DataGridView
                nhaCungCapDataGridView.DataSource = quanLyBanHang_DataSet.NhaCungCap;
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
                nhaCungCapDataGridView.DataSource = null;
                nhaCungCapDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.nhaCungCapTableAdapter.Fill(this.quanLyBanHang_DataSet.NhaCungCap);

                // Gán nguồn dữ liệu mới cho DataGridView
                nhaCungCapDataGridView.DataSource = QuanLyNhaCungCapBLL_CT.TimNhaCungCapTheoThuocTinh(txtTimKiem.Text.Trim());
            }
            catch
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy nhà cung cấp này", "Thông báo");
                ReloadDataGridView();
            }
        }

        private void nhaCungCapDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maNhaCungCapTextBox.Text = nhaCungCapDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenNhaCungCapTextBox.Text = nhaCungCapDataGridView.CurrentRow.Cells[1].Value.ToString();
            diaChiTextBox.Text = nhaCungCapDataGridView.CurrentRow.Cells[2].Value.ToString();
            soDienThoaiTextBox.Text = nhaCungCapDataGridView.CurrentRow.Cells[3].Value.ToString();
            emailTextBox.Text = nhaCungCapDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhaCungCapDataGridView.Rows[nhaCungCapDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;

            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maNhaCungCapTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            nhaCungCapDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTimKiem.Enabled = false;
            maNhaCungCapTextBox.Text = QuanLyNhaCungCapBLL_CT.MaNhaCungCapTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + maNhaCungCapTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLyNhaCungCapBLL_CT.XoaNhaCungCap(maNhaCungCapTextBox.Text);
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
            maNhaCungCapTextBox.Enabled = false;
            nhaCungCapDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtTimKiem.Enabled = false;
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenNhaCungCapTextBox.Text.Trim() == "" || soDienThoaiTextBox.Text.Trim() == "" || emailTextBox.Text.Trim()=="" || diaChiTextBox.Text.Trim()=="")
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
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
                NhaCungCap TH = new NhaCungCap();
                TH.MaNhaCungCap = maNhaCungCapTextBox.Text.Trim();
                TH.TenNhaCungCap = tenNhaCungCapTextBox.Text.Trim();
                TH.SoDienThoai = soDienThoaiTextBox.Text.Trim();
                TH.Email = emailTextBox.Text.Trim();
                TH.DiaChi = diaChiTextBox.Text.Trim();

                if (fla == 1)
                {
                    if (QuanLyNhaCungCapBLL_CT.TimTenNhaCungCap(tenNhaCungCapTextBox.Text.Trim()) != null)
                    {
                        MessageBox.Show("Nhà cung cấp này đã tồn tại", "Thông báo");
                        return;

                    }
                    QuanLyNhaCungCapBLL_CT.ThemNhaCungCap(TH);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLyNhaCungCapBLL_CT.SuaNhaCungCap(TH);
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

        private void FrmQuanLyNhaCungCap_Load_1(object sender, EventArgs e)
        {
            this.nhaCungCapTableAdapter.Fill(this.quanLyBanHang_DataSet.NhaCungCap);
            enableControl(false);
            btnThem.Enabled = true;
            txtTimKiem.Enabled = true;
        }
    }
}
