using System;
namespace BannkAcoount00;
public class BankAccount
{
    private string id;
    private decimal balance;
    public string ID {
        get
        {
            return id;
        } 
    }

    public decimal Balance {
        get
        {
          return balance;  
        } 
    }

    public BankAccount(string id, decimal InitialBalance)
    {
        this.id = id;
        balance = InitialBalance;
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new Exception("Amount has to be a positve value");
        }
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new Exception("Amount has to be a positve value");
        }

        if(amount > balance)
        {
            throw new Exception("Amount has to be less or equal than balance");
        }
        balance -= amount;
    }
}