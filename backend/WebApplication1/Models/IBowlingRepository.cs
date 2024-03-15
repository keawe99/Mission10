namespace WebApplication1.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        Team GetTeamById(int? teamID);
    }
}
