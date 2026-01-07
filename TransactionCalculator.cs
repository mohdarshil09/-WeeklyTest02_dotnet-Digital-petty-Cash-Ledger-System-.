namespace Digital_Petty_Cash_Ledger_System
{
    /// <summary>
    /// Helper utility for transaction-related calculations.
    /// </summary>
    public static class TransactionCalculator
    {
        /// <summary>
        /// Sums the Amount of all provided transactions.
        /// </summary>
        public static decimal SumAmounts<T>(IEnumerable<T> transactions) where T : Transaction
        {
            decimal total = 0m;

            foreach (T transaction in transactions)
            {
                if (transaction != null)
                {
                    total += transaction.Amount;
                }
            }
            return total;
        }
    }
}