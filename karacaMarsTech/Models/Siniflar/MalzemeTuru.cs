using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace karacaMarsTech.Models.Siniflar
{
    public class MalzemeTuru
    {
        [Key]
        public int MalzemeTuruID { get; set; }
        [MaxLength(50)]
        public string MalzemeTuruAdi { get; set; }

        public ICollection<Urunler> Urunlers { get; set; }
    }
}