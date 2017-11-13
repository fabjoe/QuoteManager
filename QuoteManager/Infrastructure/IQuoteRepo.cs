using QuoteManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteManager.Infrastructure
{
    public interface IQuoteRepo
    {
        IEnumerable<Quote> GetQuotes();
        Quote GetQuoteById(long quoteId);
        IEnumerable<Currency> GetCurrencies();
        IEnumerable<QuoteStatus> GetStatus();
        void Insert(Quote quote);
        void Update(Quote quote);
        void Delete(Quote quote);
        void Delete(long quoteId);

    }
}
