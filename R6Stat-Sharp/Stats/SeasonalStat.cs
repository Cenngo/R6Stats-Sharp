using Newtonsoft.Json;
using R6Stats.Enums;
using R6Stats.Stats.Interfaces;
using System;
using System.Collections.Generic;

namespace R6Stats.Stats
{
    /// <summary>
    /// 
    /// </summary>
    public class SeasonalStat : ISeasonalStat
    {
        /// <summary>
        /// Name of the season
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("start_date")]
        private string _startDate;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public DateTime StartDate => DateTime.Parse(_startDate);

        [JsonProperty("end_date")]
        private string _endDate;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public DateTime EndDate => DateTime.Parse(_endDate);

        [JsonProperty("regions")]
        private List<RegionStat> _regions;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<RegionStat> Regions => _regions;
    }

    public class Regions
    {
        [JsonProperty("ncsa")]
        private List<RegionStat> _ncsa;

        /// <summary>
        /// Region stats for North, Central and South America
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<RegionStat> NCSA => _ncsa;

        [JsonProperty("emea")]
        private List<RegionStat> _emea;

        /// <summary>
        /// Region stats for Europe, the Middle East and Africa
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<RegionStat> EMEA => _emea;

        [JsonProperty("apac")]
        private List<RegionStat> _apac;

        /// <summary>
        /// Region stats for Asia, Pacific
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<RegionStat> APAC => _apac;
    }

    /// <summary>
    /// Ranked stats for a server region
    /// </summary>
    public class RegionStat : IRankedData, IPlayerStat
    {
        [JsonProperty("region")]
        private string _region;

        /// <summary>
        /// Region of this <see cref="RegionStat"/>
        /// </summary>
        [JsonIgnore]
        public Region Region => Enum.Parse<Region>(_region, true);

        /// <summary>
        /// Number of times the player abandoned the game
        /// </summary>
        [JsonProperty("abandons")]
        public int Abandons { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("max_mmr")]
        public int MaxMMR { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("max_rank")]
        public int MaxRank { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("mmr")]
        public int MMR { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("next_rank_mmr")]
        public int NextRankMMR { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("prev_rank_mmr")]
        public int PrevRankMMR { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; private set; }

        /// <summary>
        /// Mean value of the player's skill
        /// </summary>
        [JsonProperty("skill_mean")]
        public double SkillMean { get; private set; }

        /// <summary>
        /// Standart deviation of player's skill
        /// </summary>
        [JsonProperty("skill_standard_deviation")]
        public double SkillStandartDeviation { get; private set; }

        [JsonProperty("created_for_date")]
        private string _createdForDate;

        /// <summary>
        /// Date this region data was created for
        /// </summary>
        [JsonIgnore]
        public DateTime CreatedForDate => DateTime.Parse(_createdForDate);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        /// <summary>
        /// Value of the last MMR change after a ranked match
        /// </summary>
        [JsonProperty("last_match_mmr_change")]
        public int LastMMRChange { get; private set; }

        /// <summary>
        /// Value of the last change of <see cref="SkillMean"/>
        /// </summary>
        [JsonProperty("last_match_skill_mean_change")]
        public double LastSkillMeanChange { get; private set; }

        /// <summary>
        /// Value of the last change of <see cref="SkillStandartDeviation"/>
        /// </summary>
        [JsonProperty("last_match_skill_standard_deviation_change")]
        public double LastSkillStandartDeviationChange { get; private set; }

        /// <summary>
        /// Result of the last ranked match
        /// </summary>
        [JsonProperty("last_match_result")]
        public int LastMatchResult { get; private set; }

        /// <summary>
        /// Champions rank position if the player is a champion
        /// </summary>
        [JsonProperty("champions_rank_position")]
        public int ChampionsPosition { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("max_rank_text")]
        public string MaxRankText { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("max_rank_image")]
        public string MaxRankImg { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("rank_text")]
        public string RankText { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonProperty("rank_image")]
        public string RankImg { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public double KD => Kills / Deaths;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [JsonIgnore]
        public double WinLose => Wins / Losses;
    }
}
