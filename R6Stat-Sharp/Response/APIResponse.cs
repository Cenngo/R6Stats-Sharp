using R6Stat_Sharp.Models;
using R6Stat_Sharp.Response.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stat_Sharp.Response
{
    public class APIResponse<T> where T : IPayload
    {
        public string Status { get; }
        public string Error { get; }
        public T Payload { get; }

        internal APIResponse(string status, T payload )
        {
            Status = status;
            Payload = payload;
        }

        internal APIResponse(string status, string error )
        {
            Status = status;
            Error = error;
        }
    }
}
