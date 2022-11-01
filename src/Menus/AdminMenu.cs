using System;

namespace Bank
{
  class AdminMenu
  {
    public static void Start(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Welcome to the bank - Administrator");
      Console.WriteLine("1 - Create Account");
      Console.WriteLine("2 - Remove Accounts");
      Console.WriteLine("3 - Edit Accounts");
      Console.WriteLine("4 - List Accounts");
      Console.WriteLine("5 - Exit");
      Console.Write("Choose an option: ");
      string? option = Console.ReadLine();
      ChooseOption(Convert.ToInt32(option), ay);
    }

    public static void ChooseOption(int option, Arrays ay)
    {
      ScreenCommands.ClearScreen();
      switch (option)
      {
        case 1:
          MenuControllerAdmin.CreateAccount(ay);
          break;
        case 2:
          MenuControllerAdmin.RemoveAccount(ay);
          break;
        case 3:
          MenuControllerAdmin.EditAccount(ay);
          break;
        case 4:
          MenuControllerAdmin.ListAccounts(ay);
          break;
        case 5:
          MenuControllerAdmin.Exit(ay);
          break;
        default:
          Console.WriteLine("Invalid option");
          ScreenCommands.PauseError();
          Start(ay);
          break;
      }
    }
  }
}