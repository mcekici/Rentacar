using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class RentacarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.;Database=Rentacar;User Id=sa;Password=1");
            optionsBuilder.UseSqlServer(@"Server=tcp:myserver42.database.windows.net,1433;Database=Rentacar;User ID=user;Password=eng.4227;Trusted_Connection=False;Encrypt=True;");
        }


        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<CarProperty> CarProperties { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes  { get; set; }
        public DbSet<Rental> Rentals  { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Serial> Series  { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
