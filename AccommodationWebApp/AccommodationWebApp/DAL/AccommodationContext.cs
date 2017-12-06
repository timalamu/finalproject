using AccommodationWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AccommodationWebApp.DAL
{
    public class AccommodationContext : DbContext
    {

        public AccommodationContext() : base("AccommodationContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}