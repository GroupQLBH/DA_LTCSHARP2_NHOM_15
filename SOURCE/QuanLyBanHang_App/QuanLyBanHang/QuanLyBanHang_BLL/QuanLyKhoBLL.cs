using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLyKhoBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemKho(Kho NV)
        {
            if (TimKho(NV.MaKho) == null)
            {
                _DataContext.Khos.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public Kho TimKho(string Ma)
        {
            return _DataContext.Khos.Where(nv => nv.MaKho == Ma).FirstOrDefault();
        }

        public Kho TimTenKho(string Ten)
        {
            return _DataContext.Khos.Where(nv => nv.TenKho == Ten).FirstOrDefault();
        }
        public void SuaKho(Kho NV)
        {
            if (TimKho(NV.MaKho) != null)
            {
                TimKho(NV.MaKho).TenKho = NV.TenKho;
                TimKho(NV.MaKho).DiaChiKho = NV.DiaChiKho;
                TimKho(NV.MaKho).MaNhanVien = NV.MaNhanVien;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaKho(string Ma)
        {
            if (TimKho(Ma) != null)
            {
                _DataContext.Khos.DeleteOnSubmit(TimKho(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaKhoTuDong()
        {
            var lastKho = _DataContext.Khos.OrderByDescending(nv => nv.MaKho).FirstOrDefault();
            if (lastKho != null)
            {
                string Ma = lastKho.MaKho.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "K" + numberPart.ToString("D2");
            }
            return null;
        }


        public List<Kho> TimKhoTheoThuocTinh(string keyword)
        {
            return _DataContext.Khos.Where(
                nv => nv.MaKho.ToString().Contains(keyword) ||
                nv.TenKho.ToString().Contains(keyword)||
                nv.MaKho.ToString().Contains(keyword)||
                nv.DiaChiKho.ToString().Contains(keyword)
                ).ToList();
        }
    }
}
