using System;

namespace Bank
{
  class Access
  {
    public static bool IsCorrectPassword(int accountNumber, string password, Arrays ay)
    {
      Account account = ay.GetAccountByNumber(accountNumber)!;
      
      if (account.GetPassword() == password)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool IsAdmin(int accountNumber, Arrays ay)
    {
      Account account = ay.GetAccountByNumber(accountNumber)!;
      return account.IsAdmin();
    }
  }
}