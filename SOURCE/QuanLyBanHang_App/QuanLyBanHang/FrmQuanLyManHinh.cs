using QuanLyBanHang_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanHang
{
    public partial class FrmQuanLyManHinh : UserControl
    {
        QuanLyPhanQuyenBLL quanLyPhanQuyenBLL_CT = new QuanLyPhanQuyenBLL();
        int fla = 1;
        public FrmQuanLyManHinh()
        {
            InitializeComponent();
        }

        private void dM_ManHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dM_ManHinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHang_DataSet);

        }

        private void FrmQuanLyManHinh_Load(object sender, EventArgs e)
        {
            this.dM_ManHinhTableAdapter.Fill(this.quanLyBanHang_DataSet.DM_ManHinh);
            this.qL_NhomNguoiDungTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_NhomNguoiDung);
            this.qL_PhanQuyenTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_PhanQuyen);
            ReloadDataGridViewPhanQuyen();
            enableControl(false);
        }
        public void enableControl(bool ena)
        {
            foreach (Control item in pnlManHinhChucNang.Controls)
            {
                item.Enabled = ena;
            }
            dM_ManHinhDataGridView.Enabled = true;

        }

        private void dM_ManHinhDataGridView_SelectionChanged(object sender, EventArgs e)
        { 
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            maManHinhTextBox.Text = dM_ManHinhDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenManHinhTextBox.Text = dM_ManHinhDataGridView.CurrentRow.Cells[1].Value.ToString();

        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                dM_ManHinhDataGridView.DataSource = null;
                dM_ManHinhDataGridView.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.dM_ManHinhTableAdapter.Fill(this.quanLyBanHang_DataSet.DM_ManHinh);

                // Gán nguồn dữ liệu mới cho DataGridView
                dM_ManHinhDataGridView.DataSource = quanLyBanHang_DataSet.DM_ManHinh;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReloadDataGridViewPhanQuyen()
        {
            try
            {
                string ma = qL_NhomNguoiDungDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                // Xóa dữ liệu hiện tại của DataGridView
                qL_PhanQuyenDataGridView.DataSource = null;
                qL_PhanQuyenDataGridView.Rows.Clear();

                this.qL_PhanQuyenTableAdapter.Fill(this.quanLyBanHang_DataSet.QL_PhanQuyen);
                // Gán nguồn dữ liệu mới cho DataGridView
                qL_PhanQuyenDataGridView.DataSource = quanLyPhanQuyenBLL_CT.TimDanhSachQuyenTheoMa(ma); 
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            dM_ManHinhDataGridView.Rows[dM_ManHinhDataGridView.Rows.Count - 1].Cells[0].Selected = true;
            fla = 1;
            
            enableControl(true);
            btnSua.Enabled = btnXoa.Enabled = false;
            maManHinhTextBox.Enabled = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            btnLuu.Enabled = true;
            dM_ManHinhDataGridView.Enabled = false;
            maManHinhTextBox.Text = quanLyPhanQuyenBLL_CT.MaDM_ManHinhTuDong();
            pnlPhanQuyen.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa màn hình " + maManHinhTextBox.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    quanLyPhanQuyenBLL_CT.XoaDM_ManHinh(maManHinhTextBox.Text);
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
            maManHinhTextBox.Enabled = false;
            btnLuu.Enabled = true;
            pnlPhanQuyen.Enabled = false;
            dM_ManHinhDataGridView.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenManHinhTextBox.Text.Trim() == null)
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo");
                    return;
                }


                DM_ManHinh QL = new DM_ManHinh();
                QL.MaManHinh = maManHinhTextBox.Text.Trim();
                QL.TenManHinh = tenManHinhTextBox.Text.Trim();
                if (fla == 1)
                {
                    if (quanLyPhanQuyenBLL_CT.TimTenManHinh(tenManHinhTextBox.Text.Trim()) != null)
                    {
                        MessageBox.Show("Màn hình này đã tồn tại", "Thông báo");
                        return;

                    }
                    quanLyPhanQuyenBLL_CT.ThemDM_ManHinh(QL);
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    quanLyPhanQuyenBLL_CT.SuaDM_ManHinh(QL);
                    MessageBox.Show("Sửa thành công !", "Thông báo");
                }
                ReloadDataGridView();
                enableControl(false);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                pnlPhanQuyen.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Lưu Không thành công ! ", "Lỗi");
            }
        }

        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ReloadDataGridViewPhanQuyen();
        }

        private void qL_PhanQuyenDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void qL_PhanQuyenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean coQuyen ;
            string MNND = qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            string MMH = qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();



            if (qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewCheckBoxColumn1"].Value.ToString() == "True")
            {
                coQuyen = false;
                qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewCheckBoxColumn1"].Value = false;
            }
            else
            {

                coQuyen = true;
                qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewCheckBoxColumn1"].Value = true;
            }
            QL_PhanQuyen QL = new QL_PhanQuyen();
            QL.MaManHinh = MMH;
            QL.CoQuyen = coQuyen;
            QL.MaNhomNguoiDung = MNND;
            quanLyPhanQuyenBLL_CT.SuaQuyen(QL);
            ReloadDataGridViewPhanQuyen();


        }

        private void btnThemPhanQuyen_Click(object sender, EventArgs e)
        {
            if (dM_ManHinhDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value != null && qL_NhomNguoiDungDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value!=null)
            {
                
                string MMH = dM_ManHinhDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string MNND = qL_NhomNguoiDungDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                bool coQuyen = false;
                if (quanLyPhanQuyenBLL_CT.TimQuyenTrongNhom(MNND, MMH) == null)
                {
                    QL_PhanQuyen QL = new QL_PhanQuyen();
                    QL.MaManHinh = MMH;
                    QL.MaNhomNguoiDung = MNND;
                    QL.CoQuyen = coQuyen;
                    quanLyPhanQuyenBLL_CT.themNhomNDVaoQuyen(QL);
                    ReloadDataGridViewPhanQuyen();
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Trùng thông tin phân quyền !", "Thông báo");
                }    

            }    
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin thông tin mã nhóm người dùng và mã màn hình !", "Thông báo");
            }    
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value != null && qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value != null)
            {
                string MNND = qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                string MMH = qL_PhanQuyenDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                quanLyPhanQuyenBLL_CT.xoaNhomNDKhoiQuyen(MNND, MMH);
                ReloadDataGridViewPhanQuyen();
                MessageBox.Show("Xóa thành công !", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin thông tin mã nhóm người dùng và mã màn hình !", "Thông báo");
            }

        }




    }
}
