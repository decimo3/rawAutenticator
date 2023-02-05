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
  private static string newUser()
  {
    string username, password = "";
    System.Console.Write("Escolha um nome de usuário: ");
    do
    {
      username = System.Console.ReadLine();
      if(Utility.formValidation.username(username))
      {
        if(Account.databaseAcess.exist("users", "username", username))
        {
          System.Console.Write("O nome de usuário escolhido já está sendo utilizado! Tente outro: ");
        }
        else break;
      }
      else System.Console.Write("O nome de usuário escolhido não é válido! Tente novamente: ");
    } while(true);
    do
    {
      System.Console.Write("digite uma senha para o seu usuário: ");
      password = System.Console.ReadLine();
      if(Utility.formValidation.password(password)) break;
      else
      {
        System.Console.Write("O senha escolhida não é válida! Tente novamente: ");
        password = System.Console.ReadLine();
      }
    } while(true);
    return Account.TokenManager.intokerize(Account.userDAO.insertUser(new Account.User(username, password, User.Role.Operational)));
  }
  private static string oldUser()
  {
    string username, password = "";
    System.Console.Write("Usuário: ");
    username = System.Console.ReadLine();
    do
    {
      if(Utility.formValidation.username(username))
      {
        if(!Account.databaseAcess.exist("users", "username", username))
        {
          System.Console.Write("O usuário informado não existe! Verifique e tente novamente! ");
          username = System.Console.ReadLine();
        }
        else break;
      }
      else
      {
        System.Console.Write("O nome de usuário digitado não é válido! Tente novamente: ");
        username = System.Console.ReadLine();
      } 
    } while(true);
    System.Console.Write("Senha: ");
    password = System.Console.ReadLine();
    do
    {
      if(Utility.formValidation.password(password))
      {
        return Account.TokenManager.intokerize(Account.userDAO.loginUser(username, password));
      }
      else
      {
        System.Console.Write("O senha digitada não é válida! Tente novamente: ");
        password = System.Console.ReadLine();
      }
    } while(true);
  }
}