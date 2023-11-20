using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLyNhaCungCapBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemNhaCungCap(NhaCungCap NV)
        {
            if (TimNhaCungCap(NV.MaNhaCungCap) == null)
            {
                _DataContext.NhaCungCaps.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public NhaCungCap TimNhaCungCap(string Ma)
        {
            return _DataContext.NhaCungCaps.Where(nv => nv.MaNhaCungCap == Ma).FirstOrDefault();
        }

        public NhaCungCap TimTenNhaCungCap(string Ten)
        {
            return _DataContext.NhaCungCaps.Where(nv => nv.TenNhaCungCap == Ten).FirstOrDefault();
        }
        public void SuaNhaCungCap(NhaCungCap NV)
        {
            if (TimNhaCungCap(NV.MaNhaCungCap) != null)
            {
                TimNhaCungCap(NV.MaNhaCungCap).TenNhaCungCap = NV.TenNhaCungCap;
                TimNhaCungCap(NV.MaNhaCungCap).DiaChi = NV.DiaChi;
                TimNhaCungCap(NV.MaNhaCungCap).Email = NV.Email;
                TimNhaCungCap(NV.MaNhaCungCap).SoDienThoai = NV.SoDienThoai;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaNhaCungCap(string Ma)
        {
            if (TimNhaCungCap(Ma) != null)
            {
                _DataContext.NhaCungCaps.DeleteOnSubmit(TimNhaCungCap(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaNhaCungCapTuDong()
        {
            var lastNhaCungCap = _DataContext.NhaCungCaps.OrderByDescending(nv => nv.MaNhaCungCap).FirstOrDefault();
            if (lastNhaCungCap != null)
            {
                string Ma = lastNhaCungCap.MaNhaCungCap.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "NCC" + numberPart.ToString("D2");
            }
            return null;
        }


        public List<NhaCungCap> TimNhaCungCapTheoThuocTinh(string keyword)
        {
            return _DataContext.NhaCungCaps.Where(
                nv => nv.MaNhaCungCap.ToString().Contains(keyword) ||
                nv.TenNhaCungCap.ToString().Contains(keyword) ||
                nv.SoDienThoai.ToString().Contains(keyword)||
                nv.DiaChi.ToString().Contains(keyword) ||
                nv.Email.ToString().Contains(keyword) 
                ).ToList();
        }
    }
}
