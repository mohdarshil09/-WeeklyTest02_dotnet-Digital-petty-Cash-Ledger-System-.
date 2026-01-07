namespace Digital_Petty_Cash_Ledger_System
{
    /// <summary>
    /// Represents an income transaction with a source
    /// </summary>
    public class IncomeTransaction : Transaction
    {
        // Additional property for Income
        public string Source { get; set; }

        /// <summary>
        /// constructor for IncomeTransaction
        /// </summary>
       
        public IncomeTransaction(int id, DateTime date, decimal amount, string description, string source)
            : base(id, date, amount, description)
        {
            Source = source ?? string.Empty;
        }

        // Implementation of GetSummary for IncomeTransaction
        public override string GetSummary()
        {
            return $"Income [ID: {Id}] | Date: {Date:yyyy-MM-dd} | Amount: ${Amount:F2} | Source: {Source} | Description: {Description}";
        }
    }
}

