using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response.Interfaces;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class Leaderboard : List<LeaderboardSlot>, IReadOnlyList<LeaderboardSlot>, IEnumerable<LeaderboardSlot>, IPayload
    {
        public Leaderboard ( ) { }
        public Leaderboard(IEnumerable<LeaderboardSlot> leaderboard) : base(leaderboard)
        {

        }
    }
}
