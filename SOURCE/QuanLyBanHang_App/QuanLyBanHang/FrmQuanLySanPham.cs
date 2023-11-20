using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang_BLL;
namespace QuanLyBanHang
{
    public partial class FrmQuanLySanPham : UserControl
    {
        int fla = 1;
        QuanLySanPhamBLL QuanLySanPhamBLL_CT = new QuanLySanPhamBLL();
        public FrmQuanLySanPham()
        {
            InitializeComponent();

        }

        public void enableControl(bool ena)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = ena;
            }
            trangThaiTextBox.Enabled = false;
            hinhAnhTextBox.Enabled = false;
            sanPhamDataGridView.Enabled = true;
        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                sanPhamDataGridView.DataSource = null;
                sanPhamDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.sanPhamTableAdapter.Fill(this.quanLyBanHang_DataSet.SanPham);

                // Gán nguồn dữ liệu mới cho DataGridView
                sanPhamDataGridView.DataSource = quanLyBanHang_DataSet.SanPham;
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
                sanPhamDataGridView.DataSource = null;
                sanPhamDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.sanPhamTableAdapter.Fill(this.quanLyBanHang_DataSet.SanPham);

                // Gán nguồn dữ liệu mới cho DataGridView
                sanPhamDataGridView.DataSource = QuanLySanPhamBLL_CT.TimSanPhamTheoThuocTinh(txtTimKiem.Text.Trim());


            }
            catch
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy sản phẩm này", "Thông báo");
                ReloadDataGridView();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            sanPhamDataGridView.Rows[sanPhamDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;
            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maSanPhamTextBox.Enabled =  false;
            txtTimKiem.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            sanPhamDataGridView.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            maSanPhamTextBox.Text = QuanLySanPhamBLL_CT.MaSanPhamTuDong();
        }

        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
            this.sanPhamTableAdapter.Fill(this.quanLyBanHang_DataSet.SanPham);
            this.loaiSanPhamTableAdapter.Fill(this.quanLyBanHang_DataSet.LoaiSanPham);
            this.thuongHieuTableAdapter.Fill(this.quanLyBanHang_DataSet.ThuongHieu);
            this.khuyenMaiTableAdapter.Fill(this.quanLyBanHang_DataSet.KhuyenMai);
            enableControl(false);
            btnThem.Enabled = true;
            txtTimKiem.Enabled = true;
        }

        private void sanPhamDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maSanPhamTextBox.Text = sanPhamDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenSanPhamTextBox.Text = sanPhamDataGridView.CurrentRow.Cells[1].Value.ToString();
            giaTextBox.Text = sanPhamDataGridView.CurrentRow.Cells[2].Value.ToString();
            soLuongTextBox.Text = sanPhamDataGridView.CurrentRow.Cells[3].Value.ToString();
            moTaSanPhamTextBox.Text = sanPhamDataGridView.CurrentRow.Cells[4].Value.ToString();
            hinhAnhTextBox.Text = sanPhamDataGridView.CurrentRow.Cells[5].Value.ToString();
            ngayCapNhatDateTimePicker.Text = sanPhamDataGridView.CurrentRow.Cells[6].Value.ToString();
            khuyenMaiComboBox.SelectedValue = sanPhamDataGridView.CurrentRow.Cells[7].Value;
            trangThaiTextBox.Text = sanPhamDataGridView.CurrentRow.Cells[8].Value.ToString();
            thuongHieuComboBox.SelectedValue = sanPhamDataGridView.CurrentRow.Cells[9].Value;
            loaiSanPhamComboBox.SelectedValue = sanPhamDataGridView.CurrentRow.Cells[10].Value;
            if (picSanPham.Image != null)
            {
                picSanPham.Image.Dispose(); 
            }
            if (picSanPham.Image != null && hinhAnhTextBox.Text == "")
            {
                picSanPham.Image.Dispose();
            }
            else
            {
                picSanPham.Image = Image.FromFile(@"..\..\Images\" + hinhAnhTextBox.Text.Trim());
            }    



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm " + maSanPhamTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLySanPhamBLL_CT.XoaSanPham(maSanPhamTextBox.Text);
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
            maSanPhamTextBox.Enabled = false;
            sanPhamDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenSanPhamTextBox.Text.Trim() == "" || soLuongTextBox.Text.Trim() == ""
                    || trangThaiTextBox.Text.Trim() == "" || giaTextBox.Text.Trim() == "" || loaiSanPhamComboBox.Text==""|| hinhAnhTextBox.Text.Trim()=="")
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }


                SanPham SP = new SanPham();
                if (Convert.ToInt32(soLuongTextBox.Text.Trim()) > 0)
                {
                    SP.TrangThai = "Còn Hàng";
                }
                else
                {
                    SP.TrangThai = "Hết Hàng";
                }
                SP.MaSanPham = maSanPhamTextBox.Text.Trim();
                SP.TenSanPham = tenSanPhamTextBox.Text.Trim();
                if(khuyenMaiComboBox.SelectedValue==null)
                {
                    SP.MaKhuyenMai = "";
                }
                else
                {
                    SP.MaKhuyenMai = khuyenMaiComboBox.SelectedValue.ToString();
                }
                SP.Gia = Convert.ToDecimal(giaTextBox.Text.Trim());
                SP.SoLuong = Convert.ToInt32(soLuongTextBox.Text.Trim());
                if (thuongHieuComboBox.SelectedValue == null)
                {
                    SP.MaThuongHieu = "";
                }
                else
                {
                    SP.MaThuongHieu = thuongHieuComboBox.SelectedValue.ToString();
                }              
                SP.MaLoai =loaiSanPhamComboBox.SelectedValue.ToString();
                SP.HinhAnh = hinhAnhTextBox.Text.Trim();
                SP.NgayCapNhat = ngayCapNhatDateTimePicker.Value;
                SP.MoTaSanPham = moTaSanPhamTextBox.Text.Trim();

                if (fla == 1)
                {

                    QuanLySanPhamBLL_CT.ThemSanPham(SP);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLySanPhamBLL_CT.SuaSanPham(SP);
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

        private void giaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số và không phải ký tự điều khiển
            }
        }

        private void soLuongTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số và không phải ký tự điều khiển
            }

        }
        private void txtTimKiem_IconRightClick_1(object sender, EventArgs e)
        {
            ReloadDataGridViewWhenSearch();       
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {


                    string projectFolder = AppDomain.CurrentDomain.BaseDirectory;

                    // Tìm thư mục gốc của dự án (có chứa thư mục "QuanLyBanHang")
                    while (!Directory.GetDirectories(projectFolder).Any(dir => Path.GetFileName(dir) == "QuanLyBanHang"))
                    {
                        projectFolder = Directory.GetParent(projectFolder).FullName;
                    }

                    hinhAnhTextBox.Text = Path.GetFileName(openFileDialog.FileName);
                    string destinationPath = projectFolder+ "\\QuanLyBanHang\\Images\\" + hinhAnhTextBox.Text;
                    
                    if (File.Exists(destinationPath))
                    {
                        hinhAnhTextBox.Text = Path.GetFileName(openFileDialog.FileName);
                    }
                    else
                    {

                        File.Copy(openFileDialog.FileName, destinationPath, true);
                    }
                }
            }
        }
    }
}
