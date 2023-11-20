using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_BLL
{
    public class NhapHangBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();
        public void ThemChiTietPhieuNhap(ChiTietPhieuNhap NV)
        {
            if (TimChiTietPhieuNhap(NV.MaPhieuNhap,NV.MaKho,NV.MaSanPham) == null)
            {
                _DataContext.ChiTietPhieuNhaps.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public ChiTietPhieuNhap TimChiTietPhieuNhap(string MaPn,string MaKho,string MaSp)
        {
            return _DataContext.ChiTietPhieuNhaps.Where(nv => nv.MaPhieuNhap == MaPn && nv.MaKho ==MaKho && nv.MaSanPham ==MaSp).FirstOrDefault();
        }

        public ChiTietPhieuNhap TimSLChiTietPhieuNhap(int soLuong)
        {
            return _DataContext.ChiTietPhieuNhaps.Where(nv => nv.SoLuongNhap >= soLuong).FirstOrDefault();
        }
        public void SuaChiTietPhieuNhap(ChiTietPhieuNhap NV)
        {
            if (TimChiTietPhieuNhap(NV.MaPhieuNhap, NV.MaKho, NV.MaSanPham) != null)
            {
                TimChiTietPhieuNhap(NV.MaPhieuNhap, NV.MaKho, NV.MaSanPham).SoLuongNhap = NV.SoLuongNhap;

                _DataContext.SubmitChanges();
            }
        }
        public void XoaChiTietPhieuNhap(string MaPn, string MaKho, string MaSp)
        {
            if (TimChiTietPhieuNhap(MaPn,MaKho,MaSp) != null)
            {
                _DataContext.ChiTietPhieuNhaps.DeleteOnSubmit(TimChiTietPhieuNhap(MaPn, MaKho, MaSp));
                _DataContext.SubmitChanges();
            }
        }
        public ChiTietPhieuNhap TimChiTietPhieuNhap_MaPn(string MaPn)
        {
            return _DataContext.ChiTietPhieuNhaps.Where(nv => nv.MaPhieuNhap == MaPn).FirstOrDefault();
        }

        public List<ChiTietPhieuNhap> TimChiTietPhieuNhapDanhSach(string MaPn)
        {
            return _DataContext.ChiTietPhieuNhaps.Where(nv => nv.MaPhieuNhap == MaPn).ToList();
        }
        public void XoaChiTietPhieuNhap_MaPn(string MaPn)
        {
            if (TimChiTietPhieuNhap_MaPn(MaPn) != null)
            {
                _DataContext.ChiTietPhieuNhaps.DeleteOnSubmit(TimChiTietPhieuNhap_MaPn(MaPn));
                _DataContext.SubmitChanges();
            }
        }
    
        public void ThemPhieuNhapHang(PhieuNhapHang NV)
        {
            if (TimPhieuNhapHang(NV.MaPhieuNhap) == null)
            {
                _DataContext.PhieuNhapHangs.InsertOnSubmit(NV);
                _DataContext.SubmitChanges();
            }
        }
        public PhieuNhapHang TimPhieuNhapHang(string Ma)
        {
            return _DataContext.PhieuNhapHangs.Where(nv => nv.MaPhieuNhap == Ma).FirstOrDefault();
        }
        public void CapNhatTongTienChoPhieu(string Ma,double TongTien)
        {
            if (TimPhieuNhapHang(Ma) != null)
            {
                TimPhieuNhapHang(Ma).TongTien = TongTien;
                _DataContext.SubmitChanges();
            }
        }
        public void XoaPhieuNhapHang(string Ma)
        {
            if (TimPhieuNhapHang(Ma) != null)
            {
                _DataContext.PhieuNhapHangs.DeleteOnSubmit(TimPhieuNhapHang(Ma));
                XoaChiTietPhieuNhap_MaPn(Ma);
                _DataContext.SubmitChanges();
            }
        }
        
        public string MaPhieuNhapHangTuDong()
        {
            var lastPhieuNhapHang = _DataContext.PhieuNhapHangs.OrderByDescending(nv => nv.MaPhieuNhap).FirstOrDefault();
            if (lastPhieuNhapHang != null)
            {
                string Ma = lastPhieuNhapHang.MaPhieuNhap.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "PN" + numberPart.ToString("D2");
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
        public string TenNhaCungCap(string Ma)
        {
            return _DataContext.NhaCungCaps.Where(ncc =>ncc.MaNhaCungCap == Ma).FirstOrDefault().TenNhaCungCap;
        }
        public string DiaChiKho(string Ma)
        {
            return _DataContext.Khos.Where(kho => kho.MaKho == Ma).FirstOrDefault().DiaChiKho;
        }
        public string TenSanPham(string Ma)
        {
            return _DataContext.SanPhams.Where(sp => sp.MaSanPham == Ma).FirstOrDefault().TenSanPham;
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
