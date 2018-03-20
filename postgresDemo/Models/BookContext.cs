using Microsoft.EntityFrameworkCore;
 
namespace entityDemo.Models
{
    public class BookContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}