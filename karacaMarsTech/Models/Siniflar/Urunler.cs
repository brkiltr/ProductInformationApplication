using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace karacaMarsTech.Models.Siniflar
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        [MaxLength(100)]
        public string UrunGorseli { get; set; }
        [MaxLength(100)]
        public string UrunVideosu { get; set; }
        [MaxLength(150)]
        public string UrunAdi { get; set; }
        [MaxLength(2000)]
        public string UrunAciklamasi { get; set; }
        [MaxLength(50)]
        public string UrunMarkasi { get; set; }
        [MaxLength(50)]
        public string UrunModelNo { get; set; }
        [MaxLength(50)]
        public string UrunBarkod { get; set; }
        public bool UrunAktifMi { get; set; }
        public int UrunSirasi { get; set; }

        [ForeignKey("Kategori")]
        public int KategoriRefID { get; set; }
        public Kategori Kategori { get; set; }

        [ForeignKey("Renkler")]
        public int RenkRefID { get; set; }
        public Renkler Renkler { get; set; }

        [ForeignKey("MalzemeTuru")]
        public int MalzemeTuruRefID { get; set; }
        public MalzemeTuru MalzemeTuru { get; set; }

        [ForeignKey("Mensei")]
        public int MenseiRefID { get; set; }
        public Mensei Mensei { get; set; }



    }
}