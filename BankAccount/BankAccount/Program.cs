using System;

class BankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public double GetBalance() => balance;

    public void Withdraw(double amount)
    {
        if (balance > 0 && amount > 0)
        {
            balance -= amount; 
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount myBankAccount = new BankAccount();
        BankAccount myFriendsAccount = new BankAccount();

        Console.WriteLine("Here is the balance of my bank account: " + myBankAccount.GetBalance());
        myBankAccount.Deposit(25);
        Console.WriteLine("Here is the balance of my bank account: " + myBankAccount.GetBalance());
        myFriendsAccount.Deposit(100);
        myBankAccount.Withdraw(100);
        Console.WriteLine("Here is the balance of my bank account: " + myBankAccount.GetBalance());
    }
}