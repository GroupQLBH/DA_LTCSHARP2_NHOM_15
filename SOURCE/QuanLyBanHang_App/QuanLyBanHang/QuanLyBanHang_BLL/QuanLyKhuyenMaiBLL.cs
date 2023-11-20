using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLyKhuyenMaiBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemKhuyenMai(KhuyenMai NV)
        {
            if (TimKhuyenMai(NV.MaKhuyenMai) == null)
            {
                _DataContext.KhuyenMais.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public KhuyenMai TimKhuyenMai(string Ma)
        {
            return _DataContext.KhuyenMais.Where(nv => nv.MaKhuyenMai == Ma).FirstOrDefault();
        }

        public KhuyenMai TimTenKhuyenMai(string Ten)
        {
            return _DataContext.KhuyenMais.Where(nv => nv.TenChuongTrinh == Ten).FirstOrDefault();
        }
        public void SuaKhuyenMai(KhuyenMai NV)
        {
            if (TimKhuyenMai(NV.MaKhuyenMai) != null)
            {
                TimKhuyenMai(NV.MaKhuyenMai).TenChuongTrinh = NV.TenChuongTrinh;
                TimKhuyenMai(NV.MaKhuyenMai).NgayBatDau = NV.NgayBatDau;
                TimKhuyenMai(NV.MaKhuyenMai).NgayKetThuc = NV.NgayKetThuc;
                TimKhuyenMai(NV.MaKhuyenMai).GiamGia = NV.GiamGia;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaKhuyenMai(string Ma)
        {
            if (TimKhuyenMai(Ma) != null)
            {
                _DataContext.KhuyenMais.DeleteOnSubmit(TimKhuyenMai(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaKhuyenMaiTuDong()
        {
            var lastKhuyenMai = _DataContext.KhuyenMais.OrderByDescending(nv => nv.MaKhuyenMai).FirstOrDefault();
            if (lastKhuyenMai != null)
            {
                string Ma = lastKhuyenMai.MaKhuyenMai.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "KM" + numberPart.ToString("D2");
            }
            return null;
        }


        public List<KhuyenMai> TimKhuyenMaiTheoThuocTinh(string keyword)
        {
            return _DataContext.KhuyenMais.Where(
                nv => nv.MaKhuyenMai.ToString().Contains(keyword) ||
                nv.TenChuongTrinh.ToString().Contains(keyword)
                ).ToList();
        }
    }
}
