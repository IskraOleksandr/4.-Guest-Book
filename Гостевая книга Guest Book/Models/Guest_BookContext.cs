using Microsoft.EntityFrameworkCore;

namespace Гостевая_книга_Guest_Book.Models
{
    public class Guest_BookContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public Guest_BookContext(DbContextOptions<Guest_BookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
