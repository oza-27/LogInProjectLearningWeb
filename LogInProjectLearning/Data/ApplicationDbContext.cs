using LogInProjectLearning.Models;
using Microsoft.EntityFrameworkCore;

namespace LogInProjectLearning.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Login> getlogin { get; set; }
    }
}
