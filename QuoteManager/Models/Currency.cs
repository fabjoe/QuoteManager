using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteManager.Models
{
    public class Currency
    {
        public long CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyDescription { get; set; }
    }
}
