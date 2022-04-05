using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using WebTruyen_Asp.Models;
using WebTruyen_Asp.Class;
using System.Web.UI;
using System.IO;

namespace WebTruyen_Asp.Controllers
{
    public class TruyenController : Controller
    {
        dbWeb_TruyenDataContext data = new dbWeb_TruyenDataContext();

        // GET: Truyen
        public ActionResult Index()
        {
            var btv_decu = (from a in data.DECUs
                            join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                            join c in data.DANGNHAPs on b.MaDN equals c.MaDN
                            join d in data.THELOAIs on b.MaTL equals d.MaTL
                            join e in data.CHUONGs on b.MaTruyen equals e.MaTruyen
                            select new BTV_Decu() { TenTruyen = b.TenTruyen, AnhBia = b.AnhBia, TenND = c.TenDangNhap, MaTruyen = b.MaTruyen, TheLoai = d.TenTL,TenFoder = e.TenFoder }).Distinct();
            return View(btv_decu.ToList());
        }
        public ActionResult MoiDang()
        {
            var thongtin = (from a in data.TRUYENs
                           join b in data.THELOAIs on a.MaTL equals b.MaTL
                           join c in data.CHUONGs on a.MaTruyen equals c.MaTruyen
                           orderby a.NgayDang descending
                           select new MoiDang() { TenTruyen = a.TenTruyen, AnhBia = a.AnhBia, TheLoai = b.TenTL, 
                           TenFoder= c.TenFoder,MaTruyen=a.MaTruyen }).Distinct();
                           
            return PartialView(thongtin.Take(5).ToList());
        }    
        public ActionResult MoiCapNhap()
        {
            var moiCapNhap = from a in data.CHUONGs
                             join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                             join c in data.DANGNHAPs on a.MaDN equals c.MaDN
                             join d in data.TACGIAs on b.MaTG equals d.MaTG
                             join e in data.THELOAIs on b.MaTL equals e.MaTL

                             orderby a.NgayDang descending
                             select new MoiCapNhapChuong()
                             {
                                 TheLoai = e.TenTL,
                                 TenTruyen = b.TenTruyen,
                                 Chuong = a.IdChuong,
                                 TacGia = d.TenTG,
                                 TieuDeChuong = a.TenChuong,
                                 NguoiDang = c.TenDangNhap,
                                 ThoiGian = Convert.ToDateTime(a.NgayDang),
                                 MaTruyen = b.MaTruyen
                             };
            return PartialView(moiCapNhap.Take(10).ToList());
        }
        public ActionResult NhanThuong_Top()
        {
            var thongtin = from a in data.NHANTHUONGs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemNT descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemNT,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Take(1).FirstOrDefault());
        }
        public ActionResult NhanThuong_Top_2()
        {
            var thongtin = from a in data.NHANTHUONGs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemNT descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemNT,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(2).Take(1).FirstOrDefault());
        }
        public ActionResult NhanThuong_Top_3()
        {
            var thongtin = from a in data.NHANTHUONGs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemNT descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemNT,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(3).Take(1).FirstOrDefault());
        }
        public ActionResult NhanThuong_Top_10()
        {
            var thongtin = from a in data.NHANTHUONGs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemNT descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemNT,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(4).Take(7).ToList());
        }
        public ActionResult ThinhHanh_Top()
        {
            var thongtin = from a in data.THINHHANHs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemTH descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemTH,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Take(1).FirstOrDefault());
        }
        public ActionResult ThinhHanh_Top_2()
        {
            var thongtin = from a in data.THINHHANHs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemTH descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemTH,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(2).Take(1).FirstOrDefault());
        }
        public ActionResult ThinhHanh_Top_3()
        {
            var thongtin = from a in data.THINHHANHs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemTH descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemTH,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(3).Take(1).FirstOrDefault());
        }
        public ActionResult ThinhHanh_Top_10()
        {
            var thongtin = from a in data.THINHHANHs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemTH descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemTH,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(4).Take(7).ToList());
        }
        public ActionResult DeCu_Top()
        {
            var thongtin = from a in data.Rank_DeCus
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemDC descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemDC,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Take(1).FirstOrDefault());
        }
        public ActionResult DeCu_Top_2()
        {
            var thongtin = from a in data.Rank_DeCus
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemDC descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemDC,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(2).Take(1).FirstOrDefault());
        }
        public ActionResult DeCu_Top_3()
        {
            var thongtin = from a in data.Rank_DeCus
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemDC descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemDC,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(3).Take(1).FirstOrDefault());
        }
        public ActionResult DeCu_Top_10()
        {
            var thongtin = from a in data.Rank_DeCus
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           join c in data.THELOAIs on b.MaTL equals c.MaTL
                           join d in data.TACGIAs on b.MaTG equals d.MaTG
                           orderby a.DiemDC descending
                           select new ThinhHanh()
                           {
                               TenTruyen = b.TenTruyen,
                               TacGia = d.TenTG,
                               NhanThuong = (int)a.DiemDC,
                               TheLoai = c.TenTL,
                               AnhBia = b.AnhBia,
                               MaTruyen = b.MaTruyen
                           };
            return PartialView(thongtin.Skip(4).Take(7).ToList());
        }
        public ActionResult MoiHoanThanh()
        {
            var moiHoanThanh = from a in data.TRUYENs
                               join b in data.DANGNHAPs on a.MaDN equals b.MaDN
                               join c in data.THELOAIs on a.MaTL equals c.MaTL
                               where a.TrangThai == "Hoàn Thành"
                               select new MoiHoanThanh() { TenTruyen = a.TenTruyen, AnhBia = a.AnhBia, TenND = b.TenDangNhap, TheLoai = c.TenTL, MaTruyen = a.MaTruyen };
            return PartialView(moiHoanThanh.ToList());
        }
        public ActionResult ChiTietTruyen(int id)
        {
            var ChiTietTruyen = from a in data.TRUYENs
                                join b in data.CHUONGs on a.MaTruyen equals b.MaTruyen
                                join c in data.TACGIAs on a.MaTG equals c.MaTG
                                join d in data.THELOAIs on a.MaTL equals d.MaTL
                                join e in data.DANGNHAPs on a.MaDN equals e.MaDN
                                where a.MaTruyen == id
                                select new ChiTietTruyen()
                                {
                                    HinhAnh = a.AnhBia,
                                    TenTruyen = a.TenTruyen,
                                    TacGia = c.TenTG,
                                    TrangThai = a.TrangThai,
                                    TheLoai = d.TenTL,
                                    TongChuong = (from f in data.CHUONGs
                                                  join e in data.TRUYENs on f.MaTruyen equals e.MaTruyen
                                                  where f.MaTruyen == id
                                                  select b.IdChuong).Count(),
                                    TieuDeChuong = b.TenChuong,
                                    MaNguoDang = e.MaDN,
                                    MaTruyen = id,
                                    Diem_ReView = Diem_ReView(id)
                                };
            return View(ChiTietTruyen.FirstOrDefault());
        }
        public double Diem_ReView(int id)
        {
            var ThongTin = data.Reviews.Where(x => x.MaDN == id).ToList();
            if(ThongTin.Count()!=0)
            {
                double TinhCach = (int)ThongTin.Select(x => x.TinhCachNhanVat).Average();
                double CotTruyen = (int)ThongTin.Select(x => x.CotTruyen).Average();
                double BoCuc = (int)ThongTin.Select(x => x.BoCucTheGioi).Average();
                double KetQua = (TinhCach + CotTruyen + BoCuc) / 60;
                return Math.Round(KetQua,1);
            }
            else
            {

                double KetQua = 0;
                return Math.Round(KetQua, 1);
            }
            
        }
        public ActionResult NguoiDang(int id)
        {
            var ThongTin = from b in data.DANGNHAPs
                           select new NguoiDang()
                           {
                               TenNguoiDang = b.TenDangNhap,
                               Avatar = b.avatar,
                               SoTruyenDaDang = (from a in data.TRUYENs
                                                 join c in data.DANGNHAPs on a.MaDN equals c.MaDN
                                                 where a.MaDN == id
                                                 select a.MaTruyen).Count(),
                               TongSoChuongDaDang = (from a in data.TRUYENs
                                                     join d in data.CHUONGs on a.MaTruyen equals d.MaTruyen
                                                     join c in data.DANGNHAPs on a.MaDN equals c.MaDN
                                                     where a.MaDN == id
                                                     select d.IdChuong).Count(),
                           };
            return PartialView(ThongTin.FirstOrDefault());
        }
        public ActionResult SliderShow_Master2(int id)
        {
            var ThongTin = from a in data.TRUYENs
                           join b in data.THELOAIs on a.MaTL equals b.MaTL
                           where a.MaDN == id
                           select new NguoiDang_Truyen()
                           {
                               AnhBia = a.AnhBia,
                               TenTruyen = a.TenTruyen,
                               TheLoai = b.TenTL
                           };
            return PartialView(ThongTin.Take(5).ToList());
        }
        [HttpPost]
        public ActionResult ReView(FormCollection Fields, Review bl)
        {
            var BinhLuan = Fields["BinhLuan"];
            var User = Fields["User"];
            var MaTruyen = Fields["MaTruyen"];
            var TinhCanh = Fields["TinhCach"];
            var CotTruyen = Fields["CotTruyen"];
            var BoCuc = Fields["BoCuc"];
            if (String.IsNullOrEmpty(BinhLuan))
            {
                return RedirectToAction("ChiTietTruyen", new { id = MaTruyen });
            }
            else
            if(String.IsNullOrEmpty(User))
            {

                return RedirectToAction("DangNhap", "NguoiDung");
            } 
            else
            {
                bl.NoiDung = BinhLuan;
                bl.MaTruyen = int.Parse(MaTruyen);
                var MaDN = data.DANGNHAPs.Where(x => x.TenDangNhap == User).ToList();
                bl.MaDN = MaDN.FirstOrDefault().MaDN;
                bl.TinhCachNhanVat = int.Parse(TinhCanh);
                bl.CotTruyen = int.Parse(CotTruyen);
                bl.BoCucTheGioi = int.Parse(BoCuc);
                data.Reviews.InsertOnSubmit(bl);
                data.SubmitChanges();
                return RedirectToAction("ChiTietTruyen",new { id =MaTruyen});
            }
        }
        public ActionResult View_ReView(int MaTruyen,int MaUser)
        {
            var ThongTin = from a in data.Reviews
                           where a.MaTruyen == MaTruyen
                           orderby a.MaRV descending

                           select new View_Review()
                           {
                               TenNguoiDung = (from b in data.DANGNHAPs
                                               where b.MaDN == MaUser
                                               join c in data.Reviews on b.MaDN equals c.MaDN
                                               select b.TenDangNhap).FirstOrDefault(),
                               Avatar = (from b in data.DANGNHAPs
                                         where b.MaDN == MaUser
                                         join c in data.Reviews on b.MaDN equals c.MaDN
                                         select b.avatar).FirstOrDefault(),
                               NoiDungBinhLuan = a.NoiDung,
                               Diem_Reivew = Diem_ReView_CaNhan(MaTruyen,MaUser)
                           };
            return PartialView(ThongTin.ToList());
        }
        public double Diem_ReView_CaNhan(int id1,int id2)
        {
            var ThongTin = data.Reviews.Where(x => x.MaTruyen == id1 && x.MaDN == id2).ToList();
            if (ThongTin.Count() != 0)
            {
                double TinhCach = (int)ThongTin.Select(x => x.TinhCachNhanVat).Average();
                double CotTruyen = (int)ThongTin.Select(x => x.CotTruyen).Average();
                double BoCuc = (int)ThongTin.Select(x => x.BoCucTheGioi).Average();
                double KetQua = (TinhCach + CotTruyen + BoCuc) / 60;
                return Math.Round(KetQua, 1);
            }
            else
            {

                double KetQua = 0;
                return Math.Round(KetQua, 1);
            }

        }
        public ActionResult View_ReView_2(int id)
        {
            var ThongTin = data.Reviews.Where(x => x.MaTruyen == id).ToList();
            Review_All abc = new Review_All();
            if (ThongTin.Count() != 0)
            {
                abc.TongDanhGia = ThongTin.Count();
                abc.TinhCanh = (int)ThongTin.Select(x => x.TinhCachNhanVat).Average() / 20;
                abc.BoCuc = (int)ThongTin.Select(x => x.BoCucTheGioi).Average() / 20;
                abc.CotTruyen = (int)ThongTin.Select(x => x.CotTruyen).Average() / 20;
                abc.Diem_Reivew = Diem_ReView(id);

            }
            else
            {
                abc.TongDanhGia = 0;
                abc.TinhCanh = 0;
                abc.BoCuc = 0;
                abc.CotTruyen = 0;
                abc.Diem_Reivew = 0;
            }
            return PartialView(abc);
        }
        public ActionResult DanhSachChuong(int id)
        {
            var ThongTin = from a in data.CHUONGs
                           join b in data.DANGNHAPs on a.MaDN equals b.MaDN
                           where a.MaTruyen == id
                           orderby a.IdChuong descending
                           select new Chuong()
                           {
                               ChuongSo = a.IdChuong,
                               TieuDe = a.TenChuong,
                               NguoiDang = (from a in data.CHUONGs
                                            join b in data.DANGNHAPs on a.MaDN equals b.MaDN
                                            where a.MaTruyen == id
                                            select b.TenDangNhap).FirstOrDefault(),
                               NgayDang = (DateTime)a.NgayDang,
                           };
            return PartialView(ThongTin.ToList());
        }
        public ActionResult BinhLuan(int MaTruyen, int MaUser)
        {
            var ThongTin = from a in data.BinhLuans
                           where a.MaTruyen == MaTruyen
                           orderby a.MaBL descending
                           select new View_Review()
                           {
                               TenNguoiDung = (from b in data.DANGNHAPs
                                               where b.MaDN == MaUser
                                               join c in data.BinhLuans on b.MaDN equals c.MaDN
                                               select b.TenDangNhap).FirstOrDefault(),
                               Avatar = (from b in data.DANGNHAPs
                                         where b.MaDN == MaUser
                                         join c in data.BinhLuans on b.MaDN equals c.MaDN
                                         select b.avatar).FirstOrDefault(),
                               NoiDungBinhLuan = a.NoiDung,
                           };
            return PartialView(ThongTin.ToList());
        }
        public ActionResult BinhLuan_Submid(FormCollection Fields, BinhLuan bl)
        {
            var BinhLuan = Fields["BinhLuan"];
            var User = Fields["User"];
            var MaTruyen = Fields["MaTruyen"];
            if (String.IsNullOrEmpty(User))
            {
                return RedirectToAction("DangNhap", "NguoiDung");
            }
            else if (String.IsNullOrEmpty(BinhLuan)) 
            {
                return RedirectToAction("ChiTietTruyen", new { id = MaTruyen });
            }
            else
            {
                bl.NoiDung = BinhLuan;
                bl.MaTruyen = int.Parse(MaTruyen);
                var MaDN = data.DANGNHAPs.Where(x => x.TenDangNhap == User).ToList();
                bl.MaDN = MaDN.FirstOrDefault().MaDN;
                data.BinhLuans.InsertOnSubmit(bl);
                data.SubmitChanges();
                return RedirectToAction("ChiTietTruyen", new { id = MaTruyen });
            }

        }
        public ActionResult DocTruyen(int MaTruyen,int IdChuong)
        {
            TruyenDangDoc_add(MaTruyen, IdChuong);
            var ThongTin = from a in data.CHUONGs
                           join b in data.TRUYENs on a.MaTruyen equals b.MaTruyen
                           where a.MaTruyen == MaTruyen && a.IdChuong == IdChuong
                           select new DocTruyen()
                           {
                               TenFoder = a.TenFoder,
                               IdChuong = a.IdChuong,
                               TenTruyen = b.TenTruyen,
                               TieuDe = a.TenChuong,
                               MaTruyen = MaTruyen,
                               TongSoChuong = data.CHUONGs.Where(x => x.MaTruyen == MaTruyen).Count()
                           };
           
            return View(ThongTin.FirstOrDefault());
        }
       
        public void TruyenDangDoc_add(int MaTruyen,int IdChuong)
        {
            var kiemtra = data.TruyenDangDocs.Where(x => x.MaTruyen==MaTruyen).FirstOrDefault();
            if (kiemtra == null)
            {
                TruyenDangDoc abc = new TruyenDangDoc();
                abc.MaTruyen = MaTruyen;
                abc.IdChuong = IdChuong;
                data.TruyenDangDocs.InsertOnSubmit(abc);
                data.SubmitChanges();
            }
            else
            {
                kiemtra.IdChuong = IdChuong;
                data.SubmitChanges();
            }    
        }
        public ActionResult TimKiem(FormCollection field)
        {
            var abc = field["TenTruyen"];
            var ThongTin = data.TRUYENs.Where(x => x.TenTruyen.Contains(abc)).FirstOrDefault();
            if (ThongTin == null)
            {
                return RedirectToAction("ThatBai");
            }
            else
            {
                return RedirectToAction("ChiTietTruyen", new { id = ThongTin.MaTruyen });
            }    

        }
        public ActionResult ThatBai()
        {
            return View();
        }
        public ActionResult TheLoai(string MaTL)
        {
            if(string.IsNullOrEmpty(MaTL))
            {

                var thongtin = from a in data.view_theloais
                               select new TheLoai()
                               {
                                   MaTruyen = a.MaTruyen,
                                   TenTruyen = a.TenTruyen,
                                   TacGia = a.TenTG,
                                   TenTL = a.TenTL,
                                   MaTL = a.MaTL,
                                   AnhBia = a.AnhBia,
                                   TenFoder = a.TenFoder,
                                   TongChuong = (int)a.TongChuong
                               };
                return View(thongtin.ToList());

            }
            else
            {
                var thongtin = from a in data.view_theloais
                               where a.MaTL == MaTL
                               select new TheLoai()
                               {
                                   MaTruyen = a.MaTruyen,
                                   TenTruyen = a.TenTruyen,
                                   TacGia = a.TenTG,
                                   TenTL = a.TenTL,
                                   MaTL = a.MaTL,
                                   AnhBia = a.AnhBia,
                                   TenFoder = a.TenFoder,
                                   TongChuong = (int)a.TongChuong
                               };
                return View(thongtin.ToList());

            }
        }
        public ActionResult Category_TheLoai()
        {
            var thongtin = from a in data.THELOAIs
                           select new Category_TheLoai() { TheLoai = a.TenTL ,MaTL=a.MaTL};
            
            return PartialView(thongtin.ToList());
        }
        public ActionResult Category_TheLoai_2()
        {
            var thongtin = from a in data.THELOAIs
                           select new Category_TheLoai() { TheLoai = a.TenTL, MaTL = a.MaTL };

            return PartialView(thongtin.ToList());
        }
       
        //public ActionResult Ajax_category_theloai(string MaTL)
        //{
        //    var thongtin = from a in data.view_theloais
        //                   where a.MaTL == MaTL
        //                   select new TheLoai()
        //                   {
        //                       MaTruyen = a.MaTruyen,
        //                       TenTruyen = a.TenTruyen,
        //                       TacGia = a.TenTG,
        //                       TenTL = a.TenTL,
        //                       MaTL = a.MaTL,
        //                       AnhBia = a.AnhBia,
        //                       TenFoder = a.TenFoder,
        //                       TongChuong = (int)a.TongChuong
        //                   };
        //    return PartialView(thongtin.ToList());
        //}
    }   
}