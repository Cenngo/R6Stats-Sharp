using R6Stat_Sharp.Models;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response.Interfaces
{
    public interface IGenericResponse
    {
        IReadOnlyList<Alias> Aliases { get; }
        PlayerProgression PlayerProgression { get; }
        GenericResponseStats Stats { get; }
        TimeStamps TimeStamps { get; }
    }
}
