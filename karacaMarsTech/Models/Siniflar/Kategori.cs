using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace karacaMarsTech.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [MaxLength(50)]
        public string KategoriAdi { get; set; }
        public string KategoriGorseli { get; set; }
        public bool KategoriAktifMi { get; set; }
        public int KategoriSirasi { get; set; }

        public ICollection<Urunler> Urunlers { get; set; }
    }
}