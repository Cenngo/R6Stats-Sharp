using Newtonsoft.Json;
using R6Stat_Sharp.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Stats
{
    public class WeaponStat : WeaponCategoryStat
    {
        [JsonProperty("weapon")]
        public string Weapon { get; internal set; }
    }
}
