using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SchanppsDbContext : DbContext
    {
        public SchanppsDbContext(DbContextOptions<SchanppsDbContext> options) : base(options)
        {
            
        }
    }
}
