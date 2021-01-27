using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Stats
{
    public interface IPlayerStat
    {
        int Kills { get; }
        int Deaths { get; }
        double KD { get; }
        int Wins { get; }
        int Losses { get; }
        double WinLose { get; }
    }
}
