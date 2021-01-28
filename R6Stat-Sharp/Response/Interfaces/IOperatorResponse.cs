using R6Stat_Sharp.Models;
using R6Stat_Sharp.Stats;
using System.Collections.Generic;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// API response containing the operator stats of a player
    /// </summary>
    public interface IOperatorResponse : IResponse
    {
        /// <summary>
        /// Collection for the stats of the operators played by the user
        /// </summary>
        IReadOnlyList<OperatorStat> Operators { get; }
    }
}
