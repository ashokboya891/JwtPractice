using JwtWebApiTutorial.Models;
using Microsoft.EntityFrameworkCore;
namespace JwtWebApiTutorial.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Citiy> CityTbl { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Citiy>().HasData(
           new Citiy()
           {
               CityId = Guid.Parse("88D06F3E-A035-4CF2-9EBF-35114E27376F"),
               CityName = "KNl"
           },
             new Citiy()
             {
                 CityId = Guid.Parse("EB053846-2C65-430E-9526-2747D41F50B8"),
                 CityName = "knl",

             }
           );
        }
    }
}
