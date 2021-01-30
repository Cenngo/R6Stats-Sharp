namespace R6Stats.Stats.Interfaces
{
    public interface IRankedData
    {
        int MaxMMR { get; }
        int MaxRank { get; }
        string MaxRankText { get; }
        string MaxRankImg { get; }
        int MMR { get; }
        int Rank { get; }
        string RankText { get; }
        string RankImg { get; }
        int NextRankMMR { get; }
        int PrevRankMMR { get; }
    }
}
