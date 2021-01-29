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
        public string Name { get; private set; }

        [JsonProperty("ctu")]
        public string CTU { get; private set; }

        [JsonProperty("role")]
        private string _role;

        [JsonIgnore]
        public OperatorType Role => Enum.Parse<OperatorType>(_role, true);

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("kd")]
        public double KD { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("wl")]
        public double WinLose { get; private set; }

        [JsonProperty("headshots")]
        public int HeadShots { get; private set; }

        [JsonProperty("dbnos")]
        public int DBNOs { get; private set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; private set; }

        [JsonProperty("experience")]
        public int Experience { get; private set; }

        [JsonProperty("playtime")]
        private long _playTime;

        [JsonIgnore]
        public TimeSpan PlayTime => TimeSpan.FromSeconds(_playTime);

        [JsonProperty("abilities")]
        private List<OperatorAbility> _operatorAbilities;

        [JsonIgnore]
        public IReadOnlyDictionary<string, int> OperatorAbilities => _operatorAbilities.ToDictionary(x => x.Ability, x => x.Value);

        [JsonProperty("badge_image")]
        public string BadgeImg { get; private set; }
    }

    internal class OperatorAbility
    {
        [JsonProperty("ability")]
        public string Ability { get; private set; }

        [JsonProperty("value")]
        public int Value { get; private set; }
    }
}
