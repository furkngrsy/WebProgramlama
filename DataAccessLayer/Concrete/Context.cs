using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9CA49S5;database=CoreTakviyeDb; integrated security=true;");
        }
        public DbSet<Hakkinda> Hakkindas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Takviyeler> Takviyelers { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }



    }
}
