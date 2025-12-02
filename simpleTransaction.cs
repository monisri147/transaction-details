
using System;

class TransactionDemo
{
    static void Main()
    {
        string transactionId = "AB12CD34EF56";
        decimal amount = 1000000.75m;
        bool isInternational = true;
        decimal customerRating = 4.75m;
        DateTime transactionTimestamp = DateTime.Now;
        int rewardPoints = 2500000;

        Console.WriteLine("Transaction ID: " + transactionId);
        Console.WriteLine("Amount: Rs " + amount);
        Console.WriteLine("Is International: " + isInternational);
        Console.WriteLine("Customer Rating: " + customerRating);
        Console.WriteLine("Timestamp: " + transactionTimestamp);
        Console.WriteLine("Reward Points: " + rewardPoints);
    }
}
