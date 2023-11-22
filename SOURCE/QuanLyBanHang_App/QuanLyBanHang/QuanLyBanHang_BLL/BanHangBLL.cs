using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class BanHangBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemChiTietDonHang(ChiTietDonHang NV)
        {
            if (TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham) == null)
            {
                _DataContext.ChiTietDonHangs.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public ChiTietDonHang TimChiTietDonHang(string MaPn, string MaKho, string MaSp)
        {
            return _DataContext.ChiTietDonHangs.Where(nv => nv.MaDonHang == MaPn && nv.MaKho == MaKho && nv.MaSanPham == MaSp).FirstOrDefault();
        }

        public ChiTietDonHang TimSLChiTietDonHang(int soLuong)
        {
            return _DataContext.ChiTietDonHangs.Where(nv => nv.SoLuong >= soLuong).FirstOrDefault();
        }
        public void SuaChiTietDonHang(ChiTietDonHang NV)
        {
            if (TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham) != null)
            {
                TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham).SoLuong = NV.SoLuong;
                TimChiTietDonHang(NV.MaDonHang, NV.MaKho, NV.MaSanPham).ThanhTien = NV.ThanhTien;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaChiTietDonHang(string MaPn, string MaKho, string MaSp)
        {
            if (TimChiTietDonHang(MaPn, MaKho, MaSp) != null)
            {
                _DataContext.ChiTietDonHangs.DeleteOnSubmit(TimChiTietDonHang(MaPn, MaKho, MaSp));
                _DataContext.SubmitChanges();
            }
        }
        public ChiTietDonHang TimChiTietDonHang_MaPn(string MaPn)
        {
            return _DataContext.ChiTietDonHangs.Where(nv => nv.MaDonHang == MaPn).FirstOrDefault();
        }

        public List<ChiTietDonHang> TimChiTietDonHangDanhSach(string MaPn)
        {
            return _DataContext.ChiTietDonHangs.Where(nv => nv.MaDonHang == MaPn).ToList();
        }
        public void XoaChiTietDonHang_MaPn(string MaPn)
        {
            if (TimChiTietDonHang_MaPn(MaPn) != null)
            {
                _DataContext.ChiTietDonHangs.DeleteOnSubmit(TimChiTietDonHang_MaPn(MaPn));
                _DataContext.SubmitChanges();
            }
        }

        public void ThemDonHang(DonHang NV)
        {
            if (TimDonHang(NV.MaDonHang) == null)
            {
                _DataContext.DonHangs.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public DonHang TimDonHang(string Ma)
        {
            return _DataContext.DonHangs.Where(nv => nv.MaDonHang == Ma).FirstOrDefault();
        }
        public void CapNhatTongTienChoDon(string Ma, double TongTien)
        {
            if (TimDonHang(Ma) != null)
            {
                TimDonHang(Ma).TongGia = TongTien;
                _DataContext.SubmitChanges();
            }
        }

        public void SuaDonHang(string maDon,DateTime ngayGiao,string trangThai)
        {
            if (TimDonHang(maDon) != null)
            {
                TimDonHang(maDon).NgayShipHang =ngayGiao;
                TimDonHang(maDon).TrangThaiDonHang = trangThai;
               _DataContext.SubmitChanges();
            }
        }
        public void XoaDonHang(string Ma)
        {
            if (TimDonHang(Ma) != null)
            {
                _DataContext.DonHangs.DeleteOnSubmit(TimDonHang(Ma));
                XoaChiTietDonHang_MaPn(Ma);
                _DataContext.SubmitChanges();
            }
        }

        public string MaDonHangTuDong()
        {
            var lastDonHang = _DataContext.DonHangs.OrderByDescending(nv => nv.MaDonHang).FirstOrDefault();
            if (lastDonHang != null)
            {
                string Ma = lastDonHang.MaDonHang.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "DH" + numberPart.ToString("D2");
            }
            return null;
        }
        public TonKho TimTonKho(string MaKho, string MaSp)
        {
            return _DataContext.TonKhos.Where(nv => nv.MaKho == MaKho && nv.MaSanPham == MaSp).FirstOrDefault();
        }
        public void XoaTonKho(string MaKho, string MaSp)
        {
            if (TimTonKho(MaKho, MaSp) != null)
            {
                _DataContext.TonKhos.DeleteOnSubmit(TimTonKho(MaKho, MaSp));
                _DataContext.SubmitChanges();
            }
        }
        public SanPham TimSanPham(string MaSp)
        {
            return _DataContext.SanPhams.Where(nv => nv.MaSanPham == MaSp).FirstOrDefault();
        }


        public void CapNhatSLSanPhamThem(string MaSp, int SL)
        {
            if (TimSanPham(MaSp) != null)
            {
                TimSanPham(MaSp).SoLuong += SL;
                _DataContext.SubmitChanges();
            }
        }

        public void CapNhatSLSanPhamHuy(string MaSp, int SL)
        {
            if (TimSanPham(MaSp) != null)
            {
                TimSanPham(MaSp).SoLuong -= SL;
                _DataContext.SubmitChanges();
            }
        }
        public void CapNhatSLTonKhoThem(string MaKho, string MaSp, int SL)
        {
            if (TimTonKho(MaKho, MaSp) != null)
            {
                TimTonKho(MaKho, MaSp).SoLuongTon += SL;
                _DataContext.SubmitChanges();
            }
        }
        public void CapNhatSLTonKhoHuy(string MaKho, string MaSp, int SL)
        {
            if (TimTonKho(MaKho, MaSp) != null)
            {
                TimTonKho(MaKho, MaSp).SoLuongTon -= SL;
                _DataContext.SubmitChanges();
            }
        }
        public string TenKhachHang(string Ma)
        {
            return _DataContext.KhachHangs.Where(kh => kh.MaKhachHang == Ma).FirstOrDefault().TenKhachHang;
        }
        public string DiaChiKho(string Ma)
        {
            return _DataContext.Khos.Where(kho => kho.MaKho == Ma).FirstOrDefault().DiaChiKho;
        }
        public string TenSanPham(string Ma)
        {
            return _DataContext.SanPhams.Where(sp => sp.MaSanPham == Ma).FirstOrDefault().TenSanPham;
        }
        public string TenNhanVien(string Ma)
        {
            return _DataContext.NhanViens.Where(nv => nv.MaNhanVien == Ma).FirstOrDefault().HoTen;
        }

        public string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng " : "");
        }
    }
}
