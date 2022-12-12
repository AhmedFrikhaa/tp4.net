using Microsoft.EntityFrameworkCore;
using Tp4.Models;

namespace Tp4.Data
{
    public class UniversityContext : DbContext
    {
        private static UniversityContext context = null;
        private UniversityContext(DbContextOptions o) : base(o) {
        
        }

        public static UniversityContext Instantiate_UniversityContext(IConfiguration configuration)
        {
            if (context==null) {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite(configuration.GetConnectionString("sqlite"));
                context= new UniversityContext(optionsBuilder.Options);
                return context;
            }
            return context;
          

        }
         public DbSet<Student> dbStudent {get; set; }

    }
}
