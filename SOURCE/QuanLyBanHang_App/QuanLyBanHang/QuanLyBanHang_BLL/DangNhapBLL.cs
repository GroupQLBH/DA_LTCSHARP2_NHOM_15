using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class DangNhapBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public QL_NguoiDung TimTaiKhoanMK (string Ten,string MatKhau)
        {
            return _DataContext.QL_NguoiDungs.Where(tk=>tk.TenDangNhap==Ten && tk.MatKhau==MatKhau).FirstOrDefault();
        }
        public QL_NguoiDung TimTaiKhoan(string Ten)
        {
            return _DataContext.QL_NguoiDungs.Where(tk => tk.TenDangNhap == Ten).FirstOrDefault();
        }
        public void SuaTaiKhoan(QL_NguoiDung TK)
        {
            if (TimTaiKhoan(TK.TenDangNhap) != null)
            {
                TimTaiKhoan(TK.TenDangNhap).MatKhau = TK.MatKhau;
                _DataContext.SubmitChanges();
            }
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
