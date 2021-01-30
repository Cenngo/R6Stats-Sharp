using Newtonsoft.Json;
using R6Stats.Response.Interfaces;
using R6Stats.Stats;
using System.Collections.Generic;

namespace R6Stats.Response
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
