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
        public List<DonHang> TimDonHangCuaNhanVien(string Ma)
        {
            return _DataContext.DonHangs.Where(dh => dh.MaNhanVien == Ma).ToList();
        }
        public List<PhieuNhapHang> TimPhieuNhapCuaNhanVien(string Ma)
        {
            return _DataContext.PhieuNhapHangs.Where(dh => dh.MaNhanVien == Ma).ToList();
        }

        public List<Kho> TimKhoCuaNhanVien(string Ma)
        {
            return _DataContext.Khos.Where(dh => dh.MaNhanVien == Ma).ToList();
        }

        public void XoaNhanVien(string Ma)
        {
            if (TimNhanVien(Ma) != null)
            {
                foreach (var kho in TimKhoCuaNhanVien(Ma))
                {
                    kho.MaNhanVien = null;
                }
                foreach (var phieu in TimPhieuNhapCuaNhanVien(Ma))
                {
                    phieu.MaNhanVien = null;
                }
                foreach (var don in TimDonHangCuaNhanVien(Ma))
                {
                    don.MaNhanVien = null;
                }
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

        public List<QL_NguoiDung> TimTaiKhoan(string Ma)
        {
            return _DataContext.QL_NguoiDungs.Where(tk=>tk.TenDangNhap == Ma).ToList();
        }
        
        public List<NhanVien> TimNhanVienTheoThuocTinh(string keyword)
        {
            return _DataContext.NhanViens.Where(
                nv => nv.MaNhanVien.ToString().Contains(keyword) || 
                nv.HoTen.ToString().Contains(keyword) || 
                nv.Luong.ToString().Contains(keyword) || 
                nv.ChucVu.ToString().Contains(keyword) || 
                nv.SoDienThoai.ToString().Contains(keyword) || nv.CCCD.ToString().Contains(keyword)).ToList(); 
        }
    }
}
