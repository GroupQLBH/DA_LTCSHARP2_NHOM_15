using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using QuanLyBanHang_Web.Models;
using System.Security.Cryptography;

namespace QuanLyBanHang_Web.Controllers
{
    public class AccountController : Controller
    {
        BanHangModelDataContext _banHangModelDataContext = new BanHangModelDataContext("Data Source=LAPTOP-V9K1ICKI;Initial Catalog = QuanLyBanHang; User ID = sa; Password=123");
        // GET: Account
        public ActionResult Login()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            TaiKhoan user = _banHangModelDataContext.TaiKhoans.FirstOrDefault(u => u.TenTaiKhoan == username && u.MatKhau == password);
            if (user != null)
            {
                // Đăng nhập thành công, thực hiện các hành động cần thiết
                // Ví dụ: Lưu thông tin người dùng vào Session và chuyển hướng đến trang chính
                Session["MaKhach"]=user.MaKhachHang;
                Session["TenTK"] = user.TenTaiKhoan;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Số điện thoại hoặc mật khẩu không đúng !";
                return View("Login");
            }    
            
        }

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^0\d{9,}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public KhachHang TimSDTKhachHang(string Sdt)
        {
            return _banHangModelDataContext.KhachHangs.Where(nv => nv.SoDienThoai == Sdt).FirstOrDefault();
        }
        public string MaKhachHangTuDong()
        {
            var lastKhachHang = _banHangModelDataContext.KhachHangs.OrderByDescending(nv => nv.MaKhachHang).FirstOrDefault();
            if (lastKhachHang != null)
            {
                string Ma = lastKhachHang.MaKhachHang.Substring(2);
                int numberPart = Convert.ToInt16(Ma);
                numberPart++;
                return "KH" + numberPart.ToString("D2");
            }
            return null;
        }
        [HttpPost]
        public ActionResult Register(string fullName, string username, string password)
        {
            string ma = MaKhachHangTuDong();
            if (!IsValidPhoneNumber(username) || TimSDTKhachHang(username) !=null )
            {
                ViewBag.ErrorMessage = "Số điện thoại không hợp lệ hoặc đã có người khác sử dụng !";
                return View("Register");
            }
            else
            {
                var newCustomer = new KhachHang
                {
                    MaKhachHang = ma,
                    TenKhachHang = fullName,
                    SoDienThoai = username,
                    // Thêm các thông tin khách hàng khác nếu cần thiết
                };

                var newUser = new TaiKhoan
                {
                    MaKhachHang = ma,
                    TenTaiKhoan = username,
                    MatKhau = password
                    // Thêm các thông tin người dùng khác nếu cần thiết
                };


                _banHangModelDataContext.KhachHangs.InsertOnSubmit(newCustomer);
                _banHangModelDataContext.TaiKhoans.InsertOnSubmit(newUser);

                _banHangModelDataContext.SubmitChanges();

                // Đăng ký thành công, có thể chuyển hướng đến trang đăng nhập hoặc thực hiện hành động khác
                return RedirectToAction("Login");
            }
        }
    }
}