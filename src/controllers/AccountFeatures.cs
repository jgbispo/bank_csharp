namespace Bank
{
  class AccountFeatures
  {
    public static void Transfer(Account originAccount, Account destinationAccount, double value)
    {
      if (originAccount.GetBalance() < value)
      {
        throw new Exception("Insufficient balance");
      }

      originAccount.Withdraw(value);
      destinationAccount.Deposit(value);
    }

    public static void Withdraw(Account account, double value)
    {
      if (account.GetBalance() < value)
      {
        throw new Exception("Insufficient balance");
      }

      account.Withdraw(value);
    }

    public void Deposit(int accountNumber, double value, Arrays ay)
    {
      try
      {
        Account account = ay.GetAccountByNumber(accountNumber)!;
        account.Deposit(value);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    public static void ShowBalance(Account account)
    {
      Console.WriteLine($"Current balance: {account.GetBalance()}");
    }
  }
}