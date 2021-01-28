using R6Stat_Sharp.Models;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// API response containing stats for each weapon category
    /// </summary>
    public interface IWeaponCategoryResponse : IResponse
    {
        /// <summary>
        /// Stats for every weapon category
        /// </summary>
        public IReadOnlyList<WeaponCategoryStat> WeaponCategories { get; }
    }
}
