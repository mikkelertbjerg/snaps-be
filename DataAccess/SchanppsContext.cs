using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SchanppsContext : DbContext
    {
        public SchanppsContext(DbContextOptions<SchanppsContext> options) : base(options)
        {
            
        }
        
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MeassurementSystem> MeassurementSystems { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Schnapps> Schnapps { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
