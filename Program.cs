namespace Program;

public static class Program
{
  public static void Main (string[] args)
  {
    DotNetLoadDotEnv.DotEnv.Load();
    Account.accountManager.init();
  }
}
