using R6Stats.Response.Interfaces;

namespace R6Stats.Response
{
    /// <summary>
    /// Represents the response of an Api interaction with <see href="https://r6stats.com/">R6Stats API</see>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class APIResponse<T> where T : class, IPayload
    {
        /// <summary>
        /// Status of the Api response
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// Error message for the response if the <see cref="APIResponse{T}.Status"/> is not "OK"
        /// </summary>
        public string Error { get; }

        /// <summary>
        /// Whether the Api interaction was successful or not
        /// </summary>
        public bool IsSuccessful => Error == null;

        /// <summary>
        /// Data returned by the Api if the interaction was successful
        /// </summary>
        public T Payload { get; }

        internal APIResponse ( string status, T payload )
        {
            Status = status;
            Payload = payload;
        }

        internal APIResponse ( string status, string error )
        {
            Status = status;
            Error = error;
        }
    }
}
