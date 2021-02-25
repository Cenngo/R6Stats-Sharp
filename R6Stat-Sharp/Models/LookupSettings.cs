using R6Stats.Enums;
using R6Stats.Response.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Models
{
    public class LookupSettings
    {
        public Platform PreferPlatform { get; set; } = Platform.PC;
        public Func<int, bool> ClearanceLevel = x => x > 0;
        public bool SortRankAscending = true;
        public bool SortLevelAscending = true;
        public LookupSettings ( ) { }
    }
}
