using R6Stat_Sharp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Models
{
    public interface IResponse
    {
        string Username { get; }
        Platform Platform { get; }
        string UbisoftID { get; }
        string UplayID { get; }
        string Avatar146 { get; }
        string Avatar256 { get; }
        DateTime LastUpdated { get; }
    }
}
