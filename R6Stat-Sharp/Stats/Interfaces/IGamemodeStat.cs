namespace R6Stat_Sharp.Stats
{
    public interface IGamemodeStat : IGameStat
    {
        int GamesPlayed { get; }
        int BestScore { get; }
    }
}
