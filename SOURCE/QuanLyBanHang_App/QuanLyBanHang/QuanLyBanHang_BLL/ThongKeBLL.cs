using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyBanHang_BLL
{
    public class ThongKeBLL
    {
        QuanLyBanHang_LinQDataContext _DataContext = new QuanLyBanHang_LinQDataContext();



        public List<DonHang> DonHangTheoThangTrongNam(int Thang)
        {
            return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Month == Thang && dh.NgayDat.Value.Year == DateTime.Now.Year).ToList();
        }
        public List<DonHang> DonHangTheoThangTrongNam(int Thang,int Nam)
        {
            return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Month == Thang && dh.NgayDat.Value.Year == Nam).ToList();
        }
        public List<DonHang> DonHangTheoNgayThangTrongNam(int Ngay,int Thang,int Nam)
        {
            return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Month ==Thang && dh.NgayDat.Value.Year == Nam && dh.NgayDat.Value.Day == Ngay).ToList();
        }
        public List<DonHang> DonHangTheoNam(int Nam)
        {
            return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Year == Nam).ToList();
        }
        public List<DonHang> DonHangQuy(int Quy, int Nam)
        {
            if(Quy==1)
                return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Year == Nam && dh.NgayDat.Value.Month >=1 && dh.NgayDat.Value.Month <= 3).ToList();
            else if(Quy==2)
                return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Year == Nam && dh.NgayDat.Value.Month >= 4 && dh.NgayDat.Value.Month <= 6).ToList();
            else if (Quy == 3)
                return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Year == Nam && dh.NgayDat.Value.Month >= 7 && dh.NgayDat.Value.Month <= 9).ToList();
            else
                return _DataContext.DonHangs.Where(dh => dh.NgayDat.Value.Year == Nam && dh.NgayDat.Value.Month >= 10 && dh.NgayDat.Value.Month <= 12).ToList();
        }
        public double TongHoaDon(List<DonHang> donHangs)
        {
            double TongTienThang = 0;
            donHangs.ForEach(dh => { TongTienThang += (double)dh.TongGia; });
            return TongTienThang;
        }

        public int GetDaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("Tháng không hợp lệ");
            }

            bool isLeapYear = DateTime.IsLeapYear(year);

            if (month == 2)
            {
                return isLeapYear ? 29 : 28;
            }

            // Các tháng có 31 ngày: 1, 3, 5, 7, 8, 10, 12
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }

            // Các tháng có 30 ngày: 4, 6, 9, 11
            return 30;
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
