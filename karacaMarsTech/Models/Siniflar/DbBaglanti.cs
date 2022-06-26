using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace karacaMarsTech.Models.Siniflar
{
    public class DbBaglanti:DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<MalzemeTuru> MalzemeTurus { get; set; }
        public DbSet<Mensei> Menseis { get; set; }
        public DbSet<Renkler> Renklers { get; set; }
        
    } 
}