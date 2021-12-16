using Core.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Models
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
    }
}
