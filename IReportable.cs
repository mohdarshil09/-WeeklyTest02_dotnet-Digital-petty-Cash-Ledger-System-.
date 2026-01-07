namespace Digital_Petty_Cash_Ledger_System
{
    /// <summary>
    /// Interface for objects that can generate a summary report
    /// </summary>
    public interface IReportable
    {
        /// <summary>
        /// Returns a formatted summary string of the transaction
        /// </summary>
        string GetSummary();
    }
}

