using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHM_lession03.Controllers
{
    public class LHLShadowGardenController : Controller
    {
        /// <summary>
        /// Manga Author : Lê Hoàng Long
        /// Class : K22CNT3
        /// </summary>
        /// <returns></returns>
        // GET: LHLShadowGarden
        public ActionResult Index()
        {
            // Truyền dữ liệu từ Controllers Lên View
            ViewBag.fullname = "Ngo Hoang Minh";
            ViewData["Ngày sinh"] = "14/09/2004";
            TempData["Email"] = "minhngo140924@gmail.com";

            return View();
        }

        public ActionResult Details()
        {
            string lhlStr = "";
            lhlStr += "<h3>Họ Và Tên: Ngo Hoang Minh</h3>";
            lhlStr += "<p> Mã Sinh Viên : 2210900044";
            lhlStr += "<p> Địa Chỉ Email : minhngo140924@gmail.com";
            ViewBag.Details = lhlStr;

            return View("ChiTiet");
        }

        public ActionResult LangugeRazor()
        {
            string[] names = { "Lê Văn M ", "Trần Minh N", "Lê Trần Khac D", "Le Hoang L" };
            ViewBag.Names = names;
            return View();
        }

        /// HTMlHelper
        // GET: LHLShadowGarden/AddnewStudent
        public ActionResult AddnewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddnewStudent(FormCollection form)
        {
            // lấy dữ liệu trên form 
            string fullname = form["FullName"];
            string Masv = form["Mã Sinh Viên"];
            string TaiKhoan = form["Account"];
            string PassWord = form["PassWord"];
            string EnterThePassword = form["Password"];

            string lhlStr = "<h3>" + fullname + "</h3>";
            lhlStr += "<p>" + Masv;
            lhlStr += "<p>" + TaiKhoan;
            lhlStr += "<p>" + PassWord;
            lhlStr += "<p>" + EnterThePassword;

            ViewBag.info = lhlStr;

            return View("KetQua");
        }
    }
}