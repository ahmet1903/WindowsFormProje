using KatmanlıMimariDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanlıMimariDataAccess.Context
{
    public class MagazaYonetimiDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public MagazaYonetimiDbContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-Q6EIPDG; database=MagazaYonetimi; Trusted_Connection=True";
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
    }
}
