using System;
using System.Collections.Generic;

namespace R6Stats.Stats.Interfaces
{
    public interface ISeasonalStat
    {
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        IReadOnlyList<RegionStat> Regions { get; }
    }
}
