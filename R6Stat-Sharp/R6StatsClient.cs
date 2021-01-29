using Newtonsoft.Json;
using R6Stat_Sharp.Enums;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response;
using R6Stat_Sharp.Response.Interfaces;
using R6Stat_Sharp.Stats;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Config = R6Stat_Sharp.R6StatsClientConfig;

namespace R6Stat_Sharp
{
    public class R6StatsClient
    {
        private const string _baseUrl = "https://api2.r6stats.com/public-api/";

        private readonly HttpClient _httpClient;
        private readonly ImmutableDictionary<string, IEnumerable<string>> _headers;

        private readonly string _key;

        public R6StatsClient ( Config config )
        {
            _key = config.ApiKey;

            if (string.IsNullOrEmpty(_key))
                throw new ArgumentException("API key not found.");

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_baseUrl)
            };
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _key);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public R6StatsClient( Config config, IDictionary<string, IEnumerable<string>> headers) : this(config)
        {
            _headers = headers.ToImmutableDictionary();

            foreach (var header in _headers)
                _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        }

        public async Task<APIResponse<GenericResponse>> GetGenericStats ( string username, Platform platform ) =>
            await GetResponse<GenericResponse>(Endpoints.GetGeneric(username, platform));

        public async Task<APIResponse<SeasonalResponse>> GetSeasonalStats ( string username, Platform platform ) =>
            await GetResponse<SeasonalResponse>(Endpoints.GetSeasonal(username, platform));

        public async Task<APIResponse<OperatorResponse>> GetOperatorStats ( string username, Platform platform ) =>
            await GetResponse<OperatorResponse>(Endpoints.GetOperators(username, platform));

        public async Task<IEnumerable<OperatorStat>> GetOperatorStats ( string username, Platform platform, Func<OperatorStat, bool> predicate ) =>
            ( await GetOperatorStats(username, platform) ).Payload.Operators.Where(predicate);

        public async Task<APIResponse<WeaponsResponse>> GetWeaponStats ( string username, Platform platform ) =>
            await GetResponse<WeaponsResponse>(Endpoints.GetWeapons(username, platform));

        public async Task<APIResponse<WeaponCategoryResponse>> GetWeaponCategoryStats ( string username, Platform platform ) =>
            await GetResponse<WeaponCategoryResponse>(Endpoints.GetWeaponCats(username, platform));

        public async Task<IEnumerable<WeaponCategoryStat>> GetWeaponCategoryStats ( string username, Platform platform, Func<WeaponCategoryStat, bool> predicate ) =>
            ( await GetWeaponCategoryStats(username, platform) ).Payload.WeaponCategories.Where(predicate);

        public async Task<APIResponse<Leaderboard>> GetLeaderboard (Platform platform, Region region = Region.ALL ) =>
            await GetResponse<Leaderboard>(Endpoints.GetLeaderboard(platform, region));

        private async Task<APIResponse<T>> GetResponse<T> ( string endpoint, JsonSerializerSettings settings = default ) where T : IPayload
        {
            var response = await _httpClient.GetAsync(endpoint);

            using var sr = new StreamReader(await response.Content.ReadAsStreamAsync());
            var content = sr.ReadToEnd();

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ApiError>(content);
                return new APIResponse<T>(error.Status, error.Error);
            }
            var payload = JsonConvert.DeserializeObject<T>(content, settings);
            return new APIResponse<T>(response.StatusCode.ToString(), payload);
        }
    }
}
