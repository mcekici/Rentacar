using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class RentacarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.;Database=Rentacar;User Id=sa;Password=1");
            optionsBuilder.UseSqlServer(@"Server=tcp:myserver42.database.windows.net,1433;Database=Rentacar;User ID=user;Password=eng.4227;Trusted_Connection=False;Encrypt=True;");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
