using R6Stats.Response.Interfaces;

namespace R6Stats.Response
{
    public sealed class APIResponse<T> where T : IPayload
    {
        public string Status { get; }
        public string Error { get; }
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
