using Newtonsoft.Json;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class SeasonalResponse : BaseResponse, ISeasonalResponse
    {
        [JsonProperty("seasons")]
        internal Dictionary<string, SeasonalStat> _seasonalStats;
        [JsonIgnore]
        public IReadOnlyDictionary<string, SeasonalStat> SeasonalStats => _seasonalStats;
    }
}
