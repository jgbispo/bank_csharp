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

    public void CreateAccount(Arrays ay)
    {
      try
      {
        MenuFeatures mf = new MenuFeatures();
        ScreenCommands.ClearScreen();
        Console.WriteLine("Create account");
        mf.CreateAccount(ay);
      }
      catch (Exception e)
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine(e.Message);
        ScreenCommands.PauseError();
        Menu m = new Menu();
        m.CreateAccount(ay);
      }
    }

    public void ListAccounts(Arrays ay)
    {
      try
      {
        MenuFeatures mf = new MenuFeatures();
        ScreenCommands.ClearScreen();
        Console.WriteLine("List accounts");
        mf.ListAccounts(ay);
      }
      catch (Exception e)
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine(e.Message);
        ScreenCommands.PauseError();
        Menu m = new Menu();
        m.ListAccounts(ay);
      }
    }

    public void Deposit(Arrays ay)
    {
      try
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine("Deposit");
        Console.Write("Account number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value to deposit: ");
        double value = Convert.ToDouble(Console.ReadLine());
        AccountFeatures.Deposit(ay.GetAccountByNumber(accountNumber)!, value, ay);
      }
      catch (Exception e)
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine(e.Message);
        ScreenCommands.PauseError();
        Menu m = new Menu();
        m.Deposit(ay);
      }
    }

    public void Withdraw(Arrays ay)
    {
      try
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine("Withdraw");
        Console.Write("Account number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value to withdraw: ");
        double value = Convert.ToDouble(Console.ReadLine());
        AccountFeatures.Withdraw(ay.GetAccountByNumber(accountNumber)!, value, ay);
      }
      catch (Exception e)
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine(e.Message);
        ScreenCommands.PauseError();
        Menu m = new Menu();
        m.Withdraw(ay);
      }
    }

    public void Transfer(Arrays ay)
    {
      try
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine("Transfer");
        Console.Write("Origin account number: ");
        int originAccountNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Destination account number: ");
        int destinationAccountNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value to transfer: ");
        double value = Convert.ToDouble(Console.ReadLine());
        AccountFeatures.Transfer(ay.GetAccountByNumber(originAccountNumber)!, ay.GetAccountByNumber(destinationAccountNumber)!, value);
      }
      catch (Exception e)
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine(e.Message);
        ScreenCommands.PauseError();
        Menu m = new Menu();
        m.Transfer(ay);
      }
    }

    public void Exit()
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Thank you for using our services");
    }
  }
}