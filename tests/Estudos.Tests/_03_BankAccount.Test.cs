using System;
using BannkAcoount00;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]

public class BankAccountTest
{
    [Test]
    public void TestConstructor()
    {
        BankAccount account = new BankAccount("Account1", 1000);
        Assert.That(account.Balance, Is.EqualTo(1000));
    }

    [Test]
    public void TestDeposit()
    {
        BankAccount account = new BankAccount("Account1", 1000);
        account.Deposit(500);
        Assert.That(account.Balance, Is.EqualTo(1500));
    }

    [Test]
    public void TestDepositWithNegativeAmount()
    {
        BankAccount account = new BankAccount("Account1", 1000);
        Assert.Throws<Exception>(() => account.Deposit(-500));
        Assert.That(account.Balance, Is.EqualTo(1000));
    }

     [Test]
    public void TestWithdraw()
    {
        BankAccount account = new BankAccount("Account1", 1000);
        account.Withdraw(500);
        Assert.That(account.Balance, Is.EqualTo(500));
        account.Withdraw(200);
        Assert.That(account.Balance, Is.EqualTo(300));
    }

    [Test]
    public void TestWithdrawNegativeAmount()
    {
        BankAccount account = new BankAccount("Account1", 1000);
        Assert.Throws<Exception>(() => account.Withdraw(-500));
    }

    [Test]
    public void TestWithdrawOverAmountLimit()
    {
        BankAccount account = new BankAccount("Account1", 1000);
        Assert.Throws<Exception>(() => account.Withdraw(5000));
    }
}