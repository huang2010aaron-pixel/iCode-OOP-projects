using System;
namespace BankAccountApp;
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