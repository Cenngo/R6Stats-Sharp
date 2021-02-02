using Newtonsoft.Json;

namespace R6Stats.Stats
{
    /// <summary>
    /// Game stats for game mode "Secure Area"
    /// </summary>
    public class SecureAreaStats : GamemodeStat
    {
        /// <summary>
        /// Number of attackers killed in objective
        /// </summary>
        [JsonProperty("kills_as_attacker_in_objective")]
        public int KillsAsAttackerInObj { get; private set; }

        /// <summary>
        /// Number of defenders killed in objective
        /// </summary>
        [JsonProperty("kills_as_defender_in_objective")]
        public int KillsAsDeffenderInObj { get; private set; }

        /// <summary>
        /// Number of times the objective was secured
        /// </summary>
        [JsonProperty("times_objective_secured")]
        public int TimesObjSecured { get; private set; }
    }
}
