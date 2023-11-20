using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class QuanLySanPhamBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemSanPham(SanPham NV)
        {
            if (TimSanPham(NV.MaSanPham) == null)
            {
                _DataContext.SanPhams.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public SanPham TimSanPham(string Ma)
        {
            return _DataContext.SanPhams.Where(nv => nv.MaSanPham == Ma).FirstOrDefault();
        }

        public SanPham TimTenSanPham(string Ten)
        {
            return _DataContext.SanPhams.Where(nv => nv.TenSanPham == Ten).FirstOrDefault();
        }
        public void SuaSanPham(SanPham NV)
        {
            if (TimSanPham(NV.MaSanPham) != null)
            {
                TimSanPham(NV.MaSanPham).TenSanPham = NV.TenSanPham;
                TimSanPham(NV.MaSanPham).MoTaSanPham = NV.MoTaSanPham;
                TimSanPham(NV.MaSanPham).Gia = NV.Gia;
                TimSanPham(NV.MaSanPham).SoLuong = NV.SoLuong;
                TimSanPham(NV.MaSanPham).MaLoai = NV.MaLoai;
                TimSanPham(NV.MaSanPham).MaKhuyenMai = NV.MaKhuyenMai;
                TimSanPham(NV.MaSanPham).MaThuongHieu = NV.MaThuongHieu;
                TimSanPham(NV.MaSanPham).NgayCapNhat = NV.NgayCapNhat;
                TimSanPham(NV.MaSanPham).TrangThai = NV.TrangThai;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaSanPham(string Ma)
        {
            if (TimSanPham(Ma) != null)
            {
                _DataContext.SanPhams.DeleteOnSubmit(TimSanPham(Ma));
                _DataContext.SubmitChanges();
            }
        }

        public string MaSanPhamTuDong()
        {
            var lastSanPham = _DataContext.SanPhams.OrderByDescending(nv => nv.MaSanPham).FirstOrDefault();
            if (lastSanPham != null)
            {
                string Ma = lastSanPham.MaSanPham.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "SP" + numberPart.ToString("D2");
            }
            return null;
        }

        public string TenThuongHieu(string MaTH)
        {
            return _DataContext.ThuongHieus.Where(th => th.MaThuongHieu == MaTH).FirstOrDefault().TenThuongHieu.ToString();   
        }
        public string TenLoaiSanPham(string MaLSP)
        {
            return _DataContext.LoaiSanPhams.Where(th => th.MaLoai == MaLSP).FirstOrDefault().TenLoai.ToString();
        }
        public string TenKhuyenMai(string MaKM)
        {
            return _DataContext.KhuyenMais.Where(th => th.MaKhuyenMai == MaKM).FirstOrDefault().TenChuongTrinh.ToString();
        }

        public List<SanPham> TimSanPhamTheoThuocTinh(string keyword)
        {
            return _DataContext.SanPhams.Where(
                nv => nv.MaSanPham.ToString().Contains(keyword) ||
                nv.TenSanPham.ToString().Contains(keyword)||
                nv.TrangThai.ToString().Contains(keyword)||
                nv.MaLoai.ToString().Contains(keyword)||
                nv.MaKhuyenMai.ToString().Contains(keyword)||
                nv.MaThuongHieu.ToString().Contains(keyword)||
                nv.Gia.ToString().Contains(keyword)||
                nv.SoLuong.ToString().Contains(keyword)||
                TenKhuyenMai(nv.MaKhuyenMai.ToString()).Contains(keyword) ||
                TenLoaiSanPham(nv.MaLoai.ToString()).Contains(keyword) ||
                TenThuongHieu(nv.MaThuongHieu.ToString()).Contains(keyword)
                ).ToList();
        }
    }
}
