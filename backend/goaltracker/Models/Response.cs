using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace goaltracker.Models
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Payload { get; set; }

        public Response(bool success, string message, object payload=null)
        {
            this.Success = success;
            this.Message = message;
            this.Payload = payload;
        }
    }
}
