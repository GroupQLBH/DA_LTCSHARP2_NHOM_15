using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLyThuongHieuBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemThuongHieu(ThuongHieu NV)
        {
            if (TimThuongHieu(NV.MaThuongHieu) == null)
            {
                _DataContext.ThuongHieus.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public ThuongHieu TimThuongHieu(string Ma)
        {
            return _DataContext.ThuongHieus.Where(nv => nv.MaThuongHieu == Ma).FirstOrDefault();
        }

        public ThuongHieu TimTenThuongHieu(string Ten)
        {
            return _DataContext.ThuongHieus.Where(nv => nv.TenThuongHieu == Ten).FirstOrDefault();
        }
        public void SuaThuongHieu(ThuongHieu NV)
        {
            if (TimThuongHieu(NV.MaThuongHieu) != null)
            {
                TimThuongHieu(NV.MaThuongHieu).TenThuongHieu = NV.TenThuongHieu;
                
                _DataContext.SubmitChanges();
            }
        }
        public void XoaThuongHieu(string Ma)
        {
            if (TimThuongHieu(Ma) != null)
            {
                _DataContext.ThuongHieus.DeleteOnSubmit(TimThuongHieu(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaThuongHieuTuDong()
        {
            var lastThuongHieu = _DataContext.ThuongHieus.OrderByDescending(nv => nv.MaThuongHieu).FirstOrDefault();
            if (lastThuongHieu != null)
            {
                string Ma = lastThuongHieu.MaThuongHieu.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "TH" + numberPart.ToString("D2");
            }
            return null;
        }


        public List<ThuongHieu> TimThuongHieuTheoThuocTinh(string keyword)
        {
            return _DataContext.ThuongHieus.Where(
                nv => nv.MaThuongHieu.ToString().Contains(keyword) ||
                nv.TenThuongHieu.ToString().Contains(keyword)
                ).ToList();
        }
    }
}
