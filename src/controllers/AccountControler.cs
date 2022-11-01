namespace Bank
{
  class AccountFeatures
  {
    public static void Transfer(AccountEntity originAccount, AccountEntity destinationAccount, double value)
    {
      if (originAccount.GetBalance() < value)
      {
        throw new Exception("Insufficient balance");
      }

      originAccount.Withdraw(value);
      destinationAccount.Deposit(value);
    }

    public static void Withdraw(AccountEntity account, double value, Arrays ay)
    {
      if (account.GetBalance() < value)
      {
        throw new Exception("Insufficient balance");
      }

      account.Withdraw(value);
    }

    public static void Deposit(AccountEntity account, double value, Arrays ay)
    {
      account.Deposit(value);
    }

    public static void ShowBalance(AccountEntity account)
    {
      Console.WriteLine($"Current balance: {account.GetBalance()}");
    }
  }
}