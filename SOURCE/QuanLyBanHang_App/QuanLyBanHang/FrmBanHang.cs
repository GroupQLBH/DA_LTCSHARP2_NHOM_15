﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words.Tables;
using Aspose.Words;
using QuanLyBanHang_BLL;
using QuanLyBanHang.Templates;
using System.Runtime.InteropServices;
using DemoReviewApp;

namespace QuanLyBanHang
{
    public partial class FrmBanHang : UserControl
    {
        BanHangBLL banHangBLL_CT = new BanHangBLL();
        public string MaNhanVien,MaDonHang;
        public FrmBanHang(string MaNV)
        {
            MaNhanVien = MaNV;
            InitializeComponent();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            this.donHangTableAdapter.Fill(quanLyBanHang_DataSet.DonHang);
            this.khachHangTableAdapter.Fill(quanLyBanHang_DataSet.KhachHang);
            this.sanPhamTableAdapter.Fill(quanLyBanHang_DataSet.SanPham);
            this.khoTableAdapter.Fill(quanLyBanHang_DataSet.Kho);
            enableControl(false);
            btnTaoHoaDon.Enabled = true;
            btnSua.Enabled = true;
            cboKhachHang.Enabled = cboTrangThai.Enabled = dTNgayDat.Enabled = dTNgayGiao.Enabled = true;
            string maKho = cboKho.SelectedValue.ToString();
            string maSp = cboSanPham.SelectedValue.ToString();
            int? sl = banHangBLL_CT.TimTonKho(maKho, maSp).SoLuongTon;
            txtTonKho.Text = sl.ToString();
        }

