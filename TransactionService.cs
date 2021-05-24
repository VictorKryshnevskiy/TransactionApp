using System.Collections.Generic;
using System.Text.Json;

namespace TransactionApp
{
    class TransactionService : IService<Transaction>
    {
        public void Add(Transaction item)
        {
            transactions.Add(item.Id, item);
        }

        public string Get(int id)
        {
            transactions.TryGetValue(id, out Transaction transaction);
            return JsonSerializer.Serialize(transaction);
        }
        private readonly Dictionary<int, Transaction> transactions;
        public TransactionService()
        {
            transactions = new Dictionary<int, Transaction>();
        }
    }
}
