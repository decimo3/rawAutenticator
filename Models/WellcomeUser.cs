namespace Account;
public static class Wellcome
{
  public static Account.User autentication()
  {
    System.Console.WriteLine("Seja bem vindo ao rawAutenticator!");
    System.Console.WriteLine("O senhor já possui cadastro? [Y/N]");
    var regex = new System.Text.RegularExpressions.Regex("^[yYnNSs]$");
    var readkey = System.Console.ReadKey();
    while (Utility.formValidation.validateAnswer(readkey.Key.ToString()).Item1 == false)
    {
      System.Console.WriteLine("\nOpção inválida! Use 'Y' ou 'S' para iniciar um cadastro ou 'N' para logar! ");
      readkey = System.Console.ReadKey();
    }
    if(Utility.formValidation.validateAnswer(readkey.Key.ToString()).Item2 == true) return newUser();
    else return oldUser();
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