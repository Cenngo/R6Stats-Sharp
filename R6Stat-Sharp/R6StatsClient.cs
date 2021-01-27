using Newtonsoft.Json;
using R6Stat_Sharp.Enums;
using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
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

        public async Task<GenericResponse> GetGeneric(string username, Platform platform )
        {
            var endpoint = Endpoints.GetGeneric(username, platform);
            var response = await _httpClient.GetAsync(endpoint);
            Console.WriteLine(endpoint);
            Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            using(var sr = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
                var content = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<GenericResponse>(content, new JsonSerializerSettings{
                    NullValueHandling = NullValueHandling.Include,
                });
            }

        }
    }
}
