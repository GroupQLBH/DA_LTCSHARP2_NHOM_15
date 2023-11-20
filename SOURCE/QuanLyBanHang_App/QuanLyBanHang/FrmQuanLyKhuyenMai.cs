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
    public partial class FrmQuanLyKhuyenMai : UserControl
    {
        int fla = 1;
        QuanLyKhuyenMaiBLL QuanLyKhuyenMaiBLL_CT = new QuanLyKhuyenMaiBLL();
        public FrmQuanLyKhuyenMai()
        {
            InitializeComponent();
        }
        public void enableControl(bool ena)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = ena;
            }
            khuyenMaiDataGridView.Enabled = true;

        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                khuyenMaiDataGridView.DataSource = null;
                khuyenMaiDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.khuyenMaiTableAdapter.Fill(this.quanLyBanHang_DataSet.KhuyenMai);

                // Gán nguồn dữ liệu mới cho DataGridView
                khuyenMaiDataGridView.DataSource = quanLyBanHang_DataSet.KhuyenMai;
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
            {// Xóa dữ liệu hiện tại của DataGridView
                khuyenMaiDataGridView.DataSource = null;
                khuyenMaiDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.khuyenMaiTableAdapter.Fill(this.quanLyBanHang_DataSet.KhuyenMai);

                // Gán nguồn dữ liệu mới cho DataGridView
                khuyenMaiDataGridView.DataSource = QuanLyKhuyenMaiBLL_CT.TimKhuyenMaiTheoThuocTinh(txtTimKiem.Text.Trim());
            }
            catch
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy khuyến mãi này", "Thông báo");
                ReloadDataGridView();
            }
        }
        private void FrmQuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            this.khuyenMaiTableAdapter.Fill(this.quanLyBanHang_DataSet.KhuyenMai);
            enableControl(false);
            btnThem.Enabled = true;
            txtTimKiem.Enabled = true;
        }
        public bool IsvalidSale(string input)
        {
            decimal userInput;
            bool isValid = false;

            while (!isValid)
            { 

                if (decimal.TryParse(input, out userInput))
                {
                    if (userInput >= 0 && userInput <= 1)
                    {
                        isValid = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return isValid;
        }
        private void khuyenMaiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(khuyenMaiDataGridView.CurrentRow.Cells[2].Value.ToString() =="")
                ngayBatDauDateTimePicker.Value = DateTime.Now;
            else
                ngayBatDauDateTimePicker.Value = Convert.ToDateTime(khuyenMaiDataGridView.CurrentRow.Cells[2].Value);
            if (khuyenMaiDataGridView.CurrentRow.Cells[3].Value.ToString() == "")
                ngayKetThucDateTimePicker.Value = DateTime.Now;
            else
                ngayKetThucDateTimePicker.Value = Convert.ToDateTime(khuyenMaiDataGridView.CurrentRow.Cells[3].Value);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maKhuyenMaiTextBox.Text = khuyenMaiDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenChuongTrinhTextBox.Text = khuyenMaiDataGridView.CurrentRow.Cells[1].Value.ToString();
            
           
            giamGiaTextBox.Text = khuyenMaiDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            khuyenMaiDataGridView.Rows[khuyenMaiDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;

            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maKhuyenMaiTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            khuyenMaiDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTimKiem.Enabled = false;
            maKhuyenMaiTextBox.Text = QuanLyKhuyenMaiBLL_CT.MaKhuyenMaiTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khuyến mãi " + maKhuyenMaiTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLyKhuyenMaiBLL_CT.XoaKhuyenMai(maKhuyenMaiTextBox.Text);
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
            maKhuyenMaiTextBox.Enabled = false;
            khuyenMaiDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenChuongTrinhTextBox.Text.Trim() == "" || giamGiaTextBox.Text.Trim()=="")
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }

                if(ngayBatDauDateTimePicker.Value > ngayKetThucDateTimePicker.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn bằng ngày kết thúc !", "Thông báo");
                    return;
                }    
                if(ngayBatDauDateTimePicker.Value < DateTime.Now)
                {
                    MessageBox.Show("Ngày bắt đầu phải lớn hơn bằng ngày hiện tại !", "Thông báo");
                    return;
                }    
                if(!IsvalidSale(giamGiaTextBox.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập số thực từ 0 đến 1 (ví dụ:0.1)!", "Thông báo");
                    return;
                }    
                KhuyenMai TH = new KhuyenMai();
                TH.MaKhuyenMai = maKhuyenMaiTextBox.Text.Trim();
                TH.TenChuongTrinh = tenChuongTrinhTextBox.Text.Trim();
                TH.NgayBatDau = ngayBatDauDateTimePicker.Value;
                TH.NgayKetThuc = ngayKetThucDateTimePicker.Value;
                TH.GiamGia = Convert.ToDecimal(giamGiaTextBox.Text.Trim());
                if (fla == 1)
                {
                    if (QuanLyKhuyenMaiBLL_CT.TimTenKhuyenMai(tenChuongTrinhTextBox.Text.Trim()) != null)
                    {
                        MessageBox.Show("Khuyến mãi này đã tồn tại", "Thông báo");
                        return;

                    }
                    QuanLyKhuyenMaiBLL_CT.ThemKhuyenMai(TH);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLyKhuyenMaiBLL_CT.SuaKhuyenMai(TH);
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
