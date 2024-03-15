namespace APIFun.Data
{
    public class EFBowlerRepository : IRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        { 
            _bowlerContext = temp;
        }
        public IEnumerable<Bowlers> Bowlers => _bowlerContext.Bowlers;
    }
}
