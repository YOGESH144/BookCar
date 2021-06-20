using Microsoft.EntityFrameworkCore;

namespace BookCar.Data
{
    public class BookCarContext : DbContext
    {
        public BookCarContext (DbContextOptions<BookCarContext> options)
            : base(options)
        {
        }

        public DbSet<BookCar.Models.Car> Car { get; set; }

        public DbSet<BookCar.Models.BookingCars> BookingCars { get; set; }

        public DbSet<BookCar.Models.ContactUs> ContactUs { get; set; }
    }
}
