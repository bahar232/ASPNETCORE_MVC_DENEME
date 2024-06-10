using Microsoft.EntityFrameworkCore;

namespace QUANTUMWEB.Models
{
    public class WebDbContext : DbContext
    {
         public WebDbContext(DbContextOptions options ) : base(options)
        {

        }
        public DbSet<Login> Bayiler { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }
       
    }
   


}

