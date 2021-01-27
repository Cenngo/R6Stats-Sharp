using Newtonsoft.Json;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class OperatorResponse : BaseResponse, IOperatorResponse
    {
        [JsonProperty("operators")]
        internal List<OperatorStat> _operators;
        public IReadOnlyList<OperatorStat> Operators => _operators;
    }
}
