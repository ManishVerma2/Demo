using Microsoft.EntityFrameworkCore;

namespace Demotostart.Models
{
    public class ApplicationDbContex:DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options):base(options)
        {
            
        }
        public DbSet<Country> Countries { get; set; }
        
    }
}
