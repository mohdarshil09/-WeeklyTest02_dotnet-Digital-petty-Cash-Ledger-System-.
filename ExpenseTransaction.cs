namespace Digital_Petty_Cash_Ledger_System
{
    /// <summary>
    /// Represents an expense transaction with a category
    /// </summary>
    public class ExpenseTransaction : Transaction
    {
        // Additional property for Expense
        public string Category { get; set; }

        /// <summary>
        /// constructor for ExpenseTransaction
        /// </summary>
       
        public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string category)
            : base(id, date, amount, description)
        {
            Category = category ?? string.Empty;
        }

        // Implementation of GetSummary for ExpenseTransaction
        public override string GetSummary()
        {
            return $"Expense [ID: {Id}] | Date: {Date:yyyy-MM-dd} | Amount: ${Amount:F2} | Category: {Category} | Description: {Description}";
        }
    }
}

