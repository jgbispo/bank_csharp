using System;

namespace Bank
{
  class Program
  {
    public static void Main()
    {
      Arrays ay = new Arrays();
      Start(ay);
    }

    public static void Start(Arrays ay)
    {
      // Login
      Console.WriteLine("Welcome to the bank");
      Console.Write("Type your account number: ");
      int accountNumber = Convert.ToInt32(Console.ReadLine());
      Console.Write("Type your password: ");
      string password = Console.ReadLine()!;

      // Check if the account exists and password is correct
      if (Access.IsCorrectPassword(accountNumber, password, ay))
      {
        if (Access.IsAdmin(accountNumber, ay))
        {
          ay.SetAccountNumber(accountNumber);
          AdminMenu.Start(ay);
        }
        else
        {
          ay.SetAccountNumber(accountNumber);
          CommonMenu.Start(ay);
        }
      }
      else
      {
        Console.WriteLine("Incorrect password");
      }
    }
  }
}