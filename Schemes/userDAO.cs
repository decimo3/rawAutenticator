namespace Account;
public static class userDAO
{
  // C.R.U.D. para o objeto Account.User
  public static Account.User insertUser(Account.User user)
  {
    if (Account.databaseAcess.exist("users", "username", user.username)) throw new System.Exception("Usuário já existe no banco de dados!");
    string[] values = {user.username, user.password, user.role.ToString()};
    Account.databaseAcess.insert("users", values);
    return user;
  }
  public static User returnUser(string user)
  {
    if (!Account.databaseAcess.exist("users", "username", user)) throw new System.Exception("Usuário não existe no banco de dados!");
    var userDic = Account.databaseAcess.recover("users", "username", user);
    return new Account.User();
  }
}
