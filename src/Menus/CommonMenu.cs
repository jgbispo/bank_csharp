using System;

namespace Bank
{
  class CommonMenu
  {
    public static int Start(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Welcome to the bank");
      Console.WriteLine("1 - Account");
      Console.WriteLine("2 - Deposit");
      Console.WriteLine("3 - Withdraw");
      Console.WriteLine("4 - Transfer");
      Console.WriteLine("6 - Exit");
      Console.Write("Choose an option: ");
      string? option = Console.ReadLine();
      return Convert.ToInt32(option);
    }

    public static void Account(Arrays ay)
    {
      MenuController.Account(ay);
    }

    public static void Deposit(Arrays ay)
    {
      MenuController.Deposit(ay);
    }

    public static void Withdraw(Arrays ay)
    {
      MenuController.Withdraw(ay);
    }

    public static void Transfer(Arrays ay)
    {
      MenuController.Transfer(ay);
    }

    public static void Exit()
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Thank you for using our services");
      ScreenCommands.Pause();
    }
  }
}