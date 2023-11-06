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
    public partial class FrmQuanLyNhomNguoiDung : UserControl
    {
        QuanLyNhomNguoiDungBLL QuanLyNhomNguoiDungBLL_CT = new QuanLyNhomNguoiDungBLL();
        int fla = 1;
        public FrmQuanLyNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHang_DataSet);

        }

        private void FrmQuanLyNhomNguoiDung_Load(object sender, EventArgs e)
        {
            this.qL_NhomNguoiDungTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_NhomNguoiDung);
            this.qL_NguoiDungTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_NguoiDung);
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_NguoiDungNhomNguoiDung);
            enableControl(false);
            btnThem.Enabled = true;
        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                qL_NhomNguoiDungDataGridView.DataSource = null;
                qL_NhomNguoiDungDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.qL_NhomNguoiDungTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_NhomNguoiDung);

                // Gán nguồn dữ liệu mới cho DataGridView
                qL_NhomNguoiDungDataGridView.DataSource = quanLyBanHang_DataSet.QL_NhomNguoiDung;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadDataGridViewQLND_NND()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                qL_NguoiDungNhomNguoiDungDataGridView.DataSource = null;
                qL_NguoiDungNhomNguoiDungDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_NguoiDungNhomNguoiDung);

                // Gán nguồn dữ liệu mới cho DataGridView
                qL_NguoiDungNhomNguoiDungDataGridView.DataSource = quanLyBanHang_DataSet.QL_NguoiDungNhomNguoiDung;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            maNhomTextBox.Text = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenNhomTextBox.Text = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[1].Value.ToString();
        }
        public void enableControl(bool ena)
        {
            foreach (Control item in pnlQuanLy.Controls)
            {
                item.Enabled = ena;
            }
            qL_NhomNguoiDungDataGridView.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qL_NhomNguoiDungDataGridView.Rows[qL_NhomNguoiDungDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;
            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled =  false;
            maNhomTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            btnLuu.Enabled = true;
            maNhomTextBox.Text = QuanLyNhomNguoiDungBLL_CT.MaQL_NhomNguoiDungTuDong();
            pnlChuyenDoi.Enabled = false;
            qL_NhomNguoiDungDataGridView.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhóm người dùng " + maNhomTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLyNhomNguoiDungBLL_CT.XoaQL_NhomNguoiDung(maNhomTextBox.Text);
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
            maNhomTextBox.Enabled = false;
            btnLuu.Enabled = true;
            qL_NhomNguoiDungDataGridView.Enabled = false;
            pnlChuyenDoi.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ghiChuTextBox.Text.Trim() == null || tenNhomTextBox.Text.Trim() == null)
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }
                

                QL_NhomNguoiDung QL = new QL_NhomNguoiDung();
                QL.MaNhom = maNhomTextBox.Text.Trim();
                QL.TenNhom = tenNhomTextBox.Text.Trim();
                QL.GhiChu = ghiChuTextBox.Text.Trim();
                if (fla == 1)
                {

                    QuanLyNhomNguoiDungBLL_CT.ThemQL_NhomNguoiDung(QL);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    QuanLyNhomNguoiDungBLL_CT.SuaQL_NhomNguoiDung(QL);
                    MessageBox.Show("Sửa thành công !", "Thông báo");
                }
                ReloadDataGridView();
                enableControl(false);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                pnlChuyenDoi.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Lưu Không thành công ! ", "Lỗi");
            }
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (MessageBox.Show("Bạn có muốn thêm người dùng " + qL_NguoiDungDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value.ToString() 
                +" vào nhóm người dùng " + maNhomTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QL_NguoiDungNhomNguoiDung QL = new QL_NguoiDungNhomNguoiDung();
                    QL.MaNhomNguoiDung = maNhomTextBox.Text;
                    QL.TenDangNhap = qL_NguoiDungDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                    QL.GhiChu = null;
                    QuanLyNhomNguoiDungBLL_CT.themNguoiDungVaoNhom(QL);
                    ReloadDataGridViewQLND_NND();
                    MessageBox.Show("Chuyển đổi thành công ! ", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Chuyển đổi Không thành công ! ", "Lỗi");
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            string ND = qL_NguoiDungNhomNguoiDungDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            string NND = qL_NguoiDungNhomNguoiDungDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa người dùng " + ND + " khỏi nhóm người dùng " +
                   NND, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    QuanLyNhomNguoiDungBLL_CT.xoaNguoiDungKhoiNhom(NND, ND);
                    ReloadDataGridViewQLND_NND();
                    MessageBox.Show("Chuyển đổi thành công ! ", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Chuyển đổi Không thành công ! ", "Lỗi");
            }
        }
    }
}
