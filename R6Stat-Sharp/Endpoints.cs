using R6Stat_Sharp.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace R6Stat_Sharp
{
    internal static class Endpoints
    {
        private const string _statsBase = "/stats";
        private const string _leaderboardBase = "/leaderboard";

        private const string _generic = "/generic";
        private const string _operators = "/operators";
        private const string _seasonal = "/seasonal";
        private const string _weapons = "/weapons";
        private const string _weaponCats = "/weapon-categories";

        public static string GetGeneric ( string username, Platform platform ) =>
            _statsBase + $"/{username}/{platform.ToString().ToLower()}" + _generic;

        public static string GetOperators ( string username, Platform platform ) =>
            _statsBase + $"/{username}/{platform.ToString().ToLower()}" + _operators;

        public static string GetSeasonal ( string username, Platform platform ) =>
            _statsBase + $"/{username}/{platform.ToString().ToLower()}" + _seasonal;

        public static string GetWeapons ( string username, Platform platform ) =>
            _statsBase + $"/{username}/{platform.ToString().ToLower()}" + _weapons;

        public static string GetWeaponCats ( string username, Platform platform ) =>
            _statsBase + $"/{username}/{platform.ToString().ToLower()}" + _weaponCats;

        public static string GetLeaderboard ( Region region = Region.ALL ) =>
            _leaderboardBase + "/" + region.ToString().ToLower();
    }
}
