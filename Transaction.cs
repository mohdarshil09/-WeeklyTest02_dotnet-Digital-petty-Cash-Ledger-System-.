namespace Digital_Petty_Cash_Ledger_System
{
    /// <summary>
    /// Abstract base class representing a financial transaction
    /// </summary>
    public abstract class Transaction : IReportable
    {
        // Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        // Constructor
        protected Transaction(int id, DateTime date, decimal amount, string description)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Description = description ?? string.Empty;
        }

        // Abstract method to be implemented by derived classes
        public abstract string GetSummary();
    }
}

