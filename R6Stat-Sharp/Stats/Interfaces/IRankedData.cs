using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Stats
{
    public interface IRankedData
    {
        int MaxMMR { get; }
        int MaxRank { get; }
        int MMR { get; }
        int Rank { get; }
        string RankText { get; }
        string RankImg { get; }
        int NextRankMMR { get; }
        int PrevRankMMR { get; }
    }
}
