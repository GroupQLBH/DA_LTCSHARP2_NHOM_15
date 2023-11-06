using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLyNguoiDungBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemNhanVien(NhanVien NV)
        {
            if (TimNhanVien(NV.MaNhanVien) == null)
            {
                _DataContext.NhanViens.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public NhanVien TimNhanVien(string Ma)
        {
           return _DataContext.NhanViens.Where(nv => nv.MaNhanVien == Ma).FirstOrDefault();
        }

        public void SuaNhanVien(NhanVien NV)
        {
            if (TimNhanVien(NV.MaNhanVien) != null)
            {
                TimNhanVien(NV.MaNhanVien).HoTen = NV.HoTen;
                TimNhanVien(NV.MaNhanVien).CCCD = NV.CCCD;
                TimNhanVien(NV.MaNhanVien).SoDienThoai = NV.SoDienThoai;
                TimNhanVien(NV.MaNhanVien).Luong = NV.Luong;
                TimNhanVien(NV.MaNhanVien).ChucVu = NV.ChucVu;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaNhanVien(string Ma)
        {
            if (TimNhanVien(Ma) != null)
            {
                _DataContext.NhanViens.DeleteOnSubmit(TimNhanVien(Ma));
                _DataContext.SubmitChanges();
            } 
        }

        public string MaNhanVienTuDong()
        {
            var lastNhanVien = _DataContext.NhanViens.OrderByDescending(nv => nv.MaNhanVien).FirstOrDefault();
            if (lastNhanVien != null)
            {
                string Ma = lastNhanVien.MaNhanVien.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "NV" + numberPart.ToString("D2");
            }
            return null;
        }

        public void ThemTaiKhoan(QL_NguoiDung TK)
        {

            _DataContext.QL_NguoiDungs.InsertOnSubmit(TK);
            _DataContext.SubmitChanges();
        }

        public QL_NguoiDung TimTaiKhoan(string Ma)
        {
            return _DataContext.QL_NguoiDungs.Where(tk=>tk.TenDangNhap == Ma).FirstOrDefault();
        }
        
    }
}
