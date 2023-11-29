using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLyKhachHangBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemKhachHang(KhachHang NV)
        {
            if (TimKhachHang(NV.MaKhachHang) == null)
            {
                _DataContext.KhachHangs.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public KhachHang TimKhachHang(string Ma)
        {
            return _DataContext.KhachHangs.Where(nv => nv.MaKhachHang == Ma).FirstOrDefault();
        }

        public KhachHang TimSDTKhachHang(string Sdt)
        {
            return _DataContext.KhachHangs.Where(nv => nv.SoDienThoai == Sdt).FirstOrDefault();
        }

        public KhachHang TimEmailKhachHang(string email)
        {
            return _DataContext.KhachHangs.Where(nv => nv.Email == email).FirstOrDefault();
        }
        public void SuaKhachHang(KhachHang NV)
        {
            if (TimKhachHang(NV.MaKhachHang) != null)
            {
                TimKhachHang(NV.MaKhachHang).TenKhachHang = NV.TenKhachHang;
                TimKhachHang(NV.MaKhachHang).DiaChi = NV.DiaChi;
                TimKhachHang(NV.MaKhachHang).SoDienThoai = NV.SoDienThoai;
                TimKhachHang(NV.MaKhachHang).NgaySinh = NV.NgaySinh;
                TimKhachHang(NV.MaKhachHang).Email = NV.Email;
                TimKhachHang(NV.MaKhachHang).GioiTinh = NV.GioiTinh;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaKhachHang(string Ma)
        {
            if (TimKhachHang(Ma) != null)
            {
                _DataContext.KhachHangs.DeleteOnSubmit(TimKhachHang(Ma));
                XoaTaiKhoan(Ma);
                _DataContext.SubmitChanges();
            }
        }

        public void XoaTaiKhoan(string Ma)
        {
            if (TimTK(Ma) != null)
            {
                _DataContext.TaiKhoans.DeleteOnSubmit(TimTK(Ma));
                _DataContext.SubmitChanges();
            }
        }
        public string MaKhachHangTuDong()
        {
            var lastKhachHang = _DataContext.KhachHangs.OrderByDescending(nv => nv.MaKhachHang).FirstOrDefault();
            if (lastKhachHang != null)
            {
                string Ma = lastKhachHang.MaKhachHang.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "KH" + numberPart.ToString("D2");
            }
            return null;
        }

        public TaiKhoan TimTK(string Ma)
        {
            return _DataContext.TaiKhoans.Where(tk => tk.MaKhachHang == Ma).FirstOrDefault();
        }
        public List<TaiKhoan> TimTaiKhoan(string Ma)
        {
            return _DataContext.TaiKhoans.Where(tk => tk.MaKhachHang == Ma).ToList();
        }

        public List<KhachHang> TimKhachHangTheoThuocTinh(string keyword)
        {
            return _DataContext.KhachHangs.Where(
                nv => nv.MaKhachHang.ToString().Contains(keyword) ||
                nv.TenKhachHang.ToString().Contains(keyword) ||
                nv.GioiTinh.ToString().Contains(keyword) ||
                nv.SoDienThoai.ToString().Contains(keyword) ||
                nv.Email.ToString().Contains(keyword) || 
                nv.DiaChi.ToString().Contains(keyword)).ToList();
        }

        public string TimNhomNguoiDung(string ma)
        {
            return _DataContext.QL_NguoiDungNhomNguoiDungs.Where(nd=>nd.TenDangNhap==ma).FirstOrDefault().MaNhomNguoiDung;
        }
    }
}
