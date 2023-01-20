namespace Program;

public static class Program
{
  public static void Main (string[] args)
  {
    DotNetLoadDotEnv.DotEnv.Load();
    var conta = new Account.accountManager();
    var usuario = new Account.User("Ruan", "palavra", Account.User.Role.Operational);
    var token = Account.TokenManager.intokerize(usuario);
    System.Console.WriteLine(token);
    var json = Account.TokenManager.untokerize(token);
    System.Console.WriteLine(json);
    System.Console.WriteLine(Account.databaseAcess.insert("INSERT INTO teste VALUES (DEFAULT, 'Ruan');"));
  }
}
