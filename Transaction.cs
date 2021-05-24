using System;


namespace TransactionApp
{
    class Transaction : IModel
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
