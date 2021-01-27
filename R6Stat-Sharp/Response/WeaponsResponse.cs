using Newtonsoft.Json;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class WeaponsResponse : BaseResponse, IWeaponResponse
    {
        [JsonProperty("weapons")]
        internal List<WeaponStat> _weapons;
        [JsonIgnore]
        public IReadOnlyList<WeaponStat> Weapons => _weapons;
    }
}
