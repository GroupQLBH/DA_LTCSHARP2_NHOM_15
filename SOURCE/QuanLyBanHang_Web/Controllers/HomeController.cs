using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyBanHang_Web.Models; 
namespace QuanLyBanHang_Web.Controllers
{
    public class HomeController : Controller
    {
        BanHangModelDataContext _banHangModelDataContext = new BanHangModelDataContext("Data Source=LAPTOP-V9K1ICKI;Initial Catalog = QuanLyBanHang; User ID = sa; Password=123");
        public ActionResult Index()
        {
           
            List<SanPham> SanPham = _banHangModelDataContext.SanPhams.ToList();
            return View(SanPham);
        }

        public decimal giamGia(string Ma,decimal GiaGoc)
        {
            return GiaGoc - GiaGoc * _banHangModelDataContext.KhuyenMais.Where(km =>km.MaKhuyenMai == Ma).FirstOrDefault().GiamGia.Value;
        }
        
    }
}