using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response.Interfaces;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Newtonsoft.Json;
using System.Collections;
using System.Linq;

namespace R6Stat_Sharp.Response
{
    /// <summary>
    /// A read-only <see cref="IEnumerable"/> which contains the contents of a leaderboard starting from the first place
    /// </summary>
    public sealed class Leaderboard : IReadOnlyList<LeaderboardSlot>, IReadOnlyCollection<LeaderboardSlot>, IEnumerable<LeaderboardSlot>, IPayload
    {
        private List<LeaderboardSlot> _leaderboard;

        public Leaderboard ( )
        {
            _leaderboard = new List<LeaderboardSlot>();
        }

        public Leaderboard( IEnumerable<LeaderboardSlot> leaderboard )
        {
            _leaderboard = leaderboard.ToList();
        }

        public LeaderboardSlot this[int index] => _leaderboard[index];

        public int Count => _leaderboard.Count;

        public IEnumerator<LeaderboardSlot> GetEnumerator ( ) => _leaderboard.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator ( ) => this.GetEnumerator();
    }
}
