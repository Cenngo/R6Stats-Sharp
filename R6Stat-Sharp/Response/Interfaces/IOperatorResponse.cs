using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public interface IOperatorResponse
    {
        IReadOnlyList<OperatorStat> Operators { get; }
    }
}
