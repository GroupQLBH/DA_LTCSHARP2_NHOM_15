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
            TenNhanVien = TenDangNhap;
            InitializeComponent();
        }

        private void DardBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTenNguoiDung.Text = "Người dùng :" + DardBoardBLL_CT.TenNhanVien(TenNhanVien);
            FindMenuPhanQuyen();

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
    }
}
