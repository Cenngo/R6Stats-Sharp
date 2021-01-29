using Newtonsoft.Json;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// Contains weapon stats of a player
    /// </summary>
    public class WeaponsResponse : BaseResponse, IWeaponResponse
    {
        [JsonProperty("weapons")]
        private List<WeaponStat> _weapons;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<WeaponStat> Weapons => _weapons;
    }
}
