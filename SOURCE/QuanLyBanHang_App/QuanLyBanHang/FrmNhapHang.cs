using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aspose.Words;
using QuanLyBanHang_BLL;
using QuanLyBanHang.Templates;
using Aspose.Words.Tables;

namespace QuanLyBanHang
{
    public partial class FrmNhapHang : UserControl
    {
        public string MaNhanVien;
        NhapHangBLL NhapHangBLL_CT = new NhapHangBLL();
        public FrmNhapHang(string MaNV)
        {
            MaNhanVien = MaNV;
            InitializeComponent();
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            this.sanPhamTableAdapter.Fill(quanLyBanHang_DataSet.SanPham);
            this.khoTableAdapter.Fill(quanLyBanHang_DataSet.Kho);
            this.nhaCungCapTableAdapter.Fill(quanLyBanHang_DataSet.NhaCungCap);
            enableControl(false);
            btnTaoPhieu.Enabled=true;
            cboNhaCungCap.Enabled=true;
        }
        public void enableControl(bool ena)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = ena;
            }
            txtMaPhieuNhap.Enabled = false;

        }
        private double TinhTongTien()
        {
            double tongTien = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dataGChiTietNhap.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng cuối cùng (dòng mới thêm, không chứa dữ liệu)
                if (!row.IsNewRow)
                {
                    // Lấy giá trị số lượng và đơn giá từ các cột tương ứng trong DataGridView
                    double soLuong, donGia;
                    if (double.TryParse(row.Cells[2].Value.ToString(), out soLuong) &&
                        double.TryParse(row.Cells[3].Value.ToString(), out donGia))
                    {
                        // Tính tổng tiền cho từng dòng và cộng vào tổng tiền tổng cộng
                        tongTien += soLuong * donGia;
                    }
                }
            }

            return tongTien;
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            enableControl(true);
            if (cboNhaCungCap.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin nhà cung cấp !", "Thông Báo");
                return;
            }
            btnTaoPhieu.Enabled = false;
            cboNhaCungCap.Enabled = false;
            txtMaPhieuNhap.Text = NhapHangBLL_CT.MaPhieuNhapHangTuDong();
            PhieuNhapHang PH = new PhieuNhapHang();
            PH.MaPhieuNhap = txtMaPhieuNhap.Text.Trim();
            PH.NgayNhap = DateTime.Now;
            PH.MaNhanVien = MaNhanVien;
            PH.TongTien = 0;
            PH.MaNhaCungCap = cboNhaCungCap.SelectedValue.ToString();
            NhapHangBLL_CT.ThemPhieuNhapHang(PH);
            
        }
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                dataGChiTietNhap.DataSource = null;
                dataGChiTietNhap.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.chiTietPhieuNhapTableAdapter.Fill(this.quanLyBanHang_DataSet.ChiTietPhieuNhap);

                // Gán nguồn dữ liệu mới cho DataGridView
                dataGChiTietNhap.DataSource = NhapHangBLL_CT.TimChiTietPhieuNhapDanhSach(txtMaPhieuNhap.Text.Trim());
                lblThanhTien.Text = "Thành tiền:" + TinhTongTien().ToString() + " VND";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGChiTietNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaPn = dataGChiTietNhap.CurrentRow.Cells[0].Value.ToString();
            string MaKho = dataGChiTietNhap.CurrentRow.Cells[4].Value.ToString();
            string MaSp = dataGChiTietNhap.CurrentRow.Cells[1].Value.ToString();
            int SLNhap = Convert.ToInt32(dataGChiTietNhap.CurrentRow.Cells[2].Value.ToString());
            DialogResult r = MessageBox.Show("Bạn có muốn xóa thông tin sản phẩm "+ MaSp+ " ra khỏi phiếu nhập hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                NhapHangBLL_CT.XoaChiTietPhieuNhap(MaPn, MaKho, MaSp);
                NhapHangBLL_CT.CapNhatSLSanPhamHuy(MaSp, SLNhap);
                NhapHangBLL_CT.CapNhatSLTonKhoHuy(MaKho, MaSp, SLNhap);
                lblThanhTien.Text = "Thành tiền:" + TinhTongTien().ToString() + " VND";
            }
            ReloadDataGridView();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if(dataGChiTietNhap.Rows.Count <=0)
            {
                MessageBox.Show("Lưu phiếu nhập hàng không thành công thiếu thông tin sản phẩm!", "Thông báo");
                return; 
            }    
            DialogResult r= MessageBox.Show("Bạn có muốn xuất phiếu nhập hàng không ?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if(r == DialogResult.Yes)
            {
                var homNay = DateTime.Now;
                //Bước 1: Nạp file mẫu
                Document baoCao = new Document(@"..\..\Templates\PhieuNhapHang.docx");

                //Bước 2: Điền các thông tin cố định
                baoCao.MailMerge.Execute(new[] { "Ngay" }, new[] {homNay.Day.ToString()});
                baoCao.MailMerge.Execute(new[] { "Thang" }, new[] { homNay.Month.ToString() });
                baoCao.MailMerge.Execute(new[] { "Nam" }, new[] { homNay.Year.ToString() });
                baoCao.MailMerge.Execute(new[] { "MaPhieu" }, new[] { txtMaPhieuNhap.Text.Trim() });
                baoCao.MailMerge.Execute(new[] { "TenNhaCungCap" }, new[] { NhapHangBLL_CT.TenNhaCungCap(cboNhaCungCap.SelectedValue.ToString()) });
                baoCao.MailMerge.Execute(new[] { "TongTien" }, new[] { NhapHangBLL_CT.NumberToText(TinhTongTien()) });
                //Bước 3: Điền thông tin lên bảng
                Table bangThongTinNhapHang = baoCao.GetChild(NodeType.Table, 2, true) as Table;//Lấy bảng thứ 3 trong file mẫu
                int hangHienTai = 1;
                bangThongTinNhapHang.InsertRows(hangHienTai, hangHienTai, 3);
                foreach (DataGridViewRow row in dataGChiTietNhap.Rows)
                {

                    bangThongTinNhapHang.PutValue(hangHienTai, 0, hangHienTai.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 1, row.Cells[4].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 2, NhapHangBLL_CT.TenSanPham(row.Cells[1].Value.ToString()));
                    bangThongTinNhapHang.PutValue(hangHienTai, 3, row.Cells[1].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 4, "Cái");
                    bangThongTinNhapHang.PutValue(hangHienTai, 5, row.Cells[2].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 6, row.Cells[3].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 7,(Convert.ToDecimal(row.Cells[2].Value)* Convert.ToDecimal(row.Cells[3].Value)).ToString());
                    hangHienTai++;
                }
                
                baoCao.SaveAndOpenFile("PhieuNhapHang_"+txtMaPhieuNhap.Text+".docx");
            }
            foreach (DataGridViewRow row in dataGChiTietNhap.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng cuối cùng (dòng mới thêm, không chứa dữ liệu)
                if (!row.IsNewRow)
                {
                    string MaPn = dataGChiTietNhap.CurrentRow.Cells[0].Value.ToString();
                    string MaSp = row.Cells[1].Value.ToString();
                    string MaKho = row.Cells[4].Value.ToString();
                    int SLNhap = Convert.ToInt32(row.Cells[2].Value.ToString());
                    decimal donGiaNhap = Convert.ToDecimal(row.Cells[2].Value.ToString());
                    ChiTietPhieuNhap CT = new ChiTietPhieuNhap();
                    CT.MaSanPham = MaSp;
                    CT.MaPhieuNhap = MaPn;
                    CT.DonGiaNhap = donGiaNhap;
                    CT.MaKho = MaKho;
                    CT.SoLuongNhap = SLNhap;
                    NhapHangBLL_CT.CapNhatSLSanPhamThem(MaSp, SLNhap);
                    NhapHangBLL_CT.CapNhatSLTonKhoThem(MaKho, MaSp, SLNhap);
                    NhapHangBLL_CT.SuaChiTietPhieuNhap(CT);
                }
            }
            
            NhapHangBLL_CT.CapNhatTongTienChoPhieu(txtMaPhieuNhap.Text.Trim(), TinhTongTien());
            enableControl(false);
            btnTaoPhieu.Enabled=true;
            cboNhaCungCap.Enabled = true;
            MessageBox.Show("Lưu phiếu nhập hàng thành công !", "Thông báo");

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            DialogResult r = MessageBox.Show("Bạn có muốn hủy phiếu nhập hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGChiTietNhap.Rows)
                {
                    // Kiểm tra nếu dòng không phải là dòng cuối cùng (dòng mới thêm, không chứa dữ liệu)
                    if (!row.IsNewRow)
                    {
                        string MaSp = row.Cells[1].Value.ToString();
                        string MaKho = row.Cells[4].Value.ToString();
                        int SLNhap = 1;
                        NhapHangBLL_CT.CapNhatSLSanPhamHuy(MaSp, SLNhap);
                        NhapHangBLL_CT.CapNhatSLTonKhoHuy(MaKho, MaSp, SLNhap);
                    }
                }
                NhapHangBLL_CT.XoaPhieuNhapHang(txtMaPhieuNhap.Text.Trim());
                NhapHangBLL_CT.XoaChiTietPhieuNhap_MaPn(txtMaPhieuNhap.Text.Trim());
               
                MessageBox.Show("Xóa thành công!", "Thông báo");
                enableControl(false);
                btnTaoPhieu.Enabled = true;
                cboNhaCungCap.Enabled = true;
                lblThanhTien.Text = "Thành tiền:" + TinhTongTien().ToString() + " VND";
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cboSanPham.Text.Trim()=="" || cboKho.Text.Trim()=="" || txtDonGiaNhap.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng chọn thông tin sản phẩm hoặc kho !","Thông Báo");
                return;
            }
            if(Convert.ToDecimal(txtDonGiaNhap.Text.Trim())>=100000000)
            {
                MessageBox.Show("Giá nhập không quá 100 triệu !", "Thông Báo");
                return;
            }
            ChiTietPhieuNhap CT = new ChiTietPhieuNhap();
            CT.MaPhieuNhap = txtMaPhieuNhap.Text.Trim();
            CT.MaKho = cboKho.SelectedValue.ToString();
            CT.MaSanPham = cboSanPham.SelectedValue.ToString();
            CT.DonGiaNhap = Convert.ToDecimal(txtDonGiaNhap.Text.Trim());
            CT.SoLuongNhap = 1;
            DialogResult r = MessageBox.Show("Bạn có muốn thêm thông tin sản phẩm " + CT.MaSanPham + " vào phiếu nhập hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                NhapHangBLL_CT.CapNhatSLSanPhamHuy(CT.MaSanPham, 1);
                NhapHangBLL_CT.CapNhatSLTonKhoHuy(CT.MaKho, CT.MaSanPham, 1);
                NhapHangBLL_CT.ThemChiTietPhieuNhap(CT);
                NhapHangBLL_CT.CapNhatSLSanPhamThem(CT.MaSanPham,Convert.ToInt32(CT.SoLuongNhap));
                NhapHangBLL_CT.CapNhatSLTonKhoThem(CT.MaKho,CT.MaSanPham, Convert.ToInt32(CT.SoLuongNhap));
            }
            lblThanhTien.Text = "Thành tiền:" + TinhTongTien().ToString() + " VND";
            ReloadDataGridView();
            NhapHangBLL_CT.ThemChiTietPhieuNhap(CT);
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số và không phải ký tự điều khiển
            }
        }

        private void FrmNhapHang_Leave(object sender, EventArgs e)
        {
            if(btnLuu.Enabled==true)
            {
                MessageBox.Show("Bạn chưa lưu thông tin vui lòng ấn lưu !", "Thông báo");
                return;
            }    
        }

        private void dataGChiTietNhap_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lblThanhTien.Text = "Thành tiền:" + TinhTongTien().ToString() +" VND";
        }
    }
}
