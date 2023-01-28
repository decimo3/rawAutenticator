namespace Account;
public static class userDAO
{
  public static User insertUser(Account.User user)
  {
    if (Account.databaseAcess.exist("users", "username", user.username)) throw new System.Exception("Usuário já existe no banco de dados!");
    return user;
  }
  public static User returnUser(string user)
  {
    if (!Account.databaseAcess.exist("users", "username", user)) throw new System.Exception("Usuário não existe no banco de dados!");
    var userDic = Account.databaseAcess.recover("users", "username", user);
    return new Account.User();
  }
}
