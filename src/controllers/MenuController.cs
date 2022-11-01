using System;

namespace Bank
{
  class MenuController
  {
    public static void Account(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("List account");
      AccountEntity a = ay.GetAccountByNumber(ay.GetAccountNumber())!;
      a.PrintAccount();
      ScreenCommands.Pause();
      CommonMenu.Start(ay);
    }

    public static void Deposit(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Deposit");
      Console.Write("Enter the value to deposit: ");
      double value = Convert.ToDouble(Console.ReadLine());
      AccountFeatures.Deposit(ay.GetAccountByNumber(ay.GetAccountNumber())!, value, ay);
      CommonMenu.Start(ay);
    }

    public static void Withdraw(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Withdraw");
      Console.Write("Enter the value to withdraw: ");
      double value = Convert.ToDouble(Console.ReadLine());
      AccountFeatures.Withdraw(ay.GetAccountByNumber(ay.GetAccountNumber())!, value, ay);
      CommonMenu.Start(ay);
    }

    public static void ListAccount(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("List account");
      AccountEntity a = ay.GetAccountByNumber(ay.GetAccountNumber())!;
      a.PrintAccount();
      ScreenCommands.Pause();
      CommonMenu.Start(ay);
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
      ScreenCommands.Pause();
      CommonMenu.Start(ay);
    }
    public static void Exit(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Thank you for using our services");
      ScreenCommands.Pause();
      Program.Start(ay);
    }
  }
}