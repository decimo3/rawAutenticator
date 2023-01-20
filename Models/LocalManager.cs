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
  public static void isLogin()
  {
    if (System.IO.File.Exists(homepath()))
    {
      var token = System.IO.File.ReadAllText(homepath());
      var json = TokenManager.untokerize(token);
      try
      {
        
      }
      catch
      {

      }
    }
    throw new System.Exception("Usuário não está logado localmente");
  }
}