using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Stats
{
    public interface ISeasonalStat
    {
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        IReadOnlyList<RegionStat> Regions { get; }
    }
}
