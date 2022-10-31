using System;

namespace Bank
{
  class MenuFeatures
  {
    public static void CreateNewAccount(Arrays ay)
    {
      Person p = CreatePerson();
      Account a = CreateAccount(ay, p);

      Console.WriteLine("Check that the data is correct");
      Console.WriteLine("1 - Yes");
      Console.WriteLine("2 - No");
      Console.Write("Choose an option: ");
      int option = Convert.ToInt32(Console.ReadLine());
      if (option == 1)
      {
        try
        {
          ay.AddAccount(a);
          ay.AddPerson(p);
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }

        ScreenCommands.ClearScreen();
        Console.WriteLine("Account created successfully");
        ScreenCommands.Pause();
        Menu.Start();
      }
      else
      {
        ScreenCommands.ClearScreen();
        Console.WriteLine("Account creation canceled");
        ScreenCommands.Pause();
        ScreenCommands.ClearScreen();
        Menu.Start();
      }
    }

    public static Account CreateAccount(Arrays ay, Person p)
    {
      Console.WriteLine("Type the account balance: ");
      double accountBalance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Type the account credit: ");
      double accountCredit = Convert.ToDouble(Console.ReadLine());

      int accountNumber = ay.GetNextAccountNumber();
      Console.WriteLine($"The account number is {accountNumber} ");
      Account a = new Account(p, accountBalance, accountCredit, accountNumber);
      ScreenCommands.ClearScreen();
      a.PrintAccount();
      ScreenCommands.Pause();
      return a;
    }

    public static Person CreatePerson()
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Create Person");
      Console.WriteLine("Type the account owner name: ");
      string? ownerName = Console.ReadLine();
      Console.WriteLine("Type the account owner document: ");
      string? ownerDocument = Console.ReadLine();
      Console.WriteLine("Type the account owner address: ");
      string? ownerAddress = Console.ReadLine();
      Console.WriteLine("Type the account owner phone number: ");
      string? ownerPhoneNumber = Console.ReadLine();
      Console.WriteLine("Type the account owner email: ");
      string? ownerEmail = Console.ReadLine();

      Person p = new Person(ownerName!, ownerAddress!, ownerPhoneNumber!, ownerEmail!, ownerDocument!);
      ScreenCommands.ClearScreen();
      p.PrintPerson();
      ScreenCommands.Pause();
      return p;
    }

    public static void ListAccounts(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("List accounts");
      ay.PrintAccounts();
      ScreenCommands.Pause();
    }
  }
}