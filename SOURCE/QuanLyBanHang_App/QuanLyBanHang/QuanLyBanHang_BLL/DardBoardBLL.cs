using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class DardBoardBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();

        public QL_NguoiDungNhomNguoiDung TimNhomCuaNguoiDung(string Ten)
        {
            return _DataContext.QL_NguoiDungNhomNguoiDungs.Where(n => n.TenDangNhap == Ten).FirstOrDefault();
        }
        public List<QL_PhanQuyen> TimDSManHinhDuocQuyen(string Ten)
        {

            return _DataContext.QL_PhanQuyens.Where(q => q.MaNhomNguoiDung == TimNhomCuaNguoiDung(Ten).MaNhomNguoiDung).ToList();
        }
    }
}
