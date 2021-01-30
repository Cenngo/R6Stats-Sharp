using Newtonsoft.Json;
using R6Stats.Stats.Interfaces;
using System;

namespace R6Stats.Stats
{
    public class GamemodeStat : IGamemodeStat
    {
        [JsonProperty("best_score")]
        public int BestScore { get; private set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("playtime")]
        public long _playTime;
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("wl")]
        public double WinLose { get; private set; }
    }
}
