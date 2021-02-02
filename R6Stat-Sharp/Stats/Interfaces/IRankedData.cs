namespace R6Stats.Stats.Interfaces
{
    /// <summary>
    /// Represents a players ranked data
    /// </summary>
    public interface IRankedData
    {
        /// <summary>
        /// Max MMR achieved by the player
        /// </summary>
        int MaxMMR { get; }

        /// <summary>
        /// Max rank achieved by the player
        /// </summary>
        int MaxRank { get; }

        /// <summary>
        /// Text representation of the <see cref="IRankedData.MaxRank"/>
        /// </summary>
        string MaxRankText { get; }

        /// <summary>
        /// Badge for the <see cref="IRankedData.MaxRank"/>
        /// </summary>
        string MaxRankImg { get; }

        /// <summary>
        /// Current MMR of the player
        /// </summary>
        int MMR { get; }

        /// <summary>
        /// Current rank of the player
        /// </summary>
        int Rank { get; }

        /// <summary>
        /// Text representation of the <see cref="IRankedData.Rank"/>
        /// </summary>
        string RankText { get; }

        /// <summary>
        /// Badge for the <see cref="IRankedData.Rank"/>
        /// </summary>
        string RankImg { get; }

        /// <summary>
        /// Minimum MMR required to achieve the next rank
        /// </summary>
        int NextRankMMR { get; }

        /// <summary>
        /// Maximum MMR value of the previous rank
        /// </summary>
        int PrevRankMMR { get; }
    }
}
