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
    public partial class FrmQuanLyKho : UserControl
    {
        static int fla = 1;
        QuanLyKhoBLL QuanLyKhoBLL_CT = new QuanLyKhoBLL();
        public FrmQuanLyKho()
        {
            InitializeComponent();
        }

        private void FrmQuanLyKho_Load(object sender, EventArgs e)
        {
            this.khoTableAdapter.Fill(this.quanLyBanHang_DataSet.Kho);
            this.nhanVienTableAdapter.Fill(this.quanLyBanHang_DataSet.NhanVien);
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
            khoDataGridView.Enabled = true;

        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                khoDataGridView.DataSource = null;
                khoDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.khoTableAdapter.Fill(this.quanLyBanHang_DataSet.Kho);

                // Gán nguồn dữ liệu mới cho DataGridView
                khoDataGridView.DataSource = quanLyBanHang_DataSet.Kho;
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
                khoDataGridView.DataSource = null;
                khoDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.khoTableAdapter.Fill(this.quanLyBanHang_DataSet.Kho);

                // Gán nguồn dữ liệu mới cho DataGridView
                khoDataGridView.DataSource = QuanLyKhoBLL_CT.TimKhoTheoThuocTinh(txtTimKiem.Text.Trim());
            }
            catch
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy kho này", "Thông báo");
                ReloadDataGridView();
            }
        }

        private void khoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maKhoTextBox.Text = khoDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenKhoTextBox.Text = khoDataGridView.CurrentRow.Cells[1].Value.ToString();
            nhanVienComboBox.SelectedValue = khoDataGridView.CurrentRow.Cells[2].Value;
            diaChiKhoTextBox.Text = khoDataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            khoDataGridView.Rows[khoDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;

            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maKhoTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            khoDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTimKiem.Enabled = false;
            maKhoTextBox.Text = QuanLyKhoBLL_CT.MaKhoTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa kho " + maKhoTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLyKhoBLL_CT.XoaKho(maKhoTextBox.Text);
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
            maKhoTextBox.Enabled = false;
            khoDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenKhoTextBox.Text.Trim() == ""|| diaChiKhoTextBox.Text.Trim() =="" || nhanVienComboBox.SelectedValue.ToString() =="")
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }



                Kho TH = new Kho();
                TH.MaKho = maKhoTextBox.Text.Trim();
                TH.TenKho = tenKhoTextBox.Text.Trim();
                TH.DiaChiKho = diaChiKhoTextBox.Text.Trim();
                TH.MaNhanVien = nhanVienComboBox.SelectedValue.ToString();

                if (fla == 1)
                {
                    if (QuanLyKhoBLL_CT.TimTenKho(tenKhoTextBox.Text.Trim()) != null)
                    {
                        MessageBox.Show("Kho này đã tồn tại", "Thông báo");
                        return;

                    }
                    QuanLyKhoBLL_CT.ThemKho(TH);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLyKhoBLL_CT.SuaKho(TH);
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
