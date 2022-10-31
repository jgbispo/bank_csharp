using System;

namespace Bank
{
  class MenuController
  {
    public static void Account(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("List account");
      Account a = ay.GetAccountByNumber(ay.GetAccountNumber())!;
      a.PrintAccount();
      ScreenCommands.Pause();
    }

    public static void Deposit(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Deposit");
      Console.Write("Enter the value to deposit: ");
      double value = Convert.ToDouble(Console.ReadLine());
      AccountFeatures.Deposit(ay.GetAccountByNumber(ay.GetAccountNumber())!, value, ay);
    }

    public static void Withdraw(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Withdraw");
      Console.Write("Enter the value to withdraw: ");
      double value = Convert.ToDouble(Console.ReadLine());
      AccountFeatures.Withdraw(ay.GetAccountByNumber(ay.GetAccountNumber())!, value, ay);
    }

    public static void Transfer(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Transfer");
      Console.Write("Account number: ");
      int accountNumber = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the value to transfer: ");
      double value = Convert.ToDouble(Console.ReadLine());
      AccountFeatures.Transfer(ay.GetAccountByNumber(ay.GetAccountNumber())!, ay.GetAccountByNumber(accountNumber)!, value);
    }
  }
}