using PagedList;
using QuanLyBanHang_Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang_Web.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        BanHangModelDataContext _banHangModelDataContext = new BanHangModelDataContext("Data Source=LAPTOP-V9K1ICKI;Initial Catalog = QuanLyBanHang; User ID = sa; Password=123");
        private const int PageSize = 10;
        public ActionResult Index(int? page)
        {

            List<SanPham> danhSachSanPham = _banHangModelDataContext.SanPhams.ToList();
            int pageNumber = (page ?? 1);

            IPagedList<SanPham> pagedSanPhams = danhSachSanPham.ToPagedList(pageNumber, PageSize);

            return View(pagedSanPhams);
        }
        public Kho KhoConSp(string Ma)
        {
            List<TonKho>Ton= _banHangModelDataContext.TonKhos.Where(k=>k.MaSanPham ==Ma).ToList();
            foreach(TonKho i  in Ton)
            {
                if (i.SoLuongTon > 0)
                {
                    return _banHangModelDataContext.Khos.Where(k => k.MaKho == i.MaKho).FirstOrDefault();
                }
                else
                    return null;
            }    
            return null;
        }

        public QL_NguoiDung NhanVienDangHoatDong()
        {
            return _banHangModelDataContext.QL_NguoiDungs.Where(nv => nv.HoatDong == true).FirstOrDefault();
        }

        public QL_NguoiDungNhomNguoiDung QuyenBanHang(QL_NguoiDung Nhanvien)
        {
            return _banHangModelDataContext.QL_NguoiDungNhomNguoiDungs.Where(nh => nh.TenDangNhap == Nhanvien.TenDangNhap).FirstOrDefault();
        }
        public ChiTietDonHang TimChiTietDon(string Ma)
        {
            return _banHangModelDataContext.ChiTietDonHangs.Where(ct =>ct.MaDonHang ==Ma).FirstOrDefault();
        }
        static string MaHD;
        GioHang gioHang = new GioHang();
        public void ThemVaoGioHang(string Ma,int sl)
        {
            MaHD= MaDonHangTuDong();
            if(NhanVienDangHoatDong()!=null && QuyenBanHang(NhanVienDangHoatDong()).MaNhomNguoiDung =="NN02" && TimChiTietDon(MaHD)==null)
            {
                gioHang.donHang.MaDonHang = MaHD;
            } 
            if (KhoConSp(Ma) != null)
            {
                ChiTietDonHang DH = new ChiTietDonHang();
                DH.MaDonHang = gioHang.donHang.MaDonHang;
                DH.MaKho = KhoConSp(Ma).MaKho;
                DH.MaSanPham = Ma;
                DH.SoLuong = sl;
                DH.DonGia = DonGiaSanPham(Ma) - (DonGiaSanPham(Ma) * GiaKhuyenMai(Ma));
                DH.ThanhTien = DH.SoLuong * (double)DH.DonGia;
                ThemChiTietDonHang(DH);
            }
            else
            {
                ViewBag.HetHang = "Sản phẩm đã hết vui lòng chọn mua sản phẩm khác !";
            }
        }
        public string HinhAnhSanPham(string Ma)
        {
            return _banHangModelDataContext.SanPhams.Where(sp =>sp.MaSanPham == Ma).FirstOrDefault().HinhAnh;
        }
        public string MaKhuyenMai(string Ma)
        {
            return _banHangModelDataContext.SanPhams.Where(sp => sp.MaSanPham == Ma).FirstOrDefault().MaKhuyenMai;
        }
        public decimal DonGiaSanPham(string Ma)
        {
            return _banHangModelDataContext.SanPhams.Where(sp =>sp.MaSanPham == Ma).FirstOrDefault().Gia.Value;
        }
        public decimal GiaKhuyenMai(string Ma)
        {
            if (MaKhuyenMai(Ma) != null && (MaKhuyenMai(Ma) != ""))
                return _banHangModelDataContext.KhuyenMais.Where(km => km.MaKhuyenMai == MaKhuyenMai(Ma)).FirstOrDefault().GiamGia.Value;
            else
                return 0;

        }
        public void ThemChiTietDonHang(ChiTietDonHang NV)
        {
            if (TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham) == null)
            {
                _banHangModelDataContext.ChiTietDonHangs.InsertOnSubmit(NV);
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public ChiTietDonHang TimChiTietDonHang(string MaPn, string MaKho, string MaSp)
        {
            return _banHangModelDataContext.ChiTietDonHangs.Where(nv => nv.MaDonHang == MaPn && nv.MaKho == MaKho && nv.MaSanPham == MaSp).FirstOrDefault();
        }

        public ChiTietDonHang TimSLChiTietDonHang(int soLuong)
        {
            return _banHangModelDataContext.ChiTietDonHangs.Where(nv => nv.SoLuong >= soLuong).FirstOrDefault();
        }
        public void SuaChiTietDonHang(ChiTietDonHang NV)
        {
            if (TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham) != null)
            {
                TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham).SoLuong = NV.SoLuong;
                TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham).ThanhTien = NV.ThanhTien;
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public void XoaChiTietDonHang(string MaPn, string MaKho, string MaSp)
        {
            if (TimChiTietDonHang(MaPn, MaKho, MaSp) != null)
            {
                _banHangModelDataContext.ChiTietDonHangs.DeleteOnSubmit(TimChiTietDonHang(MaPn, MaKho, MaSp));
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public ChiTietDonHang TimChiTietDonHang_MaPn(string MaPn)
        {
            return _banHangModelDataContext.ChiTietDonHangs.Where(nv => nv.MaDonHang == MaPn).FirstOrDefault();
        }

        public List<ChiTietDonHang> TimChiTietDonHangDanhSach(string MaPn)
        {
            return _banHangModelDataContext.ChiTietDonHangs.Where(nv => nv.MaDonHang == MaPn).ToList();
        }
        public void XoaChiTietDonHang_MaPn(string MaPn)
        {
            if (TimChiTietDonHang_MaPn(MaPn) != null)
            {
                _banHangModelDataContext.ChiTietDonHangs.DeleteOnSubmit(TimChiTietDonHang_MaPn(MaPn));
                _banHangModelDataContext.SubmitChanges();
            }
        }

        public void ThemDonHang(DonHang NV)
        {
            if (TimDonHang(NV.MaDonHang) == null)
            {
                _banHangModelDataContext.DonHangs.InsertOnSubmit(NV);
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public DonHang TimDonHang(string Ma)
        {
            return _banHangModelDataContext.DonHangs.Where(nv => nv.MaDonHang == Ma).FirstOrDefault();
        }
        public void CapNhatTongTienChoDon(string Ma, double TongTien)
        {
            if (TimDonHang(Ma) != null)
            {
                TimDonHang(Ma).TongGia = TongTien;
                _banHangModelDataContext.SubmitChanges();
            }
        }

        public void SuaDonHang(string maDon, DateTime ngayGiao, string trangThai)
        {
            if (TimDonHang(maDon) != null)
            {
                TimDonHang(maDon).NgayShipHang = ngayGiao;
                TimDonHang(maDon).TrangThaiDonHang = trangThai;
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public void XoaDonHang(string Ma)
        {
            if (TimDonHang(Ma) != null)
            {
                _banHangModelDataContext.DonHangs.DeleteOnSubmit(TimDonHang(Ma));
                XoaChiTietDonHang_MaPn(Ma);
                _banHangModelDataContext.SubmitChanges();
            }
        }

        public string MaDonHangTuDong()
        {
            var lastDonHang = _banHangModelDataContext.DonHangs.OrderByDescending(nv => nv.MaDonHang).FirstOrDefault();
            if (lastDonHang != null)
            {
                string Ma = lastDonHang.MaDonHang.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "DH" + numberPart.ToString("D2");
            }
            return null;
        }
        public TonKho TimTonKho(string MaKho, string MaSp)
        {
            return _banHangModelDataContext.TonKhos.Where(nv => nv.MaKho == MaKho && nv.MaSanPham == MaSp).FirstOrDefault();
        }
        public void XoaTonKho(string MaKho, string MaSp)
        {
            if (TimTonKho(MaKho, MaSp) != null)
            {
                _banHangModelDataContext.TonKhos.DeleteOnSubmit(TimTonKho(MaKho, MaSp));
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public SanPham TimSanPham(string MaSp)
        {
            return _banHangModelDataContext.SanPhams.Where(nv => nv.MaSanPham == MaSp).FirstOrDefault();
        }


        public void CapNhatSLSanPhamThem(string MaSp, int SL)
        {
            if (TimSanPham(MaSp) != null)
            {
                TimSanPham(MaSp).SoLuong += SL;
                _banHangModelDataContext.SubmitChanges();
            }
        }

        public void CapNhatSLSanPhamHuy(string MaSp, int SL)
        {
            if (TimSanPham(MaSp) != null)
            {
                TimSanPham(MaSp).SoLuong -= SL;
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public void CapNhatSLTonKhoThem(string MaKho, string MaSp, int SL)
        {
            if (TimTonKho(MaKho, MaSp) != null)
            {
                TimTonKho(MaKho, MaSp).SoLuongTon += SL;
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public void CapNhatSLTonKhoHuy(string MaKho, string MaSp, int SL)
        {
            if (TimTonKho(MaKho, MaSp) != null)
            {
                TimTonKho(MaKho, MaSp).SoLuongTon -= SL;
                _banHangModelDataContext.SubmitChanges();
            }
        }
        public ActionResult Detail(string id)
        {
            // Lấy thông tin sản phẩm dựa trên ID
            SanPham sanPham = _banHangModelDataContext.SanPhams.FirstOrDefault(sp => sp.MaSanPham == id);

            if (sanPham == null)
            {
                return HttpNotFound(); // Trả về trang 404 nếu không tìm thấy sản phẩm
            }
            ViewBag.TenLoai = _banHangModelDataContext.LoaiSanPhams.Where(l => l.MaLoai == sanPham.MaLoai).FirstOrDefault().TenLoai;
            ViewBag.TenThuongHieu = _banHangModelDataContext.ThuongHieus.Where(th=>th.MaThuongHieu == sanPham.MaThuongHieu).FirstOrDefault().TenThuongHieu;
            return View(sanPham);
        }


    }
}