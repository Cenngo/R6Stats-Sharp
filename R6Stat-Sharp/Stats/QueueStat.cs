using Newtonsoft.Json;
using R6Stats.Stats.Interfaces;
using System;

namespace R6Stats.Stats
{
    public class QueueStat : IGenericStat
    {
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("draws")]
        public int Draws { get; private set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; private set; }

        [JsonProperty("kd")]
        public double KD { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("playtime")]
        private int _playTime;

        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("wl")]
        public double WinLose { get; private set; }
    }
}
