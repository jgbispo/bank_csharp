namespace Bank
{
  class Arrays
  {
    //Array of Persons
    private Person[] persons = new Person[100];
    //Array of Accounts
    private Account[] accounts = new Account[100];

    public void AddPerson(Person person)
    {
      for (int i = 0; i < persons.Length; i++)
      {
        if (persons[i] == null)
        {
          persons[i] = person;
          break;
        }
      }
    }

    public void AddAccount(Account account)
    {
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] == null)
        {
          accounts[i] = account;
          break;
        }
      }
    }

    public Person[] GetPersons()
    {
      return persons;
    }

    public Account[] GetAccounts()
    {
      return accounts;
    }

    public void PrintPersons()
    {
      for (int i = 0; i < persons.Length; i++)
      {
        if (persons[i] != null)
        {
          Console.WriteLine("Name: " + persons[i].GetName());
          Console.WriteLine("Address: " + persons[i].GetAddress());
          Console.WriteLine("Phone: " + persons[i].GetPhone());
          Console.WriteLine("Email: " + persons[i].GetEmail());
          Console.WriteLine("Document: " + persons[i].GetDocument());
          Console.WriteLine();
        }
      }
    }

    public void PrintAccounts()
    {
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] != null)
        {
          Console.WriteLine("Account number: " + accounts[i].GetAccountNumber());
          Console.WriteLine("Account balance: " + accounts[i].GetBalance());
          Console.WriteLine("Account credit: " + accounts[i].GetCredit());
          Console.WriteLine("Account owner: " + accounts[i].GetPerson()!.GetName());
          Console.WriteLine();
        }
      }
    }

    public void PrintAccountsByPerson(Person person)
    {
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] != null)
        {
          if (accounts[i].GetPerson() == person)
          {
            Console.WriteLine("Account number: " + accounts[i].GetAccountNumber());
            Console.WriteLine("Account balance: " + accounts[i].GetBalance());
            Console.WriteLine("Account credit: " + accounts[i].GetCredit());
            Console.WriteLine("Account owner: " + accounts[i].GetPerson()!.GetName());
            Console.WriteLine();
          }
        }
      }
    }

    public Person? GetPersonByDocument(string document)
    {
      for (int i = 0; i < persons.Length; i++)
      {
        if (persons[i] != null)
        {
          if (persons[i].GetDocument() == document)
          {
            return persons[i];
          }
        }
      }
      throw new Exception("Person not exists");
    }

    public Account? GetAccountByNumber(int accountNumber)
    {
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] != null)
        {
          if (accounts[i].GetAccountNumber() == accountNumber)
          {
            return accounts[i];
          }
        }
      }
      throw new Exception("Account not exists");
    }

    public void VerifyAccountNumber(int accountNumber)
    {
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] != null)
        {
          if (accounts[i].GetAccountNumber() == accountNumber)
          {
            throw new Exception("Account number already exists");
          }
        }
      }
    }

    public void VerifyPersonDocument(string document)
    {
      for (int i = 0; i < persons.Length; i++)
      {
        if (persons[i] != null)
        {
          if (persons[i].GetDocument() == document)
          {
            throw new Exception("Document already exists");
          }
        }
      }
    }

    public int GetNextAccountNumber()
    {
      int nextAccountNumber = 0;
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] != null)
        {
          if (accounts[i].GetAccountNumber() > nextAccountNumber)
          {
            nextAccountNumber = accounts[i].GetAccountNumber();
          }
        }
      }
      return nextAccountNumber + 1;
    }
  }
}