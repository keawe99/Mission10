namespace WebApplication1.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
