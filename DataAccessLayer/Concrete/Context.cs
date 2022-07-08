using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=AB01500-5000; database=AdliyeProjectDB; integrated security=true");
        }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Unvan> Unvans { get; set; }
        public DbSet<Birim> Birims { get; set; }
        
    }
}
