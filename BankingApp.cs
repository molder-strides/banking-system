// BankingApp.cs
class BankingApp
{
    static void Main()
    {
        Account account1 = new Account();
        Account account2 = new Account();
        Transaction transaction1 = new Transaction();
        Transaction transaction2 = new Transaction();

        account1.InitializeAccount(1001, "John Doe", 1500.0);
        account2.InitializeAccount(1002, "Jane Smith", 2000.0);

        transaction1.TransactionID = 1;
        transaction1.Account = account1;
        transaction1.Description = "Deposit";
        transaction1.Amount = 500.0;

        transaction2.TransactionID = 2;
        transaction2.Account = account2;
        transaction2.Description = "Withdrawal";
        transaction2.Amount = 300.0;

        Console.WriteLine("Initial Account Information:");
        account1.DisplayAccount();
        account2.DisplayAccount();

        Console.WriteLine("\nExecuting Transactions:");
        transaction1.ProcessTransaction();
        transaction2.ProcessTransaction();

        Console.WriteLine("\nFinal Account Information:");
        account1.DisplayAccount();
        account2.DisplayAccount();
    }
}
