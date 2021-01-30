using System;

namespace R6Stats.Stats.Interfaces
{
    public interface IGameStat
    {
        int Losses { get; }
        TimeSpan PlayTime { get; }
        int Wins { get; }
        double WinLose { get; }
    }
}
