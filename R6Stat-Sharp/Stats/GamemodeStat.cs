using Newtonsoft.Json;
using System;

namespace R6Stat_Sharp.Stats
{
    public class GamemodeStat : IGamemodeStat
    {
        [JsonProperty("best_score")]
        public int BestScore { get; internal set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; internal set; }

        [JsonProperty("losses")]
        public int Losses { get; internal set; }

        [JsonProperty("playtime")]
        public long _playTime;
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("wins")]
        public int Wins { get; internal set; }

        [JsonProperty("wl")]
        public double WinLose { get; internal set; }
    }
}
