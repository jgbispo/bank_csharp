namespace Bank
{
  class AccountEntity
  {
    private PersonEntity person;
    private int accountNumber;
    private double balance;
    private double credit;
    private string password;
    private bool isAdmin = false;

    public AccountEntity(PersonEntity person, double balance, double credit, int accountNumber, string password)
    {
      if (VerifyEmpty.IsObjectEmpty(person) || VerifyEmpty.IsDoubleEmpty(balance) || VerifyEmpty.IsDoubleEmpty(credit) || VerifyEmpty.IsStringEmpty(password) || VerifyEmpty.IsIntEmpty(accountNumber))
      {
        throw new Exception("Invalid data");
      }

      this.person = person;
      this.accountNumber = accountNumber;
      this.balance = balance;
      this.credit = credit;
      this.password = password;
    }

    public Boolean IsAdmin()
    {
      return this.isAdmin;
    }

    public void AlterAdmin()
    {
      this.isAdmin = !isAdmin;
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

    public PersonEntity GetPerson()
    {
      return this.person;
    }


    public string GetPassword()
    {
      return this.password;
    }

    public void SetPassword(string password)
    {
      this.password = password;
    }

    public void SetCredit(double credit)
    {
      this.credit = credit;
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
      Console.WriteLine("Account owner: " + this.person!.GetName());
      Console.WriteLine("Account balance: " + this.balance);
      Console.WriteLine("Account credit: " + this.credit);
      Console.WriteLine("Account owner document: " + this.person!.GetDocument());
      Console.WriteLine("Account admin: " + this.isAdmin);
      Console.WriteLine();
    }
  }
}