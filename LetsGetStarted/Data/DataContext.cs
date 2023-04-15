using LetsGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsGetStarted.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}