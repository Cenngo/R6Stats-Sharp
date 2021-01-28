namespace R6Stat_Sharp.Stats
{
    public interface IGenericStat : IGameStat
    {
        int GamesPlayed { get; }
        int Deaths { get; }
        int Draws { get; }
        double KD { get; }
        int Kills { get; }
    }
}
