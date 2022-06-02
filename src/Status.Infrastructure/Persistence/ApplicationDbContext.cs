using Microsoft.EntityFrameworkCore;
using Status.Domain.Entities;

namespace Status.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Role> Roles => Set<Role>();

        public DbSet<User> Users => Set<User>();

        public DbSet<Flight> Flights => Set<Flight>();
    }
}
