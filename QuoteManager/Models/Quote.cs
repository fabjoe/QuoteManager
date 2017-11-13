using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteManager.Models
{
    public class Quote
    {
        public long QuoteId { get; set; }
        public string QuoteName { get; set; }
        public string QuoteDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Decimal Value { get; set; }
        public string Currency { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string QuoteStatus { get; set; }
    }
}
