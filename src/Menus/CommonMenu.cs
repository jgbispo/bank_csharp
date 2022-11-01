using System;

namespace Bank
{
  class CommonMenu
  {
    public static void Start(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Welcome to the bank");
      Console.WriteLine("1 - Account");
      Console.WriteLine("2 - Deposit");
      Console.WriteLine("3 - Withdraw");
      Console.WriteLine("4 - Transfer");
      Console.WriteLine("5 - Exit");
      Console.Write("Choose an option: ");
      string? option = Console.ReadLine();
      ChooseOption(Convert.ToInt32(option), ay);
    }

    public static void ChooseOption(int option, Arrays ay)
    {
      ScreenCommands.ClearScreen();
      if (option == null)
      {
        Console.WriteLine("Invalid option");
        ScreenCommands.PauseError();
        Start(ay);
      }
      switch (option)
      {
        case 1:
          MenuController.ListAccount(ay);
          break;
        case 2:
          MenuController.Deposit(ay);
          break;
        case 3:
          MenuController.Withdraw(ay);
          break;
        case 4:
          MenuController.Transfer(ay);
          break;
        case 6:
          MenuController.Exit(ay);
          break;
        default:
          ScreenCommands.ClearScreen();
          Console.WriteLine("Invalid option");
          ScreenCommands.PauseError();
          break;
      }
    }



  }
}