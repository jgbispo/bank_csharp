using System;

namespace Bank
{
  class AdminMenu
  {
    public static int Start(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Welcome to the bank - Administrator");
      Console.WriteLine("1 - Create Account");
      Console.WriteLine("2 - Remove Accounts");
      Console.WriteLine("3 - Edit Accounts");
      Console.WriteLine("4 - List Accounts");
      Console.WriteLine("6 - Back");
      Console.Write("Choose an option: ");
      string? option = Console.ReadLine();
      return Convert.ToInt32(option);
    }

    public static void CreateAccount(Arrays ay) { }

    public static void ListAccounts(Arrays ay) { }

    public static void ListAccount(Arrays ay) { }

    public static void Deposit(Arrays ay) { }

    public static void Withdraw(Arrays ay) { }

    public static void Transfer(Arrays ay) { }

    public static void Back() { }
  }
}