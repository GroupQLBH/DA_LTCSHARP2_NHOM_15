using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLyNhomNguoiDungBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemQL_NhomNguoiDung(QL_NhomNguoiDung NV)
        {
            if (TimQL_NhomNguoiDung(NV.MaNhom) == null)
            {
                _DataContext.QL_NhomNguoiDungs.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public QL_NhomNguoiDung TimQL_NhomNguoiDung(string Ma)
        {
            return _DataContext.QL_NhomNguoiDungs.Where(nv => nv.MaNhom == Ma).FirstOrDefault();
        }

        public void SuaQL_NhomNguoiDung(QL_NhomNguoiDung NV)
        {
            if (TimQL_NhomNguoiDung(NV.MaNhom) != null)
            {
                TimQL_NhomNguoiDung(NV.MaNhom).TenNhom = NV.TenNhom;
                TimQL_NhomNguoiDung(NV.MaNhom).GhiChu = NV.GhiChu;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaQL_NhomNguoiDung(string Ma)
        {
            if (TimQL_NhomNguoiDung(Ma) != null)
            {
                _DataContext.QL_NhomNguoiDungs.DeleteOnSubmit(TimQL_NhomNguoiDung(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaQL_NhomNguoiDungTuDong()
        {
            var lastQL_NhomNguoiDung = _DataContext.QL_NhomNguoiDungs.OrderByDescending(nv => nv.MaNhom).FirstOrDefault();
            if (lastQL_NhomNguoiDung != null)
            {
                string Ma = lastQL_NhomNguoiDung.MaNhom.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "NN" + numberPart.ToString("D2");
            }
            return null;
        }

        public QL_NguoiDungNhomNguoiDung TimNguoiDungTrongNhom(string Ma,string Ten)
        {
            return _DataContext.QL_NguoiDungNhomNguoiDungs.Where(ql => ql.MaNhomNguoiDung == Ma && ql.TenDangNhap==Ten).FirstOrDefault();
        }

        public void themNguoiDungVaoNhom(QL_NguoiDungNhomNguoiDung QL)
        {
            _DataContext.QL_NguoiDungNhomNguoiDungs.InsertOnSubmit(QL);
            _DataContext.SubmitChanges();
        }
        public void xoaNguoiDungKhoiNhom(string Ma, string Ten)
        {
            _DataContext.QL_NguoiDungNhomNguoiDungs.DeleteOnSubmit(TimNguoiDungTrongNhom(Ma, Ten));
            _DataContext.SubmitChanges();
        }
    }
}
