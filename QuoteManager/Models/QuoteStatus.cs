using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteManager.Models
{
    public class QuoteStatus
    {
        public long QuoteStatusId { get; set; }
        public string QuoteStatusName { get; set; }
        public string QuoteStatusDescription { get; set; }
    }
}
