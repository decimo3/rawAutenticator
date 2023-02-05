namespace Account;
public static class LocalManager
{
  private static string homepath()
  {
    string userfolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
    if (System.OperatingSystem.IsLinux()) return (userfolder + "/.config/rawAutenticator");
    if (System.OperatingSystem.IsWindows()) return (userfolder + "\\AppData\\Local\\rawAutenticator");
    throw new System.Exception("Sistema operacional não configurado!");
  }
  public static string recoverLocalToken()
  {
    if (System.IO.File.Exists(homepath()))
    {
      var token = System.IO.File.ReadAllText(homepath());
      return TokenManager.untokerize(token);
    }
    throw new System.Exception("Usuário não está logado localmente");
  }
  public static void saveLocalToken(string token)
  {
    System.IO.File.WriteAllText(homepath(), token);
  }
}