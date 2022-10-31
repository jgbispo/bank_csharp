using System;

namespace Bank
{
  class Account
  {
    private Person? person;
    private int accountNumber;
    private double balance;
    private double credit;

    Account(Person person, double balance, double credit)
    {
      if (VerifyEmpty.IsObjectEmpty(person) || VerifyEmpty.IsDoubleEmpty(balance) || VerifyEmpty.IsDoubleEmpty(credit))
      {
        throw new Exception("Invalid data");
      }

      this.person = person;
      this.accountNumber = GenerateAccountNumber();
      this.balance = balance;
      this.credit = credit;
    }

    private int GenerateAccountNumber()
    {
      Random random = new Random();
      return random.Next(1000, 9999);
    }

    public double GetBalance()
    {
      return this.balance;
    }

    public void Withdraw(double value)
    {
      if (this.balance - value < (this.credit * -1))
      {
        throw new Exception("Insufficient balance");
      }

      this.balance -= value;
    }

    public void Deposit(double value)
    {
      this.balance += value;
    }
  }
}