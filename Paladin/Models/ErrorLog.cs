using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Paladin.Models
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string ControllerName { get; set; }
        public string UserAgent { get; set; }
        public string StackTrace { get; set; }
        public string SessionId { get; set; }
        public string TargetedResult { get; set; }
        public DateTime Timestamp { get; set; }
    }
}