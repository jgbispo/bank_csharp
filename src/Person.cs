namespace Bank
{
  class Person
  {
    private string? Name;
    private string? Address;
    private string? Phone;
    private string? Email;
    private int cpf;

    Person(string name, string address, string phone, string email, int cpf)
    {
      if (VerifyEmpty.IsStringEmpty(name) || VerifyEmpty.IsStringEmpty(address) || VerifyEmpty.IsStringEmpty(phone) || VerifyEmpty.IsStringEmpty(email) || VerifyEmpty.IsIntEmpty(cpf))
      {
        throw new Exception("Invalid data");
      }

      this.Name = name;
      this.Address = address;
      this.Phone = phone;
      this.Email = email;
      this.cpf = cpf;
    }

    public string? GetName()
    {
      return this.Name;
    }

    public string? GetAddress()
    {
      return this.Address;
    }

    public string? GetPhone()
    {
      return this.Phone;
    }

    public string? GetEmail()
    {
      return this.Email;
    }

    public int GetCpf()
    {
      return this.cpf;
    }

    public void SetName(string name)
    {
      this.Name = name;
    }

    public void SetAddress(string address)
    {
      this.Address = address;
    }

    public void SetPhone(string phone)
    {
      this.Phone = phone;
    }

    public void SetEmail(string email)
    {
      this.Email = email;
    }

    public void SetCpf(int cpf)
    {
      this.cpf = cpf;
    }

    public void PrintPerson()
    {
      Console.WriteLine("Name: " + this.Name);
      Console.WriteLine("Address: " + this.Address);
      Console.WriteLine("Phone: " + this.Phone);
      Console.WriteLine("Email: " + this.Email);
      Console.WriteLine("CPF: " + this.cpf);
    }
  }
}