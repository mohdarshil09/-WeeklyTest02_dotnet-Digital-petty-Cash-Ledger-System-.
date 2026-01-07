namespace Digital_Petty_Cash_Ledger_System
{
    /// <summary>
    /// Generic ledger class for managing transactions of a specific type
    /// </summary>
    /// <typeparam name="T">Type of transaction, must inherit from Transaction</typeparam>
    public class Ledger<T> where T : Transaction
    {
        // Internal storage using List<T>
        private List<T> _transactions;

        // Constructor
        public Ledger()
        {
            _transactions = new List<T>();
        }

        /// <summary>
        /// Adds a transaction entry to the ledger
        /// </summary>
        /// <param name="entry">The transaction to add</param>
        public void AddEntry(T entry)
        {
            if (entry == null)
                throw new ArgumentNullException(nameof(entry), "Transaction entry cannot be null");

            _transactions.Add(entry);
        }

        /// <summary>
        /// Retrieves all transactions for a specific date
        /// </summary>
        /// <param name="date">The date to filter by</param>
        /// <returns>List of transactions matching the date</returns>
        public List<T> GetTransactionsByDate(DateTime date)
        {
            // Using an loop 
            List<T> result = new List<T>();

            foreach (T transaction in _transactions)
            {
                if (transaction.Date.Date == date.Date)
                {
                    result.Add(transaction);
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates the total amount of all transactions in the ledger
        /// </summary>
        /// <returns>Total amount as decimal</returns>
        public decimal CalculateTotal()
        {
            // Delegate the calculation to a helper to keep Ledger focused on storage
            return TransactionCalculator.SumAmounts(_transactions);
        }

        /// <summary>
        /// Gets all transactions in the ledger
        /// </summary>
        /// <returns>Read-only list of all transactions</returns>
        public IReadOnlyList<T> GetAllTransactions()
        {
            return _transactions.AsReadOnly();
        }

        /// <summary>
        /// Gets the count of transactions in the ledger
        /// </summary>
        public int Count => _transactions.Count;
    }
}

