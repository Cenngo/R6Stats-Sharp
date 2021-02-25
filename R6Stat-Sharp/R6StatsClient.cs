using Newtonsoft.Json;
using R6Stats.Enums;
using R6Stats.Models;
using R6Stats.Response;
using R6Stats.Response.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Config = R6Stats.R6StatsClientConfig;

namespace R6Stats
{
    /// <summary>
    /// API client for parsing Rainbow6 Siege Game Data
    /// </summary>
    public sealed class R6StatsClient : IDisposable
    {
        private const string _baseUrl = "https://api2.r6stats.com/public-api/";

        private readonly HttpClient _httpClient;
        private readonly ImmutableDictionary<string, IEnumerable<string>> _headers;
        private readonly JsonSerializerSettings _defaultSerializerSettings;

        private readonly string _key;

        /// <summary>
        /// Create an instance of <see cref="R6StatsClient"/>
        /// </summary>
        /// <param name="config"><see cref="Config"/> containing the necessary information to instanciate the client </param>
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

            _defaultSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        /// <summary>
        /// Create an instance of <see cref="R6StatsClient"/>
        /// </summary>
        /// <param name="config"><see cref="Config"/>Object containing the necessary information to instanciate the client</param>
        /// <param name="headers">Optional request headers to be used while making REST API requests</param>
        public R6StatsClient ( Config config, IDictionary<string, IEnumerable<string>> headers ) : this(config)
        {
            _headers = headers.ToImmutableDictionary();

            foreach (var header in _headers)
                _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        }

        /// <summary>
        /// Method for making generic data request to the API
        /// </summary>
        /// <remarks>Generic information contains the basic profile information along with some overall information about gamemode stats</remarks>
        /// <param name="username">Username the stats belongs to</param>
        /// <param name="platform">Platform the user plays on</param>
        /// <returns><see cref="APIResponse{T}"/> containing the request status data and a <see cref="GenericResponse"/> with the requested data</returns>
        public async Task<APIResponse<GenericResponse>> GetGenericStats ( string username, Platform platform ) =>
            await GetResponse<GenericResponse>(Endpoints.GetGeneric(username, platform));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">Username the stats belongs to</param>
        /// <param name="platform">Platform the user plays on</param>
        /// <returns><see cref="APIResponse{T}"/> containing the request status data and a <see cref="SeasonalResponse"/> with the requested data</returns>
        /// <example>
        /// How to get seasonal stats
        /// <c>var seasonal = await GetSeasonalStats("username", Platform.PC)</c>
        /// </example>
        public async Task<APIResponse<SeasonalResponse>> GetSeasonalStats ( string username, Platform platform ) =>
            await GetResponse<SeasonalResponse>(Endpoints.GetSeasonal(username, platform));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">Username the stats belongs to</param>
        /// <param name="platform">Platform the user plays on</param>
        /// <returns><see cref="APIResponse{T}"/> containing the request status data and a <see cref="OperatorResponse"/> with the requested data</returns>
        public async Task<APIResponse<OperatorResponse>> GetOperatorStats ( string username, Platform platform ) =>
            await GetResponse<OperatorResponse>(Endpoints.GetOperators(username, platform));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">Username the stats belongs to</param>
        /// <param name="platform">Platform the user plays on</param>
        /// <returns><see cref="APIResponse{T}"/> containing the request status data and a <see cref="WeaponsResponse"/> with the requested data</returns>
        public async Task<APIResponse<WeaponsResponse>> GetWeaponStats ( string username, Platform platform ) =>
            await GetResponse<WeaponsResponse>(Endpoints.GetWeapons(username, platform));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">Username the stats belongs to</param>
        /// <param name="platform">Platform the user plays on</param>
        /// <returns><see cref="APIResponse{T}"/> containing the request status data and a <see cref="WeaponCategoryResponse"/> with the requested data</returns>
        public async Task<APIResponse<WeaponCategoryResponse>> GetWeaponCategoryStats ( string username, Platform platform ) =>
            await GetResponse<WeaponCategoryResponse>(Endpoints.GetWeaponCats(username, platform));

        /// <summary>
        /// Parse the current leaderboard for a region
        /// </summary>
        /// <param name="platform">Platform for the leaderboard</param>
        /// <param name="region">Region of the players in the leaderboard</param>
        /// <returns><see cref="APIResponse{T}"/> containing the request status data and a <see cref="Leaderboard"/> with the requested data</returns>
        public async Task<APIResponse<Leaderboard>> GetLeaderboard ( Platform platform, Region region = Region.ALL ) =>
            await GetResponse<Leaderboard>(Endpoints.GetLeaderboard(platform, region));

        private async Task<APIResponse<T>> GetResponse<T> ( string endpoint, JsonSerializerSettings settings = null ) where T : class, IPayload
        {
            var response = await _httpClient.GetAsync(endpoint);

            using var sr = new StreamReader(await response.Content.ReadAsStreamAsync());
            var content = sr.ReadToEnd();

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ApiError>(content);
                return new APIResponse<T>(error.Status, error.Error);
            }
            var payload = JsonConvert.DeserializeObject<T>(content, settings ?? _defaultSerializerSettings);
            response.Dispose();

            return new APIResponse<T>(response.StatusCode.ToString(), payload);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void Dispose ( )
        {
            _httpClient.Dispose();
        }
    }
}
