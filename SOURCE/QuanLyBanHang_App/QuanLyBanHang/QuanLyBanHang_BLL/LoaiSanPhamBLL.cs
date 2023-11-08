using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class LoaiSanPhamBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemLoaiSanPham(LoaiSanPham NV)
        {
            if (TimLoaiSanPham(NV.MaLoai) == null)
            {
                _DataContext.LoaiSanPhams.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public LoaiSanPham TimLoaiSanPham(string Ma)
        {
            return _DataContext.LoaiSanPhams.Where(nv => nv.MaLoai == Ma).FirstOrDefault();
        }

        public LoaiSanPham TimTenLoaiSanPham(string Ten)
        {
            return _DataContext.LoaiSanPhams.Where(nv => nv.TenLoai == Ten).FirstOrDefault();
        }
        public void SuaLoaiSanPham(LoaiSanPham NV)
        {
            if (TimLoaiSanPham(NV.MaLoai) != null)
            {
                TimLoaiSanPham(NV.MaLoai).TenLoai = NV.TenLoai;

                _DataContext.SubmitChanges();
            }
        }
        public void XoaLoaiSanPham(string Ma)
        {
            if (TimLoaiSanPham(Ma) != null)
            {
                _DataContext.LoaiSanPhams.DeleteOnSubmit(TimLoaiSanPham(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaLoaiSanPhamTuDong()
        {
            var lastLoaiSanPham = _DataContext.LoaiSanPhams.OrderByDescending(nv => nv.MaLoai).FirstOrDefault();
            if (lastLoaiSanPham != null)
            {
                string Ma = lastLoaiSanPham.MaLoai.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "ML" + numberPart.ToString("D2");
            }
            return null;
        }


        public List<LoaiSanPham> TimLoaiSanPhamTheoThuocTinh(string keyword)
        {
            return _DataContext.LoaiSanPhams.Where(
                nv => nv.MaLoai.ToString().Contains(keyword) ||
                nv.TenLoai.ToString().Contains(keyword)
                ).ToList();
        }
    }
}
