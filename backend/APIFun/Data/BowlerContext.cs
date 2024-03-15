using Microsoft.EntityFrameworkCore;

namespace APIFun.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext>options) : base(options) { }
        
          public DbSet<Bowlers> Bowlers {  get; set; }
      
    }
}
