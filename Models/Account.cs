namespace Account;
public class Account
{
  private string userfolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
  public void ask ()
  {
    System.Console.WriteLine("");
  }
  public bool isLogin ()
  {
    return System.IO.File.Exists("~/.config/rawAutenticator");
  }
}