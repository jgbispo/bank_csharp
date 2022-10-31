namespace Bank
{
  class Account
  {
    private Person? person;
    private int accountNumber;
    private double balance;
    private double credit;

    public Account(Person person, double balance, double credit, int accountNumber)
    {
      if (VerifyEmpty.IsObjectEmpty(person) || VerifyEmpty.IsDoubleEmpty(balance) || VerifyEmpty.IsDoubleEmpty(credit) || VerifyEmpty.IsIntEmpty(accountNumber))
      {
        throw new Exception("Invalid data");
      }

      this.person = person;
      this.accountNumber = accountNumber;
      this.balance = balance;
      this.credit = credit;
    }


    public double GetBalance()
    {
      return this.balance;
    }

    public double GetCredit()
    {
      return this.credit;
    }

    public int GetAccountNumber()
    {
      return this.accountNumber;
    }

    public Person? GetPerson()
    {
      return this.person;
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

    public void PrintAccount()
    {
      Console.WriteLine("Account number: " + this.accountNumber);
      Console.WriteLine("Account balance: " + this.balance);
      Console.WriteLine("Account credit: " + this.credit);
      Console.WriteLine("Account owner: " + this.person!.GetName());
    }
  }
}