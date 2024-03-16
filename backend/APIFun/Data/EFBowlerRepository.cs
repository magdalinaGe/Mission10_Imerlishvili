using Microsoft.EntityFrameworkCore;

namespace APIFun.Data
{
    public class EFBowlerRepository : IRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        { 
            _bowlerContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;


        public IEnumerable<Team> Teams => _bowlerContext.Teams;
    }
}
