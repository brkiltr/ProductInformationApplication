using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karacaMarsTech.Models.Siniflar;

namespace karacaMarsTech.Controllers
{
    public class HomeController : Controller
    {
        DbBaglanti VeriAl = new DbBaglanti();

        public ActionResult Index(int id)
        {

            var Kategori = (from DbKategori in VeriAl.Kategoris
                            where DbKategori.KategoriAktifMi == true
                            select new Sayfa
                            {
                                KategoriSirasi = DbKategori.KategoriSirasi,
                                KategoriID = DbKategori.KategoriID,
                                KategoriAdi = DbKategori.KategoriAdi,
                                KategoriGorseli = DbKategori.KategoriGorseli,
                                KategoriAktifMi = DbKategori.KategoriAktifMi,


                            }
                            ).OrderBy(x => x.KategoriSirasi).ToList();

            if(id == 6)
            {
                var Urunler = (from DbUrunler in VeriAl.Urunlers
                               join DbKategori in VeriAl.Kategoris on DbUrunler.KategoriRefID equals DbKategori.KategoriID
                               where DbUrunler.UrunAktifMi == true && DbKategori.KategoriAktifMi == true
                               select new Sayfa
                               {
                                   UrunID = DbUrunler.UrunID,
                                   UrunGorseli = DbUrunler.UrunGorseli,
                                   UrunAdi = DbUrunler.UrunAdi,
                                   UrunSirasi = DbUrunler.UrunSirasi,

                               }).OrderBy(x => x.UrunSirasi).ToList();

                ViewBag.Urunler = Urunler;
            }
            else
            {
                var Urunler = (from DbUrunler in VeriAl.Urunlers
                               join DbKategori in VeriAl.Kategoris on DbUrunler.KategoriRefID equals DbKategori.KategoriID
                               where DbUrunler.UrunAktifMi == true && DbKategori.KategoriAktifMi == true && DbUrunler.KategoriRefID == id
                               select new Sayfa
                               {
                                   UrunID = DbUrunler.UrunID,
                                   UrunGorseli = DbUrunler.UrunGorseli,
                                   UrunAdi = DbUrunler.UrunAdi,
                                   UrunSirasi = DbUrunler.UrunSirasi,

                               }).OrderBy(x => x.UrunSirasi).ToList();

                ViewBag.Urunler = Urunler;
            }

            ViewBag.Kategori = Kategori;


            return View();
        }

        
        



    }

  
}