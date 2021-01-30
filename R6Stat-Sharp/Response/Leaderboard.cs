using Newtonsoft.Json;
using R6Stats.Response.Interfaces;
using R6Stats.Stats;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace R6Stats.Response
{
    /// <summary>
    /// A read-only <see cref="IEnumerable"/> which contains the contents of a leaderboard starting from the first place
    /// </summary>
    public sealed class Leaderboard : IReadOnlyList<LeaderboardSlot>, IReadOnlyCollection<LeaderboardSlot>, IEnumerable<LeaderboardSlot>, IPayload
    {
        private List<LeaderboardSlot> _leaderboard;

        internal Leaderboard ( )
        {
            _leaderboard = new List<LeaderboardSlot>();
        }

        [JsonConstructor]
        internal Leaderboard ( IEnumerable<LeaderboardSlot> leaderboard )
        {
            _leaderboard = leaderboard.ToList();
        }

        public LeaderboardSlot this[int index] => _leaderboard[index];

        public int Count => _leaderboard.Count;

        public IEnumerator<LeaderboardSlot> GetEnumerator ( ) => _leaderboard.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator ( ) => this.GetEnumerator();
    }
}
