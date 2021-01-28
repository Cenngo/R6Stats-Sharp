using Newtonsoft.Json;
using R6Stat_Sharp.Enums;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Config = R6Stat_Sharp.R6StatsClientConfig;

namespace R6Stat_Sharp
{
    public class R6StatsClient
    {
        private const string _baseUrl = "https://api2.r6stats.com/public-api/";
        private readonly HttpClient _httpClient;

        private readonly string _key;

        public R6StatsClient ( Config config )
        {
            _key = config.ApiKey;

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_baseUrl)
            };
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _key);
        }

        public async Task<GenericResponse> GetGenericStats ( string username, Platform platform ) =>
            await GetResponse<GenericResponse>(Endpoints.GetGeneric(username, platform));

        public async Task<SeasonalResponse> GetSeasonalStats ( string username, Platform platform ) =>
            await GetResponse<SeasonalResponse>(Endpoints.GetSeasonal(username, platform));

        public async Task<OperatorResponse> GetOperatorStats ( string username, Platform platform ) =>
            await GetResponse<OperatorResponse>(Endpoints.GetSeasonal(username, platform));

        public async Task<IEnumerable<OperatorStat>> GetOperatorStats ( string username, Platform platform, Func<OperatorStat, bool> predicate ) =>
            ( await GetOperatorStats(username, platform) ).Operators.Where(predicate);

        public async Task<WeaponsResponse> GetWeaponStats ( string username, Platform platform ) =>
            await GetResponse<WeaponsResponse>(Endpoints.GetWeapons(username, platform));

        public async Task<WeaponCategoryResponse> GetWeaponCategoryStats ( string username, Platform platform ) =>
            await GetResponse<WeaponCategoryResponse>(Endpoints.GetWeaponCats(username, platform));

        public async Task<IEnumerable<WeaponCategoryStat>> GetWeaponCategoryStats ( string username, Platform platform, Func<WeaponCategoryStat, bool> predicate ) =>
            ( await GetWeaponCategoryStats(username, platform) ).WeaponCategories.Where(predicate);

        public async Task<IEnumerable<LeaderboardSlot>> GetLeaderboard ( Region region = Region.ALL ) =>
            await GetResponse<IEnumerable<LeaderboardSlot>>(Endpoints.GetLeaderboard(region));

        private async Task<T> GetResponse<T> ( string endpoint, JsonSerializerSettings settings = default ) where T : class
        {
            var response = await _httpClient.GetAsync(endpoint);

            using var sr = new StreamReader(await response.Content.ReadAsStreamAsync());
            var content = sr.ReadToEnd();

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ApiError>(content);
                throw new Exception($"API Exception Occurred, Status: {error.Status} Error: {error.Error}");
            }

            return JsonConvert.DeserializeObject<T>(content, settings);
        }
    }
}
