using Newtonsoft.Json;
using R6Stat_Sharp.Enums;
using System;
using System.Collections.Generic;

namespace R6Stat_Sharp.Stats
{
    public class SeasonalStat : ISeasonalStat
    {
        [JsonProperty("ncsa")]
        public string Name { get; internal set; }

        [JsonProperty("ncsa")]
        internal string _startDate;

        [JsonIgnore]
        public DateTime StartDate => DateTime.Parse(_startDate);

        [JsonProperty("ncsa")]
        internal string _endDate;

        [JsonIgnore]
        public DateTime EndDate => DateTime.Parse(_endDate);

        [JsonProperty("ncsa")]
        internal List<RegionStat> _regions;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> Regions => _regions;
    }

    public class Regions
    {
        [JsonProperty("ncsa")]
        internal List<RegionStat> _ncsa;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> NCSA => _ncsa;

        [JsonProperty("emea")]
        internal List<RegionStat> _emea;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> EMEA => _emea;

        [JsonProperty("apac")]
        internal List<RegionStat> _apac;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> APAC => _apac;
    }

    public class RegionStat : IRankedData, IPlayerStat
    {
        [JsonProperty("region")]
        internal string _region;

        [JsonIgnore]
        public Region Region => Enum.Parse<Region>(_region, true);

        [JsonProperty("abandons")]
        public int Abandons { get; internal set; }

        [JsonProperty("losses")]
        public int Losses { get; internal set; }

        [JsonProperty("max_mmr")]
        public int MaxMMR { get; internal set; }

        [JsonProperty("max_rank")]
        public int MaxRank { get; internal set; }

        [JsonProperty("mmr")]
        public int MMR { get; internal set; }

        [JsonProperty("next_rank_mmr")]
        public int NextRankMMR { get; internal set; }

        [JsonProperty("prev_rank_mmr")]
        public int PrevRankMMR { get; internal set; }

        [JsonProperty("rank")]
        public int Rank { get; internal set; }

        [JsonProperty("skill_mean")]
        public double SkillMean { get; internal set; }

        [JsonProperty("skill_standard_deviation")]
        public double SkillStandartDeviation { get; internal set; }

        [JsonProperty("created_for_date")]
        internal string _createdForDate;

        [JsonIgnore]
        public DateTime CreatedForDate => DateTime.Parse(_createdForDate);

        [JsonProperty("wins")]
        public int Wins { get; internal set; }

        [JsonProperty("kills")]
        public int Kills { get; internal set; }

        [JsonProperty("deaths")]
        public int Deaths { get; internal set; }

        [JsonProperty("last_match_mmr_change")]
        public int LastMMRChange { get; internal set; }

        [JsonProperty("last_match_skill_mean_change")]
        public double LastSkillMeanChange { get; internal set; }

        [JsonProperty("last_match_skill_standard_deviation_change")]
        public double LastSkillStandartDeviationChange { get; internal set; }

        [JsonProperty("last_match_result")]
        public int LastMatchResult { get; internal set; }

        [JsonProperty("champions_rank_position")]
        public int ChampionsPosition { get; internal set; }

        [JsonProperty("max_rank_text")]
        public string MaxRankText { get; internal set; }

        [JsonProperty("max_rank_image")]
        public string MaxRankImg { get; internal set; }

        [JsonProperty("rank_text")]
        public string RankText { get; internal set; }

        [JsonProperty("rank_image")]
        public string RankImg { get; internal set; }

        [JsonIgnore]
        public double KD => Kills / Deaths;

        [JsonIgnore]
        public double WinLose => Wins / Losses;
    }
}
