using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace karacaMarsTech.Models.Siniflar
{
    public class Mensei
    {
        [Key]
        public int MenseiID { get; set; }
        [MaxLength(25)]
        public string MenseiAdi { get; set; }

        public ICollection<Urunler> Urunlers { get; set; }
    }
}