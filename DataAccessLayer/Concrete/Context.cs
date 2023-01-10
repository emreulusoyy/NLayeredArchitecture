using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0A6CNA1;initial catalog=DbVeriCevre; integrated security=true");
        }

        public DbSet<AltSlider> AltSliders { get; set; }
        public DbSet<Belgeler> Belgelers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkında> Hakkındas { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Slider> Sliders { get; set; }

    }
}
