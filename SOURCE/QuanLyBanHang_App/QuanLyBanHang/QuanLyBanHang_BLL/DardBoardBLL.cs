using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class DardBoardBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();

        public QL_NguoiDungNhomNguoiDung TimNhomCuaNguoiDung(string Ten)
        {
            return _DataContext.QL_NguoiDungNhomNguoiDungs.Where(n => n.TenDangNhap == Ten).FirstOrDefault();
        }
        public List<QL_PhanQuyen> TimDSManHinhDuocQuyen(string Ten)
        {

            return _DataContext.QL_PhanQuyens.Where(q => q.MaNhomNguoiDung == TimNhomCuaNguoiDung(Ten).MaNhomNguoiDung).ToList();
        }

        public string TenNhanVien(string Ma)
        {
            return _DataContext.NhanViens.Where(nv=>nv.MaNhanVien == Ma).FirstOrDefault().HoTen;
        }
        public QL_NguoiDung TimTaiKhoan(string Ten)
        {
            return _DataContext.QL_NguoiDungs.Where(tk => tk.TenDangNhap == Ten).FirstOrDefault();
        }
        public void SuaTinhTrangHoatDong(QL_NguoiDung TK)
        {
            if (TimTaiKhoan(TK.TenDangNhap) != null)
            {
                TimTaiKhoan(TK.TenDangNhap).HoatDong = TK.HoatDong;
                _DataContext.SubmitChanges();
            }
        }
    }
}
