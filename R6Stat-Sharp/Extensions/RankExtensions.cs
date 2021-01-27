using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace R6Stat_Sharp.Extensions
{
    public static class RankExtensions
    {
        private const string _copper = "";
        private const string _bronze = "";
        private const string _silver = "";
        private const string _gold = "";
        private const string _plat = "";
        private const string _diamond = "";
        private const string _champion = "";

        public static Color GetRankColor(this IRankedData data)
        {
            switch (data.RankText)
            {
                default:
                    break;
            }
        }

        public static Color GetMaxRankColor(this IRankedData data )
        {

        }

        private static Color GetColor(string rankName )
        {
            switch (rankName)
            {
                case "Copper":
                    return new Color().hex
                default:
                    break;
            }
        }
    }
}
