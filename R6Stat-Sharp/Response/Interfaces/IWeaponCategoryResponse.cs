using R6Stats.Stats;
using System.Collections.Generic;

namespace R6Stats.Response.Interfaces
{
    /// <summary>
    /// API response containing stats for each weapon category
    /// </summary>
    public interface IWeaponCategoryResponse : IStat
    {
        /// <summary>
        /// Stats for every weapon category
        /// </summary>
        public IReadOnlyList<WeaponCategoryStat> WeaponCategories { get; }
    }
}
