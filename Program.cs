namespace Digital_Petty_Cash_Ledger_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("     Digital Petty Cash Ledger System");
            Console.WriteLine("==========================================\n");

            
            //Step 1: Create a Ledger<IncomeTransaction> to track funds received
            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();


            // Step 2: Record a $500 replenishment from "Main Cash"
            IncomeTransaction replenishment = new IncomeTransaction(
                id: 1,
                date: DateTime.Now,
                amount: 500.00m,
                description: "Monthly replenishment",
                source: "Main Cash"
            );
            incomeLedger.AddEntry(replenishment);
            Console.WriteLine("Added income transaction:");
            Console.WriteLine($"  {replenishment.GetSummary()}\n");


            // Step 3: Create a Ledger<ExpenseTransaction> to track daily spends
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();


            // Step 4: Record expenses
            ExpenseTransaction stationeryExpense = new ExpenseTransaction(
                id: 1,
                date: DateTime.Now,
                amount: 20.00m,
                description: "Office stationery purchase",
                category: "Office"
            );
            expenseLedger.AddEntry(stationeryExpense);
            Console.WriteLine("Added expense transaction:");
            Console.WriteLine($"  {stationeryExpense.GetSummary()}");

            ExpenseTransaction snacksExpense = new ExpenseTransaction(
                id: 2,
                date: DateTime.Now,
                amount: 15.00m,
                description: "Team refreshments",
                category: "Food"
            );
            expenseLedger.AddEntry(snacksExpense);
            Console.WriteLine("Added expense transaction:");
            Console.WriteLine($"  {snacksExpense.GetSummary()}\n");


            // Step 5: Display totals using generic method
            decimal totalIncome = incomeLedger.CalculateTotal();
            decimal totalExpenses = expenseLedger.CalculateTotal();

            Console.WriteLine("==========================================");
            Console.WriteLine("Financial Summary");
            Console.WriteLine("==========================================");
            Console.WriteLine($"Total Income:     ${totalIncome:F2}");
            Console.WriteLine($"Total Expenses:   ${totalExpenses:F2}");
            Console.WriteLine("------------------------------------------");


            // Step 6: Calculate Net Balance (Total Income - Total Expenses)
            decimal netBalance = totalIncome - totalExpenses;
            Console.WriteLine($"Net Balance:      ${netBalance:F2}");
            Console.WriteLine("==========================================\n");


          
            

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
