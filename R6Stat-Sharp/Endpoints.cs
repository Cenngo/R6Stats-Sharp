using R6Stat_Sharp.Enums;
using R6Stat_Sharp.Response;

namespace R6Stat_Sharp
{
    /// <summary>
    /// Class containing all of the necessary API endpoints for <see href="https://r6stats.com/">R6Stats API</see>
    /// </summary>
    internal static class Endpoints
    {
        private const string _statsBase = "stats/";
        private const string _leaderboardBase = "leaderboard/";

        private const string _generic = "/generic";
        private const string _operators = "/operators";
        private const string _seasonal = "/seasonal";
        private const string _weapons = "/weapons";
        private const string _weaponCats = "/weapon-categories";

        /// <summary>
        /// Method to for creating the path for a generic profile request <seealso cref="GenericResponse"/>
        /// </summary>
        /// <param name="username">Username to be parsed</param>
        /// <param name="platform">Platform the username belongs to</param>
        /// <returns>Path to send the GET request</returns>
        public static string GetGeneric ( string username, Platform platform ) =>
            _statsBase + $"{username}/{platform.ToString().ToLower()}" + _generic;

        /// <summary>
        /// Method to for creating the path for a operator stat request <seealso cref="OperatorResponse"/>
        /// </summary>
        /// <param name="username">Username to be parsed</param>
        /// <param name="platform">Platform the username belongs to</param>
        /// <returns>Path to send the GET request</returns>
        public static string GetOperators ( string username, Platform platform ) =>
            _statsBase + $"{username}/{platform.ToString().ToLower()}" + _operators;

        /// <summary>
        /// Method to for creating the path for a operator stat request <seealso cref="OperatorResponse"/>
        /// </summary>
        /// <param name="username">Username to be parsed</param>
        /// <param name="platform">Platform the username belongs to</param>
        /// <returns>Path to send the GET request</returns>
        public static string GetSeasonal ( string username, Platform platform ) =>
            _statsBase + $"{username}/{platform.ToString().ToLower()}" + _seasonal;

        /// <summary>
        /// Method to for creating the path for a weapons stat request <seealso cref="WeaponsResponse"/>
        /// </summary>
        /// <param name="username">Username to be parsed</param>
        /// <param name="platform">Platform the username belongs to</param>
        /// <returns>Path to send the GET request</returns>
        public static string GetWeapons ( string username, Platform platform ) =>
            _statsBase + $"{username}/{platform.ToString().ToLower()}" + _weapons;

        /// <summary>
        /// Method to for creating the path for a weapon category stat request <seealso cref="WeaponCategoryResponse"/>
        /// </summary>
        /// <param name="username">Username to be parsed</param>
        /// <param name="platform">Platform the username belongs to</param>
        /// <returns>Path to send the GET request</returns>
        public static string GetWeaponCats ( string username, Platform platform ) =>
            _statsBase + $"{username}/{platform.ToString().ToLower()}" + _weaponCats;

        /// <summary>
        /// Method to for creating the path for a operator stat request
        /// </summary>
        /// <param name="username">Username to be parsed</param>
        /// <param name="platform">Platform the username belongs to</param>
        /// <returns>Path to send the GET request</returns>
        public static string GetLeaderboard ( Region region = Region.ALL ) =>
            _leaderboardBase + region.ToString().ToLower();
    }
}
