namespace Account;
public static class accountManager
{
  public static void init()
  {
    try
    {
      string token = Account.LocalManager.recoverLocalToken();
      Account.UserJWT json = System.Text.Json.JsonSerializer.Deserialize<Account.UserJWT>(token);
      Account.User user = Account.userDAO.returnUser(json.user);
    }
    catch (System.Exception)
    {
      Account.Wellcome.autentication();
    }
  }
}