namespace Bank
{
  class ScreenCommands
  {
    public static void ClearScreen()
    {
      Console.Clear();
    }

    public static void Pause()
    {
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }

    public static void PauseError()
    {
      Console.WriteLine("Press any key to try again...");
      Console.ReadKey();
    }
  }
}