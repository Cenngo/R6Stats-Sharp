namespace R6Stats
{
    /// <summary>
    /// Config object used to initialize the API client <see cref="R6StatsClient"/>
    /// </summary>
    public sealed class R6StatsClientConfig
    {
        /// <summary>
        /// Bearer token for the API which can be obtained from <see href="https://discord.gg/pUdraS3">R6Stats Discord Server</see>
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Create a new config for <see cref="R6StatsClient"/>
        /// </summary>
        /// <param name="apiKey">API key needed to access the <see href="https://r6stats.com/">R6 Stats API</see></param>
        public R6StatsClientConfig ( string apiKey )
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Create a new config for <see cref="R6StatsClient"/>
        /// </summary>
        public R6StatsClientConfig ( ) { }
    }
}
