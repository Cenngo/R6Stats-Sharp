using Newtonsoft.Json;
using R6Stats.Enums;
using R6Stats.Stats.Interfaces;
using System;
using System.Collections.Generic;

namespace R6Stats.Stats
{
    public class SeasonalStat : ISeasonalStat
    {
        [JsonProperty("ncsa")]
        public string Name { get; private set; }

        [JsonProperty("ncsa")]
        private string _startDate;

        [JsonIgnore]
        public DateTime StartDate => DateTime.Parse(_startDate);

        [JsonProperty("ncsa")]
        private string _endDate;

        [JsonIgnore]
        public DateTime EndDate => DateTime.Parse(_endDate);

        [JsonProperty("ncsa")]
        private List<RegionStat> _regions;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> Regions => _regions;
    }

    public class Regions
    {
        [JsonProperty("ncsa")]
        private List<RegionStat> _ncsa;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> NCSA => _ncsa;

        [JsonProperty("emea")]
        private List<RegionStat> _emea;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> EMEA => _emea;

        [JsonProperty("apac")]
        private List<RegionStat> _apac;

        [JsonIgnore]
        public IReadOnlyList<RegionStat> APAC => _apac;
    }

    public class RegionStat : IRankedData, IPlayerStat
    {
        [JsonProperty("region")]
        private string _region;

        [JsonIgnore]
        public Region Region => Enum.Parse<Region>(_region, true);

        [JsonProperty("abandons")]
        public int Abandons { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("max_mmr")]
        public int MaxMMR { get; private set; }

        [JsonProperty("max_rank")]
        public int MaxRank { get; private set; }

        [JsonProperty("mmr")]
        public int MMR { get; private set; }

        [JsonProperty("next_rank_mmr")]
        public int NextRankMMR { get; private set; }

        [JsonProperty("prev_rank_mmr")]
        public int PrevRankMMR { get; private set; }

        [JsonProperty("rank")]
        public int Rank { get; private set; }

        [JsonProperty("skill_mean")]
        public double SkillMean { get; private set; }

        [JsonProperty("skill_standard_deviation")]
        public double SkillStandartDeviation { get; private set; }

        [JsonProperty("created_for_date")]
        private string _createdForDate;

        [JsonIgnore]
        public DateTime CreatedForDate => DateTime.Parse(_createdForDate);

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("last_match_mmr_change")]
        public int LastMMRChange { get; private set; }

        [JsonProperty("last_match_skill_mean_change")]
        public double LastSkillMeanChange { get; private set; }

        [JsonProperty("last_match_skill_standard_deviation_change")]
        public double LastSkillStandartDeviationChange { get; private set; }

        [JsonProperty("last_match_result")]
        public int LastMatchResult { get; private set; }

        [JsonProperty("champions_rank_position")]
        public int ChampionsPosition { get; private set; }

        [JsonProperty("max_rank_text")]
        public string MaxRankText { get; private set; }

        [JsonProperty("max_rank_image")]
        public string MaxRankImg { get; private set; }

        [JsonProperty("rank_text")]
        public string RankText { get; private set; }

        [JsonProperty("rank_image")]
        public string RankImg { get; private set; }

        [JsonIgnore]
        public double KD => Kills / Deaths;

        [JsonIgnore]
        public double WinLose => Wins / Losses;
    }
}
