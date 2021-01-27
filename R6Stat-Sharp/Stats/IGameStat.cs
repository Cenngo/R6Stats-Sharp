using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Stats
{
    public interface IGameStat
    {
        int Losses { get; }
        TimeSpan PlayTime { get; }
        int Wins { get; }
        double WinLose { get; }
    }
}
