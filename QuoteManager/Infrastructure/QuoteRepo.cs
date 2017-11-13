using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuoteManager.Models;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace QuoteManager.Infrastructure
{
    public class QuoteRepo : IQuoteRepo
    {
        private readonly ConnectionStrings _connectionStrings;

        public QuoteRepo(IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }
        public void Delete(Quote quote)
        {
            throw new NotImplementedException();
        }

        public void Delete(long quoteId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            throw new NotImplementedException();
        }

        public Quote GetQuoteById(long quoteId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Quote> GetQuotes()
        {
            List<Quote> quotesList = new List<Quote>();
            using (SqlConnection connection = new SqlConnection(_connectionStrings.DefaultConnection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("GetQuotes", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quote q = new Quote();
                            q.QuoteId = long.Parse(reader["QuoteId"].ToString());
                            q.QuoteName = reader["QuoteName"].ToString();
                            q.QuoteDescription = reader["QuoteDescription"].ToString();
                            q.CreationDate = DateTime.Parse(reader["CreationDate"].ToString());
                            q.ModifiedDate = DateTime.Parse(reader["ModifiedDate"].ToString());
                            q.Value = decimal.Parse(reader["Value"].ToString());
                            q.Currency = reader["Currency"].ToString();
                            q.ExpirationDate = DateTime.Parse(string.IsNullOrEmpty(reader["ExpirationDate"].ToString()) ? "1970-1-1" : reader["ExpirationDate"].ToString());
                            q.QuoteStatus = reader["QuoteStatus"].ToString();
                            quotesList.Add(q);
                        }
                    }
                }
            }
            return quotesList;
        }

        public IEnumerable<QuoteStatus> GetStatus()
        {
            throw new NotImplementedException();
        }

        public void Insert(Quote quote)
        {
            throw new NotImplementedException();
        }

        public void Update(Quote quote)
        {
            throw new NotImplementedException();
        }
    }
}
