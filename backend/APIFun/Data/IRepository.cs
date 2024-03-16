namespace APIFun.Data
{
    public interface IRepository
    {
        //Data that we can loop through
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
