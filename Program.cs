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
        option = Menu.Start();

        switch (option)
        {
          case 1:
            Menu.CreateAccount(ay);
            break;
          case 2:
            Menu.ListAccounts(ay);
            break;
          case 3:
            Menu.Deposit(ay);
            break;
          case 4:
            Menu.Withdraw(ay);
            break;
          case 5:
            Menu.Transfer(ay);
            break;
          case 6:
            Menu.Exit();
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