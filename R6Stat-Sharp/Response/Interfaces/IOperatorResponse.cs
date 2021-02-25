using R6Stats.Stats;
using System.Collections.Generic;

namespace R6Stats.Response.Interfaces
{
    /// <summary>
    /// API response containing the operator stats of a player
    /// </summary>
    public interface IOperatorResponse : IStat
    {
        /// <summary>
        /// Collection for the stats of the operators played by the user
        /// </summary>
        IReadOnlyDictionary<string, OperatorStat> Operators { get; }
    }
}
