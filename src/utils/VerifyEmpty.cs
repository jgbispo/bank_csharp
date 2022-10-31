using System;

namespace Bank
{
  class VerifyEmpty
  {
    public static bool IsStringEmpty(string? value)
    {
      return string.IsNullOrEmpty(value);
    }

    public static bool IsIntEmpty(int value)
    {
      return value == 0;
    }

    public static bool IsDoubleEmpty(double value)
    {
      return value == 0;
    }

    public static bool IsObjectEmpty(object? value)
    {
      return value == null;
    }
  }
}