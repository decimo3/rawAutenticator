namespace Account;
public static class Wellcome
{
  public static string Authenticate()
  {
    System.Console.WriteLine("Seja bem vindo ao rawAutenticator!");
    System.Console.WriteLine("O senhor já possui cadastro? [Y/N]");
    var readkey = System.Console.ReadKey();
    while (Utility.formValidation.isValidadAnswer(readkey.Key.ToString()))
    {
      System.Console.WriteLine("\nOpção inválida! Use 'Y' ou 'S' para iniciar um cadastro ou 'N' para logar! ");
      readkey = System.Console.ReadKey();
    }
    System.Console.WriteLine();
    return (Utility.formValidation.isPositiveAnswer(readkey.Key.ToString())) ? newUser() : oldUser();
  }
  public static Account.User newUser()
  {
    try
    {
      Account.databaseAcess.insert("users", valores);
    }
    catch (Npgsql.PostgresException error)
    {
      System.Console.WriteLine(error.Message);
      System.Console.WriteLine(error.StackTrace);
    }
    catch (System.Exception error)
    {
      System.Console.WriteLine(error.Message);
      System.Console.WriteLine(error.StackTrace);
    }
  }
  public static Account.User oldUser() {}
}