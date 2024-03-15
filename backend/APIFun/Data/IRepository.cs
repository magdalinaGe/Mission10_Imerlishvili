namespace APIFun.Data
{
    public interface IRepository
    {
        //Data that we can loop through
        IEnumerable<Bowlers> Bowlers { get; }   
    }
}