        public void enableControl(bool ena)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = ena;
            }
            txtTonKho.Enabled = false;
            txtMaDon.Enabled = false;
            dataGDonHang.Enabled = true;
            

        }
        private double TinhTongTien()
        {
            double tongTien = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dataGChiTietDon.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng cuối cùng (dòng mới thêm, không chứa dữ liệu)
                if (!row.IsNewRow)
                {// Lấy giá trị số lượng và đơn giá từ các cột tương ứng trong DataGridView
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
        private void ReloadDataGridView()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                dataGDonHang.DataSource = null;
                dataGDonHang.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.donHangTableAdapter.Fill(this.quanLyBanHang_DataSet.DonHang);

                
                // Gán nguồn dữ liệu mới cho DataGridView
                dataGDonHang.DataSource = quanLyBanHang_DataSet.DonHang;
                int lastRow = dataGDonHang.Rows.Count - 1;
                dataGDonHang.Rows[lastRow].Selected = true;
                ReloadDataGridViewChiTietDon();

                lblTongTien.Text = "Thành tiền:" + TinhTongTien().ToString();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReloadDataGridViewChiTietDon()
        {
            try
            {
                // Xóa dữ liệu hiện tại của DataGridView
                dataGChiTietDon.DataSource = null;
                dataGChiTietDon.Rows.Clear();

                // Cập nhật dữ liệu từ cơ sở dữ liệu bằng TableAdapter
                this.chiTietDonHangTableAdapter.Fill(this.quanLyBanHang_DataSet.ChiTietDonHang);

                // Gán nguồn dữ liệu mới cho DataGridView
                dataGChiTietDon.DataSource = banHangBLL_CT.TimChiTietDonHangDanhSach(txtMaDon.Text.Trim());
                lblTongTien.Text = "Thành tiền:" + TinhTongTien().ToString();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            
            if (cboKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin khách hàng !", "Thông Báo");
                return;
            }
            else
            if(dTNgayDat.Value.ToString() == "" || dTNgayGiao.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin ngày đặt hàng hoặc ngày giao hàng !", "Thông Báo");
                return;
            }
            else
            if (DateTime.Compare(dTNgayGiao.Value.Date.Date, dTNgayDat.Value.Date.Date) < 0)
            {
                MessageBox.Show("Ngày giao hàng lớn hơn ngày đặt hàng !", "Thông Báo");
                return;
            }else
            if (DateTime.Compare(DateTime.Now.Date.Date, dTNgayDat.Value.Date.Date) > 0)
            {
                MessageBox.Show("Ngày đặt hàng phải là ngày hôm nay hoặc lớn hơn !", "Thông Báo");
                return;
            }else
            if (cboTrangThai.Text=="")
            {
                MessageBox.Show("Vui lòng chọn trạng thái đơn hàng !", "Thông Báo");
                return;
            }    
            else
            {
                enableControl(true);
            }
            PnlSanPham.Enabled = true;
            //dataGDonHang.Enabled = false;
            btnTaoHoaDon.Enabled = false;
            btnSua.Enabled = false;
            cboKhachHang.Enabled = cboTrangThai.Enabled = dTNgayDat.Enabled = dTNgayGiao.Enabled = false;
            MaDonHang = banHangBLL_CT.MaDonHangTuDong();
            DonHang DH = new DonHang();
            DH.MaDonHang = MaDonHang;
            DH.TongGia = 0;
            DH.NgayDat = dTNgayDat.Value;
            DH.NgayShipHang = dTNgayGiao.Value;
            DH.MaKhachHang = cboKhachHang.SelectedValue.ToString();
            DH.MaNhanVien = MaNhanVien;
            DH.TrangThaiDonHang = cboTrangThai.SelectedItem.ToString();
            banHangBLL_CT.ThemDonHang(DH);
            ReloadDataGridView();
            ReloadDataGridViewChiTietDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (dataGDonHang.CurrentRow.Cells[3].Value.ToString().Contains("Đã giao"))
            {
                MessageBox.Show("Đơn hàng này đã được giao không thể chỉnh sửa", "Thông báo");
                return;
            }
            else
            {
                enableControl(false);
                btnLuu.Enabled = true;
                dTNgayGiao.Enabled = true;
                cboTrangThai.Enabled = true;
            }    


        }

        private void dataGDonHang_SelectionChanged(object sender, EventArgs e)
        {
            txtMaDon.Text = dataGDonHang.CurrentRow.Cells[0].Value.ToString();
            dTNgayDat.Value = Convert.ToDateTime(dataGDonHang.CurrentRow.Cells[1].Value);
            dTNgayGiao.Value = Convert.ToDateTime(dataGDonHang.CurrentRow.Cells[5].Value);
            cboKhachHang.SelectedValue = dataGDonHang.CurrentRow.Cells[4].Value;
            cboTrangThai.SelectedValue = dataGDonHang.CurrentRow.Cells[3].Value;
            ReloadDataGridViewChiTietDon();
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dataGChiTietDon.Rows.Count <= 0)
            {
                MessageBox.Show("Lưu đơn hàng không thành công thiếu thông tin sản phẩm!", "Thông báo");
                return;
            }
            foreach (DataGridViewRow row in dataGChiTietDon.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng cuối cùng (dòng mới thêm, không chứa dữ liệu)
                if (!row.IsNewRow)
                {
                    string MaHD = dataGChiTietDon.CurrentRow.Cells[0].Value.ToString();
                    string MaSp = row.Cells[1].Value.ToString();
                    string MaKho = row.Cells[5].Value.ToString();
                    decimal DonGia = Convert.ToDecimal(row.Cells[3].Value.ToString());

                    int SLBan = Convert.ToInt32(row.Cells[2].Value.ToString());
                    double ThanhTien = (double)(DonGia * SLBan);
                    if (SLBan <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng cho sản phẩm có mã " + MaSp, "Thông báo");
                        return;
                    }

                    decimal donGiaNhap = Convert.ToDecimal(row.Cells[2].Value.ToString());
                    ChiTietDonHang CT = new ChiTietDonHang();
                    CT.MaSanPham = MaSp;
                    CT.MaKho = MaKho;
                    CT.SoLuong = SLBan;
                    CT.MaDonHang = MaHD;
                    CT.ThanhTien = ThanhTien;
                    banHangBLL_CT.CapNhatSLSanPhamThem(MaSp, 0);
                    banHangBLL_CT.CapNhatSLTonKhoThem(MaKho, MaSp, 0);
                    banHangBLL_CT.CapNhatSLSanPhamHuy(MaSp, SLBan);
                    banHangBLL_CT.CapNhatSLTonKhoHuy(MaKho, MaSp, SLBan);
                    banHangBLL_CT.SuaChiTietDonHang(CT);
                }
            }

            banHangBLL_CT.CapNhatTongTienChoDon(MaDonHang, TinhTongTien());
            banHangBLL_CT.SuaDonHang(txtMaDon.Text.Trim(), dTNgayGiao.Value, cboTrangThai.SelectedItem.ToString());
            enableControl(false);
            btnTaoHoaDon.Enabled = true;
            btnSua.Enabled = true;
            ReloadDataGridView();
            cboKhachHang.Enabled = cboTrangThai.Enabled = dTNgayDat.Enabled = dTNgayGiao.Enabled = true;
            MessageBox.Show("Lưu đơn hàng thành công !", "Thông báo");
            DialogResult r = MessageBox.Show("Bạn có muốn xuất hóa đơn bán hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                var homNay = DateTime.Now;
                //Bước 1: Nạp file mẫu
                Document baoCao = new Document(@"..\..\Templates\HoaDonBanHang.docx");

                //Bước 2: Điền các thông tin cố định
                baoCao.MailMerge.Execute(new[] { "Ngay" }, new[] { homNay.Day.ToString() });
                baoCao.MailMerge.Execute(new[] { "Thang" }, new[] { homNay.Month.ToString() });
                baoCao.MailMerge.Execute(new[] { "Nam" }, new[] { homNay.Year.ToString() });
                baoCao.MailMerge.Execute(new[] { "MaHD" }, new[] { MaDonHang });
                baoCao.MailMerge.Execute(new[] { "TenNhanVien" }, new[] { banHangBLL_CT.TenNhanVien(MaNhanVien) });
                baoCao.MailMerge.Execute(new[] { "TenKhachHang" }, new[] { banHangBLL_CT.TenKhachHang(cboKhachHang.SelectedValue.ToString()) });
                baoCao.MailMerge.Execute(new[] { "TongTien" }, new[] { banHangBLL_CT.NumberToText(TinhTongTien()) });
                //Bước 3: Điền thông tin lên bảng
                Table bangThongTinNhapHang = baoCao.GetChild(NodeType.Table, 2, true) as Table;//Lấy bảng thứ 3 trong file mẫu
                int hangHienTai = 1;
                bangThongTinNhapHang.InsertRows(hangHienTai, hangHienTai, dataGChiTietDon.Rows.Count);
                foreach (DataGridViewRow row in dataGChiTietDon.Rows)
                {
                    string MaSp = row.Cells[1].Value.ToString();
                    int SLBan = Convert.ToInt32(row.Cells[2].Value.ToString());
                    if (SLBan <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng cho sản phẩm có mã " + MaSp, "Thông báo");
                        return;
                    }
                    bangThongTinNhapHang.PutValue(hangHienTai, 0, hangHienTai.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 1, row.Cells[5].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 2, banHangBLL_CT.TenSanPham(row.Cells[1].Value.ToString()));
                    bangThongTinNhapHang.PutValue(hangHienTai, 3, row.Cells[1].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 4, "Cái");
                    bangThongTinNhapHang.PutValue(hangHienTai, 5, row.Cells[2].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 6, row.Cells[3].Value.ToString());
                    bangThongTinNhapHang.PutValue(hangHienTai, 7, row.Cells[4].Value.ToString());
                    hangHienTai++;
                }

                baoCao.SaveAndOpenFile("HoaDon_" + MaDonHang + ".docx");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn hủy phiếu nhập hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGChiTietDon.Rows)
                {
                    // Kiểm tra nếu dòng không phải là dòng cuối cùng (dòng mới thêm, không chứa dữ liệu)
                    if (!row.IsNewRow)
                    {
                        string MaSp = row.Cells[1].Value.ToString();
                        string MaKho = row.Cells[5].Value.ToString();
                        int SLBan = 0;
                        banHangBLL_CT.CapNhatSLSanPhamThem(MaSp, SLBan);
                        banHangBLL_CT.CapNhatSLTonKhoThem(MaKho, MaSp, SLBan);
                    }
                }
                banHangBLL_CT.XoaChiTietDonHang_MaPn(MaDonHang);
                banHangBLL_CT.XoaDonHang(MaDonHang);

                MessageBox.Show("Xóa thành công!", "Thông báo");
                enableControl(false);
                btnTaoHoaDon.Enabled = true;
                btnSua.Enabled = true;
                cboKhachHang.Enabled = cboTrangThai.Enabled = dTNgayDat.Enabled = dTNgayGiao.Enabled = true;
            }
            ReloadDataGridView();
            ReloadDataGridViewChiTietDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSanPham.Text.Trim() == "" || cboKho.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin sản phẩm hoặc kho !", "Thông Báo");
                return;
            }

            if (txtTonKho.Text.Trim() == "0" )
            {
                MessageBox.Show("Hết sản phẩm vui lòng chọn kho khác !", "Thông Báo");
                return;
            }

            ChiTietDonHang CT = new ChiTietDonHang();
            CT.MaSanPham = cboSanPham.SelectedValue.ToString();
            CT.MaKho = cboKho.SelectedValue.ToString();
            CT.SoLuong = 0;
            CT.DonGia = banHangBLL_CT.TimSanPham(CT.MaSanPham).Gia;
            CT.ThanhTien = (double?)(CT.SoLuong * CT.DonGia);
            CT.MaDonHang = MaDonHang;
            DialogResult r = MessageBox.Show("Bạn có muốn thêm thông tin sản phẩm " + CT.MaSanPham + " vào hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {

                banHangBLL_CT.ThemChiTietDonHang(CT);
                banHangBLL_CT.CapNhatSLSanPhamHuy(CT.MaSanPham, Convert.ToInt32(CT.SoLuong));
                banHangBLL_CT.CapNhatSLTonKhoHuy(CT.MaKho, CT.MaSanPham, Convert.ToInt32(CT.SoLuong));
                ReloadDataGridViewChiTietDon();
            }
            dataGChiTietDon.Enabled = true;
            ReloadDataGridViewChiTietDon();
        }

        private void FrmBanHang_Leave(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                MessageBox.Show("Bạn chưa lưu thông tin vui lòng ấn lưu !", "Thông báo");
                return;
            }
        }


        private void cboKho_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maKho = cboKho.SelectedValue.ToString();
            string maSp = cboSanPham.SelectedValue.ToString();
            if(banHangBLL_CT.TimTonKho(maKho, maSp) !=null)
            { 
                int? sl = banHangBLL_CT.TimTonKho(maKho, maSp).SoLuongTon;
                txtTonKho.Text = sl.ToString();
            }    
            else
            { txtTonKho.Text = "0"; }    
            
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadDeXuatSanPham();
            string maKho = cboKho.SelectedValue.ToString();
            string maSp = cboSanPham.SelectedValue.ToString();
            if (banHangBLL_CT.TimTonKho(maKho, maSp) != null)
            {
                int? sl = banHangBLL_CT.TimTonKho(maKho, maSp).SoLuongTon;
                txtTonKho.Text = sl.ToString();
            }
            else
            { txtTonKho.Text = "0"; }
        }

        private void dataGChiTietDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaDon = dataGChiTietDon.CurrentRow.Cells[0].Value.ToString();
            string MaKho = dataGChiTietDon.CurrentRow.Cells[5].Value.ToString();
            string MaSp = dataGChiTietDon.CurrentRow.Cells[1].Value.ToString();
            DialogResult r = MessageBox.Show("Bạn có muốn xóa thông tin sản phẩm " + MaSp + " ra khỏi đơn hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                banHangBLL_CT.XoaChiTietDonHang(MaDon, MaKho, MaSp);
                banHangBLL_CT.CapNhatSLSanPhamHuy(MaSp, 0);
                banHangBLL_CT.CapNhatSLTonKhoHuy(MaKho, MaSp, 0);
                lblTongTien.Text = "Thành tiền:" + TinhTongTien().ToString();
            }
            ReloadDataGridViewChiTietDon();
        }

        private void dataGChiTietDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string maKho = dataGChiTietDon.CurrentRow.Cells[5].Value.ToString();
            string maSp = dataGChiTietDon.CurrentRow.Cells[1].Value.ToString();
            int sl = Convert.ToInt16(txtTonKho.Text);
            if (Convert.ToDecimal(dataGChiTietDon.CurrentRow.Cells[2].Value) > sl)
            {

                MessageBox.Show("Kho " + maKho + " chỉ còn " + sl.ToString() + " sản phẩm " + banHangBLL_CT.TenSanPham(maSp) + " vui lòng chọn kho khác hoặc nhập số lượng ít hơn !", "Thông báo");
                dataGChiTietDon.CurrentRow.Cells[2].Value = 0;
                return;
            }
            double giamgia= (double)(Convert.ToDecimal(dataGChiTietDon.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dataGChiTietDon.CurrentRow.Cells[3].Value) * banHangBLL_CT.GiaKhuyenMai(maSp));
            dataGChiTietDon.CurrentRow.Cells[4].Value = (double)(Convert.ToDecimal(dataGChiTietDon.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dataGChiTietDon.CurrentRow.Cells[3].Value)) - giamgia;
            lblTongTien.Text = "Thành tiền:" + TinhTongTien().ToString();
        }
        // Phương thức để đề xuất sản phẩm mua kèm
        private void LoadSanPham()
        {
            if (PnlSanPham != null)
            {
                PnlSanPham.Controls.Clear();
                foreach (SanPham item in banHangBLL_CT.DsSanPham())
                {
                    CardProduct product = new CardProduct();
                    product.SetProductInfo(item.MaSanPham, item.TenSanPham, (decimal)item.Gia, 5, item.HinhAnh);
                    product.UserControlClicked += (sender, e) =>
                    {
                        if (sender is CardProduct clickedControl)
                        {
                            // Lấy tên của User Control và load ra Label
                            cboSanPham.SelectedValue = clickedControl.MaSanPham.ToString();
                            LoadDeXuatSanPham();
                            string maKho = cboKho.SelectedValue.ToString();
                            string maSp = cboSanPham.SelectedValue.ToString();
                            int? sl = banHangBLL_CT.TimTonKho(maKho, maSp).SoLuongTon;
                            txtTonKho.Text = sl.ToString();
                            LoadDeXuatSanPham();
                        }
                    };
                    PnlSanPham.Controls.Add(product);
                }
            }

        }

        private void PnlSanPham_Click(object sender, EventArgs e)
        {
            if (sender is CardProduct clickedControl)
            {
                // Lấy tên của User Control và load ra Label
                cboSanPham.SelectedValue = clickedControl.MaSanPham;
            }
        }

        public bool TonTaiDeXuat(string MaSp)
        {
            return dataGChiTietDon.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[1].Value.ToString() == MaSp);
        }
        private void LoadDeXuatSanPham()
        {
            if (PnlDeXuat != null)
            {
                PnlDeXuat.Controls.Clear();
                foreach (SanPham item in banHangBLL_CT.DsSanPham())
                {
                    if (banHangBLL_CT.DsMuaKem(cboSanPham.SelectedValue.ToString()) != null)
                    {
      
                        foreach (string SanPhamDeXuat in banHangBLL_CT.DsMuaKem(cboSanPham.SelectedValue.ToString()))
                        {
                            
                            if (item.MaSanPham == SanPhamDeXuat && TonTaiDeXuat(item.MaSanPham)==false)
                            {
                                CardProduct product = new CardProduct();
                                product.SetProductInfo(item.MaSanPham, item.TenSanPham, (decimal)item.Gia, 5, item.HinhAnh);
                                product.UserControlClicked += (sender, e) =>
                                {
                                    if (sender is CardProduct clickedControl)
                                    {
                                        // Lấy tên của User Control và load ra Label
                                        cboSanPham.SelectedValue = clickedControl.MaSanPham.ToString();
                                        string maKho = cboKho.SelectedValue.ToString();
                                        string maSp = cboSanPham.SelectedValue.ToString();
                                        int? sl = banHangBLL_CT.TimTonKho(maKho, maSp).SoLuongTon;
                                        txtTonKho.Text = sl.ToString();
                                    }
                                };
                                PnlDeXuat.Controls.Add(product);
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

    }
}
