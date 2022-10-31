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

    public static void AdminMenu(Arrays ay) { }

    public static void CreateAccount(Arrays ay)
    {
    }

    public static void ListAccounts(Arrays ay)
    {
    }

    public static void ListAccount(Arrays ay)
    {
    }

    public static void Deposit(Arrays ay)
    {

    }

    public static void Withdraw(Arrays ay)
    {
    }

    public static void Transfer(Arrays ay)
    {
    }

    public static void Exit()
    {
    }
  }
}