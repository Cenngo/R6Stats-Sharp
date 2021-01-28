namespace R6Stat_Sharp
{
    /// <summary>
    /// Config object used to initialize the API client <see cref="R6StatsClient"/>
    /// </summary>
    public class R6StatsClientConfig
    {
        /// <summary>
        /// Bearer token for the API which can be obtained from <see href="https://discord.gg/pUdraS3">R6Stats Discord Server</see>
        /// </summary>
        public string ApiKey { get; set; }

        public R6StatsClientConfig ( )
        {
        }
    }
}
