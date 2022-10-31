using System;

namespace Bank
{
  class Menu
  {
    public int Start()
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Welcome to the bank");
      Console.WriteLine("1 - Create account");
      Console.WriteLine("2 - List accounts");
      Console.WriteLine("3 - Deposit");
      Console.WriteLine("4 - Withdraw");
      Console.WriteLine("5 - Transfer");
      Console.WriteLine("6 - Exit");
      Console.Write("Choose an option: ");
      string? option = Console.ReadLine();
      return Convert.ToInt32(option);
    }

    public void CreateAccount(Arrays a)
    {
      MenuFeatures mf = new MenuFeatures();
      ScreenCommands.ClearScreen();
      Console.WriteLine("Create account");
      mf.CreateAccount(a);
    }

    public void ListAccounts(Arrays ay)
    {
      MenuFeatures mf = new MenuFeatures();
      ScreenCommands.ClearScreen();
      Console.WriteLine("List accounts");
      mf.ListAccounts(ay);
    }

    public void Deposit(Arrays ay)
    {
      AccountFeatures af = new AccountFeatures();
      ScreenCommands.ClearScreen();
      Console.WriteLine("Deposit");
      Console.Write("Account number: ");
      int accountNumber = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the value to deposit: ");
      double value = Convert.ToDouble(Console.ReadLine());
      af.Deposit(accountNumber, value, ay);     
    }

    public void Withdraw()
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Withdraw");
    }

    public void Transfer()
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Transfer");
    }

    public void Exit()
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Thank you for using our services");
    }
  }
}