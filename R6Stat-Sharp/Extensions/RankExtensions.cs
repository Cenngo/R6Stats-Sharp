using R6Stats.Stats.Interfaces;
using System.Drawing;

namespace R6Stats.Extensions
{
    /// <summary>
    /// Extensions class for utilities regarding ranked data
    /// </summary>
    public static class RankExtensions
    {
        private const string _copper = "#860F0D";
        private const string _bronze = "#9C6227";
        private const string _silver = "#9B9B9B";
        private const string _gold = "#EAD32D";
        private const string _plat = "#63D3D2";
        private const string _diamond = "#B99EF3";
        private const string _champion = "#B11163";

        /// <summary>
        /// Parse the badge color for a rank
        /// </summary>
        /// <param name="data">Object containing the rank information of a player</param>
        /// <param name="parseMax">Parse the color of max rank achieved by the player if <see langword="true"/>, else parse the badge color of the current rank</param>
        /// <returns>Badge color of the given rank</returns>
        public static Color GetRankColor ( this IRankedData data, bool parseMax = false )
        {
            var rank = parseMax ? data.MaxRankText : data.RankText;

            return ( rank.Split(' ')[0] ) switch
            {
                "Copper" => ColorTranslator.FromHtml(_copper),
                "Bronze" => ColorTranslator.FromHtml(_bronze),
                "Silver" => ColorTranslator.FromHtml(_silver),
                "Gold" => ColorTranslator.FromHtml(_gold),
                "Platinum" => ColorTranslator.FromHtml(_plat),
                "Diamond" => ColorTranslator.FromHtml(_diamond),
                "Champions" => ColorTranslator.FromHtml(_champion),
                _ => Color.Black,
            };
        }
    }
}
