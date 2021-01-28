using System;
using System.Collections.Generic;

namespace R6Stat_Sharp.Stats
{
    public interface ISeasonalStat
    {
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        IReadOnlyList<RegionStat> Regions { get; }
    }
}
