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

    public static void Withdraw(Account account, double value, Arrays ay)
    {
      if (account.GetBalance() < value)
      {
        throw new Exception("Insufficient balance");
      }

      account.Withdraw(value);
    }

    public static void Deposit(Account account, double value, Arrays ay)
    {
      account.Deposit(value);
    }

    public static void ShowBalance(Account account)
    {
      Console.WriteLine($"Current balance: {account.GetBalance()}");
    }
  }
}