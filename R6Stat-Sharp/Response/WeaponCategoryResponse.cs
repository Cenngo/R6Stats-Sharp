using Newtonsoft.Json;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class WeaponCategoryResponse : BaseResponse, IWeaponCategoryResponse
    {
        [JsonProperty("categories")]
        internal List<WeaponCategoryStat> _weaponCategories;
        [JsonIgnore]
        public IReadOnlyList<WeaponCategoryStat> WeaponCategories => _weaponCategories;
    }
}
