using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessRulesEngine.Models
{
    public class OperationResult
    {
        public IEnumerable<string> Messages { get; set; }
        public bool IsSuccessful { get { return !Messages.Any(); } }
    }
}