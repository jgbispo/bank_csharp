using System;

namespace Bank
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu menu = new Menu();
      Arrays ay = new Arrays();

      int option;
      do
      {
        option = menu.Start();

        switch (option)
        {
          case 1:
            menu.CreateAccount(ay);
            break;
          case 2:
            menu.ListAccounts(ay);
            break;
          case 3:
            menu.Deposit(ay);
            break;
          case 4:
            menu.Withdraw();
            break;
          case 5:
            menu.Transfer();
            break;
          case 6:
            menu.Exit();
            break;
          default:
            ScreenCommands.ClearScreen();
            Console.WriteLine("Invalid option");
            break;
        }

      } while (option != 6);
    }
  }
}