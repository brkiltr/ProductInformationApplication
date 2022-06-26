using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karacaMarsTech.Models.Siniflar;


namespace karacaMarsTech.Controllers
{
    public class UrunController : Controller
    {
        DbBaglanti VeriAl = new DbBaglanti();
        // GET: Urun
        public ActionResult Index(int id)
        {
            //ViewBag.UrunDetay = VeriAl.Urunlers.Where(x => x.UrunID == id).ToList();
           
            var UrunBilgileri = (from DbUrunler in VeriAl.Urunlers
                                join DbKategori in VeriAl.Kategoris on DbUrunler.KategoriRefID equals DbKategori.KategoriID
                                join DbRenk in VeriAl.Renklers on DbUrunler.RenkRefID equals DbRenk.RenkID
                                join DbMalzeme in VeriAl.MalzemeTurus on DbUrunler.MalzemeTuruRefID equals DbMalzeme.MalzemeTuruID
                                join DbMensei in VeriAl.Menseis on DbUrunler.MenseiRefID equals DbMensei.MenseiID
                                where(DbUrunler.UrunSirasi == id && DbUrunler.UrunAktifMi == true && DbKategori.KategoriAktifMi == true)
                                select new Sayfa
                                {
                                    UrunID = DbUrunler.UrunID,
                                    UrunAdi = DbUrunler.UrunAdi,
                                    UrunGorseli = DbUrunler.UrunGorseli,
                                    UrunVideosu = DbUrunler.UrunVideosu,
                                    UrunAciklamasi = DbUrunler.UrunAciklamasi,
                                    UrunMarkasi = DbUrunler.UrunMarkasi,
                                    UrunModelNo = DbUrunler.UrunModelNo,
                                    UrunBarkod = DbUrunler.UrunBarkod,
                                    UrunRenk = DbRenk.RenkAdi,
                                    UrunMalzemeTuru = DbMalzeme.MalzemeTuruAdi,
                                    UrunGrubu = DbKategori.KategoriAdi,
                                    UrunMensei = DbMensei.MenseiAdi,
                                    UrunAktifMi = DbUrunler.UrunAktifMi,
                                    UrunSirasi = DbUrunler.UrunSirasi,




                                }).ToList();

            ViewBag.UrunDetay = UrunBilgileri;

            if(UrunBilgileri.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
               
            
            
            
        }
    }
    
}