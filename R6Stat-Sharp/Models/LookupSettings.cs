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
        public Func<IGenericResponse, bool> SearchCriteria;
        public string[] LookForAliases { get; set; }
        public LookupSettings ( ) { }
    }
}
