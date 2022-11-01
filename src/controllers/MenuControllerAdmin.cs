using System;

namespace Bank
{
  class MenuControllerAdmin
  {
    public static void CreateAccount(Arrays ay)
    {
      Console.WriteLine("Create account");

      // Create Person
      Console.WriteLine("1) Create Person");
      Console.WriteLine("Type the account owner name: ");
      string ownerName = Console.ReadLine()!;
      Console.WriteLine("Type the account owner document: ");
      string ownerDocument = Console.ReadLine()!;
      Console.WriteLine("Type the account owner address: ");
      string ownerAddress = Console.ReadLine()!;
      Console.WriteLine("Type the account owner phone number: ");
      string ownerPhoneNumber = Console.ReadLine()!;
      Console.WriteLine("Type the account owner email: ");
      string ownerEmail = Console.ReadLine()!;
      PersonEntity p = new PersonEntity(ownerName, ownerDocument, ownerAddress, ownerPhoneNumber, ownerEmail);

      ScreenCommands.ClearScreen();

      // Create Account
      Console.WriteLine("2) Create Account");
      int accountNumber = ay.GetNextAccountNumber();
      Console.WriteLine("Account number: " + accountNumber);
      Console.WriteLine("Type the account balance: ");
      string accountBalance = Console.ReadLine()!;
      Console.WriteLine("Type the account credit: ");
      string accountLimit = Console.ReadLine()!;
      Console.WriteLine("Type the account password: ");
      string accountPassword = Console.ReadLine()!;
      AccountEntity a = new AccountEntity(p, Convert.ToDouble(accountBalance), Convert.ToDouble(accountLimit), accountNumber, accountPassword);

      // Add Account to Arrays
      ay.AddAccount(a);
      ScreenCommands.ClearScreen();
      Console.WriteLine("Account created successfully");
      ScreenCommands.Pause();
      AdminMenu.Start(ay);
    }

    public static void RemoveAccount(Arrays ay)
    {
      Console.WriteLine("Remove account");
      Console.WriteLine("Type the account number: ");
      string accountNumber = Console.ReadLine()!;
      ay.RemoveAccount(Convert.ToInt32(accountNumber));
      AdminMenu.Start(ay);
    }

    public static void EditAccount(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Edit account");
      Console.WriteLine("Type the account number: ");
      string accountNumber = Console.ReadLine()!;
      AccountEntity account = ay.GetAccountByNumber(Convert.ToInt32(accountNumber))!;

      Console.WriteLine("Type the account name: ");
      string accountName = Console.ReadLine()!;
      if (accountName == null)
      {
        accountName = account.GetPerson().GetName();
      }

      Console.WriteLine("Type the account password: ");
      string accountPassword = Console.ReadLine()!;
      if (accountPassword == null)
      {
        accountPassword = account.GetPassword();
      }

      Console.WriteLine("Type the account credit: ");
      string accountLimit = Console.ReadLine()!;
      if (accountLimit == null)
      {
        accountLimit = Convert.ToString(account.GetCredit());
      }
      ay.EditAccount(Convert.ToInt32(accountNumber), accountPassword, Convert.ToDouble(accountLimit));
      AdminMenu.Start(ay);
    }

    public static void ListAccounts(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("List accounts");
      ay.PrintAccounts();
      ScreenCommands.Pause();
      AdminMenu.Start(ay);
    }

    public static void Exit(Arrays ay)
    {
      ScreenCommands.ClearScreen();
      Console.WriteLine("Thank you for using our services");
      ScreenCommands.Pause();
      Program.Start(ay);
    }
  }
}