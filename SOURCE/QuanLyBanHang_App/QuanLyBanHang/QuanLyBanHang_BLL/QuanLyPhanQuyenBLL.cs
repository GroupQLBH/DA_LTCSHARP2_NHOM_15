using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyBanHang_BLL
{
    public class QuanLyPhanQuyenBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemDM_ManHinh(DM_ManHinh NV)
        {
            if (TimDM_ManHinh(NV.MaManHinh) == null)
            {
                _DataContext.DM_ManHinhs.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public DM_ManHinh TimDM_ManHinh(string Ma)
        {
            return _DataContext.DM_ManHinhs.Where(nv => nv.MaManHinh == Ma).FirstOrDefault();
        }
        public DM_ManHinh TimTenManHinh(string Ten)
        {
            return _DataContext.DM_ManHinhs.Where(nv => nv.TenManHinh == Ten).FirstOrDefault();
        }
        public void SuaDM_ManHinh(DM_ManHinh NV)
        {
            if (TimDM_ManHinh(NV.MaManHinh) != null)
            {
                TimDM_ManHinh(NV.MaManHinh).TenManHinh = NV.TenManHinh;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaDM_ManHinh(string Ma)
        {
            if (TimDM_ManHinh(Ma) != null)
            {
                _DataContext.DM_ManHinhs.DeleteOnSubmit(TimDM_ManHinh(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaDM_ManHinhTuDong()
        {
            var lastDM_ManHinh = _DataContext.DM_ManHinhs.OrderByDescending(nv => nv.MaManHinh).FirstOrDefault();
            if (lastDM_ManHinh != null)
            {
                string Ma = lastDM_ManHinh.MaManHinh.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "MH" + numberPart.ToString("D2");
            }
            return null;
        }
        public List<QL_PhanQuyen> TimDanhSachQuyenTheoMa(string Ma)
        {
            return _DataContext.QL_PhanQuyens.Where(pq=>pq.MaNhomNguoiDung == Ma).ToList();
        }


        public QL_PhanQuyen TimQuyenTrongNhom(string MaNhom, string MaMH)
        {
            return _DataContext.QL_PhanQuyens.Where(ql => ql.MaNhomNguoiDung == MaNhom && ql.MaManHinh == MaMH).FirstOrDefault();
        }

        public void themNhomNDVaoQuyen(QL_PhanQuyen QL)
        {
            _DataContext.QL_PhanQuyens.InsertOnSubmit(QL);
            _DataContext.SubmitChanges();
        }
        public void xoaNhomNDKhoiQuyen(string MaNhom, string MaMH)
        {
            _DataContext.QL_PhanQuyens.DeleteOnSubmit(TimQuyenTrongNhom(MaNhom, MaMH));
            _DataContext.SubmitChanges();
        }

        public void SuaQuyen(QL_PhanQuyen NV)
        {
            if (TimQuyenTrongNhom(NV.MaNhomNguoiDung,NV.MaManHinh) != null)
            {
                TimQuyenTrongNhom(NV.MaNhomNguoiDung, NV.MaManHinh).CoQuyen = NV.CoQuyen;
                _DataContext.SubmitChanges();
            }
        }
    }
}
