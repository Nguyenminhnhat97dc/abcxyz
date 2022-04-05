using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTruyen_Asp.Models;
namespace WebTruyen_Asp.Controllers
{
    public class NguoiDungController : Controller
    {
        dbWeb_TruyenDataContext data = new dbWeb_TruyenDataContext();

        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection Fields ,DANGNHAP ND)
        {
            var TenDangNhap = Fields["TenDangNhap"];
            var Email = Fields["Email"];
            var MatKhau = Fields["MatKhau"];
            var NhapLaiMatKhau = Fields["NhapLaiMatKhau"];
            var SDT = Fields["SDT"];
            if(String.IsNullOrEmpty(TenDangNhap))
            {
                ViewData["Loi1"] = "Tên Đăng Nhập không được để trống";
            }
            else
            {
                ND.TenDangNhap = TenDangNhap;
                ND.MatKhau = MatKhau;
                ND.Email = Email;
                ND.SDT = SDT;
                data.DANGNHAPs.InsertOnSubmit(ND);
                data.SubmitChanges();
                return RedirectToAction("DangNhap");
            }
            return this.DangKy();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection Fields, DANGNHAP ND)
        {
            var Email = Fields["Email"];
            var MatKhau = Fields["MatKhau"];
            var KiemTra = data.DANGNHAPs.Where(x => x.Email == Email && x.MatKhau == MatKhau).ToList();
            if(KiemTra.Count()==1)
            {
                Session["TaiKhoan"] = KiemTra.FirstOrDefault().TenDangNhap;
                Session["MatKhau"] = KiemTra.FirstOrDefault().MatKhau;
                //Session["avarta"] = KiemTra.FirstOrDefault().Avarta;
                return RedirectToAction(actionName: "Index", controllerName: "Truyen");
            }
            else
            {
                return RedirectToAction("DangKy");
            }
        }
    }
}