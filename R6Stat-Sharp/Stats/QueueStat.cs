using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Stats
{
    public class QueueStat : IGenericStat
    {
        [JsonProperty("deaths")]
        public int Deaths { get; internal set; }

        [JsonProperty("draws")]
        public int Draws { get; internal set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; internal set; }

        [JsonProperty("kd")]
        public double KD { get; internal set; }

        [JsonProperty("kills")]
        public int Kills { get; internal set; }

        [JsonProperty("losses")]
        public int Losses { get; internal set; }

        [JsonProperty("playtime")]
        internal int _playTime;

        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("wins")]
        public int Wins { get; internal set; }

        [JsonProperty("wl")]
        public double WinLose { get; internal set; }
    }
}
