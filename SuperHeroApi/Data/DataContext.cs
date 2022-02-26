using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Models;

namespace SuperHeroApi.Data
{
    public class DataContext : DbContext
    {
        //Step 2
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        //Step 3 SuperHeroes is the name of tabe in database
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
    
}
