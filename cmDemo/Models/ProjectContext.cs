using Microsoft.EntityFrameworkCore;

namespace cmDemo.Models
{
    public class CmDemoContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public CmDemoContext(DbContextOptions<CmDemoContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Demo> Demos { get; set; }
    }
}
