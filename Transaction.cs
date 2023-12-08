// Transaction.cs
using System;

public class Transaction
{
    public int TransactionID { get; set; }
    public Account Account { get; set; }
    public string Description { get; set; }
    public double Amount { get; set; }

    public void ProcessTransaction()
    {
        // Perform necessary transaction processing
        // For simplicity, just display the transaction details
        Console.WriteLine($"Processing Transaction ID: {TransactionID}");
        DisplayTransaction();
    }

    public void DisplayTransaction()
    {
        Console.WriteLine("Account Information:");
        Account.DisplayAccount();
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Amount: ${Amount}");
    }
}
