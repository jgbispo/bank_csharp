using System;

namespace Bank
{
  class Program
  {
    static void Main(string[] args)
    {
      Arrays ay = new Arrays();
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
          AdminMenu.Start(ay);
        }
        else
        {
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