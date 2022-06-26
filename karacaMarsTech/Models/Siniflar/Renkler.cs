using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace karacaMarsTech.Models.Siniflar
{
    public class Renkler
    {
        [Key]
        public int RenkID { get; set; }
        [MaxLength(25)]
        public string RenkAdi { get; set; }

        public ICollection<Urunler> Urunlers { get; set; }
    }
}