using Microsoft.EntityFrameworkCore;

namespace SignalR_Project.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
