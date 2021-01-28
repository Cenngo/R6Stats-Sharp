using Newtonsoft.Json;
using R6Stat_Sharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R6Stat_Sharp.Stats
{
    public class OperatorStat : IGameStat, IPlayerStat
    {
        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("ctu")]
        public string CTU { get; internal set; }

        [JsonProperty("role")]
        internal string _role;

        [JsonIgnore]
        public OperatorType Role => Enum.Parse<OperatorType>(_role, true);

        [JsonProperty("kills")]
        public int Kills { get; internal set; }

        [JsonProperty("deaths")]
        public int Deaths { get; internal set; }

        [JsonProperty("kd")]
        public double KD { get; internal set; }

        [JsonProperty("wins")]
        public int Wins { get; internal set; }

        [JsonProperty("losses")]
        public int Losses { get; internal set; }

        [JsonProperty("wl")]
        public double WinLose { get; internal set; }

        [JsonProperty("headshots")]
        public int HeadShots { get; internal set; }

        [JsonProperty("dbnos")]
        public int DBNOs { get; internal set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; internal set; }

        [JsonProperty("experience")]
        public int Experience { get; internal set; }

        [JsonProperty("playtime")]
        internal long _playTime;

        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("abilities")]
        internal List<OperatorAbility> _operatorAbilities;

        [JsonIgnore]
        public IReadOnlyDictionary<string, int> OperatorAbilities => _operatorAbilities.ToDictionary(x => x.Ability, x => x.Value);

        [JsonProperty("badge_image")]
        public string BadgeImg { get; internal set; }
    }

    internal class OperatorAbility
    {
        [JsonProperty("ability")]
        public string Ability { get; internal set; }

        [JsonProperty("value")]
        public int Value { get; internal set; }
    }
}
