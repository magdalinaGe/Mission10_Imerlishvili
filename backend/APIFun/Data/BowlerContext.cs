using Microsoft.EntityFrameworkCore;

namespace APIFun.Data
{
    public class BowlerContext : DbContext
    {
      public BowlerContext()
      {

      }
        public BowlerContext(DbContextOptions<BowlerContext>options) : base(options) { }
        
          public virtual DbSet<Bowler> Bowlers{  get; set; }
        public virtual DbSet<Team> Teams {  get; set; }
      
    }
}
