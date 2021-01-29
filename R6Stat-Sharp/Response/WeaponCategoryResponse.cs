using Newtonsoft.Json;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// Contains stats for different weapon categories
    /// </summary>
    public class WeaponCategoryResponse : BaseResponse, IWeaponCategoryResponse
    {
        [JsonProperty("categories")]
        private List<WeaponCategoryStat> _weaponCategories;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<WeaponCategoryStat> WeaponCategories => _weaponCategories;
    }
}
