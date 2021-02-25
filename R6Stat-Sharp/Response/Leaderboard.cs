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
        private readonly List<LeaderboardSlot> _leaderboard;

        internal Leaderboard ( )
        {
            _leaderboard = new List<LeaderboardSlot>();
        }

        [JsonConstructor]
        internal Leaderboard ( IEnumerable<LeaderboardSlot> leaderboard )
        {
            _leaderboard = leaderboard.ToList();
        }

        /// <summary>
        /// Get user info for a leaderboard index
        /// </summary>
        /// <param name="index">An index starting from 0</param>
        /// <returns>User info for the user in the specified index</returns>
        public LeaderboardSlot this[int index] => _leaderboard[index];

        /// <summary>
        /// Get user info for a username from a leaderboard
        /// </summary>
        /// <param name="username">Username to be parsed</param>
        /// <returns>User info for the specified username, if not found returns the <see langword="null"/>/></returns>
        public LeaderboardSlot this[string username] { get
            {
                if (TryGetPlayer(username, out var leaderboardSlot))
                    return leaderboardSlot;
                else
                    return null;
            } }

        /// <summary>
        /// Count of players in the learderboard (should always be 100)
        /// </summary>
        public int Count => _leaderboard.Count;

        /// <summary>
        /// Get the top 10 player of the leaderboard
        /// </summary>
        public IEnumerable<LeaderboardSlot> Top10 => _leaderboard.GetRange(0, 10);

        public bool TryGetPlayer(string username, out LeaderboardSlot player )
        {
            player = _leaderboard.Find(x => string.Equals(x.Username, username, System.StringComparison.OrdinalIgnoreCase));
            if (player != default)
                return true;
            else
                return false;

        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public IEnumerator<LeaderboardSlot> GetEnumerator ( ) => _leaderboard.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator ( ) => this.GetEnumerator();
    }
}
