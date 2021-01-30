namespace R6Stats.Stats.Interfaces
{
    public interface IGamemodeStat : IGameStat
    {
        int GamesPlayed { get; }
        int BestScore { get; }
    }
}
