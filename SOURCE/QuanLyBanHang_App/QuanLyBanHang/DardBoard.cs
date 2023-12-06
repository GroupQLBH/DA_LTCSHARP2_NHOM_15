using DemoReviewApp;
using Guna.UI2.WinForms;
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
    public partial class DardBoard : Form
    {
        static string TenNhanVien;
        DardBoardBLL DardBoardBLL_CT = new DardBoardBLL();

        public DardBoard(string TenDangNhap)
        {
            QL_NguoiDung QL = new QL_NguoiDung();
            QL.TenDangNhap = TenDangNhap;
            QL.HoatDong = true;
            DardBoardBLL_CT.SuaTinhTrangHoatDong(QL);
            TenNhanVien = TenDangNhap;
            InitializeComponent();
        }

        private void DardBoard_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            lblTenNguoiDung.Text = "Người dùng :" + DardBoardBLL_CT.TenNhanVien(TenNhanVien);
            FindMenuPhanQuyen();
            LoadSanPham();
            

        }

        private void LoadSanPham()
        {
            if (PnlMain != null)
            {
                PnlMain.Controls.Clear();
                foreach (SanPham item in DardBoardBLL_CT.DsSanPham())
                {
                    CardProduct product = new CardProduct();
                    product.SetProductInfo(item.MaSanPham,item.TenSanPham, (decimal)item.Gia, 5, item.HinhAnh);
                    PnlMain.Controls.Add(product);
                }
            }

        }
        private void FindMenuPhanQuyen()
        {

            foreach (Control btn in PnlMenu.Controls)
            {
                if (btn is Guna2GradientButton)
                {
                    btn.Visible = false;
                }

            }
            foreach (QL_PhanQuyen item in DardBoardBLL_CT.TimDSManHinhDuocQuyen(TenNhanVien))
            {
                foreach(Control btn in PnlMenu.Controls)
                {
                    if(btn is Guna2GradientButton && item.CoQuyen == true && btn.Tag.Equals(item.MaManHinh))
                    {
                        btn.Visible = true;

                    }
                    
                }
            }
        }
        

        private void MenuQLNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung frmQuanLyNguoiDung = new FrmQuanLyNguoiDung();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyNguoiDung);
        }

        private void MenuQLNhomND_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhomNguoiDung frmQuanLyNhomNguoiDung = new FrmQuanLyNhomNguoiDung();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyNhomNguoiDung);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayHienTai.Text = "Ngày hiện tại :"+DateTime.Now.ToString();
        }

        private void MenuQLManHinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyManHinh frmQuanLyManHinh = new FrmQuanLyManHinh();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyManHinh);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuQLKhachHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhachHang frmQuanLyKhachHang = new FrmQuanLyKhachHang(TenNhanVien);
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyKhachHang);
        }

        private void MenuQLThuongHieu_Click(object sender, EventArgs e)
        {
            FrmQuanLyThuongHieu frmQuanLyThuongHieu = new FrmQuanLyThuongHieu();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyThuongHieu);
        }

        private void MenuQLLoaiSP_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiSanPham frmQuanLyLoaiSanPham = new FrmQuanLyLoaiSanPham();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyLoaiSanPham);
        }

        private void MenuQLSanPham_Click(object sender, EventArgs e)
        {
            FrmQuanLySanPham frmQuanLySanPham = new FrmQuanLySanPham();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLySanPham);
        }

        private void MenuQLNhaCC_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhaCungCap frmQuanLyNhaCungCap = new FrmQuanLyNhaCungCap();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyNhaCungCap);
        }

        private void MenuQLKhuyeMai_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhuyenMai frmQuanLyKhuyenMai = new FrmQuanLyKhuyenMai();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyKhuyenMai);
        }

        private void MenuQLKho_Click(object sender, EventArgs e)
        {
            FrmQuanLyKho frmQuanLyKho = new FrmQuanLyKho();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmQuanLyKho);
        }

        private void MenuQLNhapHang_Click(object sender, EventArgs e)
        {
            FrmNhapHang frmNhapHang = new FrmNhapHang(TenNhanVien);
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmNhapHang);
        }

        private void MenuQLBanHang_Click(object sender, EventArgs e)
        {
            FrmBanHang frmBanHang = new FrmBanHang(TenNhanVien);
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmBanHang);
        }

        private void MenuTKBaoCao_Click(object sender, EventArgs e)
        {
            FrmThongKe frmThongKe = new FrmThongKe();
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(frmThongKe);
        }

        private void DardBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void DardBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            QL_NguoiDung QL = new QL_NguoiDung();
            QL.TenDangNhap = TenNhanVien;
            QL.HoatDong = false;
            DardBoardBLL_CT.SuaTinhTrangHoatDong(QL);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }
    }
}
