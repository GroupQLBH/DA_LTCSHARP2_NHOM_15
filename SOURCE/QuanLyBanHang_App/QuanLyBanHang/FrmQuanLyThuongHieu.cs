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
    public partial class FrmQuanLyThuongHieu : UserControl
    {
        static int fla = 1;
        QuanLyThuongHieuBLL QuanLyThuongHieuBLL_CT = new QuanLyThuongHieuBLL();
        public FrmQuanLyThuongHieu()
        {
            InitializeComponent();
        }


        private void FrmQuanLyThuongHieu_Load(object sender, EventArgs e)
        {
            this.thuongHieuTableAdapter.Fill(this.quanLyBanHang_DataSet.ThuongHieu);
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
            thuongHieuDataGridView.Enabled = true;

        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                thuongHieuDataGridView.DataSource = null;
                thuongHieuDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.thuongHieuTableAdapter.Fill(this.quanLyBanHang_DataSet.ThuongHieu);

                // Gán nguồn dữ liệu mới cho DataGridView
                thuongHieuDataGridView.DataSource = quanLyBanHang_DataSet.ThuongHieu;
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
                thuongHieuDataGridView.DataSource = null;
                thuongHieuDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.thuongHieuTableAdapter.Fill(this.quanLyBanHang_DataSet.ThuongHieu);

                // Gán nguồn dữ liệu mới cho DataGridView
                thuongHieuDataGridView.DataSource = QuanLyThuongHieuBLL_CT.TimThuongHieuTheoThuocTinh(txtTimKiem.Text.Trim());
            }
            catch
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Không tìm thấy khách hàng này", "Thông báo");
                ReloadDataGridView();
            }
        }
        private void thuongHieuDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            maThuongHieuTextBox.Text = thuongHieuDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenThuongHieuTextBox.Text = thuongHieuDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thuongHieuDataGridView.Rows[thuongHieuDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;
            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maThuongHieuTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            thuongHieuDataGridView.Enabled = false;
            btnLuu.Enabled = true;
            maThuongHieuTextBox.Text = QuanLyThuongHieuBLL_CT.MaThuongHieuTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa thương hiệu " + maThuongHieuTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLyThuongHieuBLL_CT.XoaThuongHieu(maThuongHieuTextBox.Text);
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
            maThuongHieuTextBox.Enabled = false;
            thuongHieuDataGridView.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenThuongHieuTextBox.Text.Trim() == null)
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }

                if(QuanLyThuongHieuBLL_CT.TimTenThuongHieu(tenThuongHieuTextBox.Text.Trim())!=null)
                {
                    MessageBox.Show("Thương hiệu này đã tồn tại", "Thông báo");
                    return;
                        
                }    

                ThuongHieu TH = new ThuongHieu();
                TH.MaThuongHieu =maThuongHieuTextBox.Text.Trim();
                TH.TenThuongHieu = tenThuongHieuTextBox.Text.Trim();
               
                if (fla == 1)
                {

                    QuanLyThuongHieuBLL_CT.ThemThuongHieu(TH);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLyThuongHieuBLL_CT.SuaThuongHieu(TH);
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
