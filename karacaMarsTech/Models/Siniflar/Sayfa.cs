using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karacaMarsTech.Models.Siniflar
{
    public class Sayfa
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunGorseli { get; set; }
        public string UrunVideosu { get; set; }
        public string UrunAciklamasi { get; set; }
        public string UrunMarkasi { get; set; }
        public string UrunModelNo { get; set; }
        public string UrunBarkod { get; set; }
        public string UrunRenk { get; set; }
        public string UrunMalzemeTuru { get; set; }
        public string UrunGrubu { get; set; }
        public string UrunMensei { get; set; }
        public bool UrunAktifMi { get; set; }
        public int UrunSirasi { get; set; }

        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriGorseli { get; set; }
        public bool KategoriAktifMi { get; set; }
        public int KategoriSirasi { get; set; }

        internal static int Count()
        {
            throw new NotImplementedException();
        }
    }
}