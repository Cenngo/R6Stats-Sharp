using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public interface ISeasonalResponse
    {
        public IReadOnlyDictionary<string, SeasonalStat> SeasonalStats { get; }
    }
}
