namespace Bank
{
  class Arrays
  {
    //Array of Persons
    private PersonEntity[] persons = new PersonEntity[100];
    //Array of Accounts
    private AccountEntity[] accounts = new AccountEntity[100];

    private int accountNumber;

    public Arrays()
    {
      AddAdmin();
    }

    public void AddPerson(PersonEntity person)
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

    public void SetAccountNumber(int accountNumber)
    {
      this.accountNumber = accountNumber;
    }

    public int GetAccountNumber()
    {
      return this.accountNumber;
    }

    public void AddAccount(AccountEntity account)
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

    public PersonEntity[] GetPersons()
    {
      return persons;
    }

    public AccountEntity[] GetAccounts()
    {
      return accounts;
    }

    public void EditAccount(int accountNumber, string accountPassword, double accountLimit)
    {
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] != null && accounts[i].GetAccountNumber() == accountNumber)
        {
          accounts[i].SetPassword(accountPassword);
          accounts[i].SetCredit(accountLimit);
          break;
        }
      }
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
          accounts[i].PrintAccount();
          Console.WriteLine();
        }
      }
    }

    public void PrintAccountsByPerson(PersonEntity person)
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

    public PersonEntity? GetPersonByDocument(string document)
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

    public AccountEntity? GetAccountByNumber(int accountNumber)
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

    public void RemoveAccount(int accountNumber)
    {
      for (int i = 0; i < accounts.Length; i++)
      {
        if (accounts[i] != null)
        {
          if (accounts[i].GetAccountNumber() == accountNumber)
          {
            accounts[i] = null!;
            break;
          }
        }
      }
    }

    public void RemovePerson(string document)
    {
      for (int i = 0; i < persons.Length; i++)
      {
        if (persons[i] != null)
        {
          if (persons[i].GetDocument() == document)
          {
            persons[i] = null!;
            break;
          }
        }
      }
    }
    public void UpdatePerson(PersonEntity person)
    {
      for (int i = 0; i < persons.Length; i++)
      {
        if (persons[i] != null)
        {
          if (persons[i].GetDocument() == person.GetDocument())
          {
            persons[i] = person;
            break;
          }
        }
      }
    }

    private void AddAdmin()
    {
      PersonEntity admin = new PersonEntity("Admin", "Rua do Admin", "3535", "admin@admin.com", "885522");
      AddPerson(admin);
      int accountNumber = GetNextAccountNumber();
      AccountEntity account = new AccountEntity(admin, 1000, 1000, accountNumber, "admin");
      account.AlterAdmin();
      AddAccount(account);
    }
  }
}