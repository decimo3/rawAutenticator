namespace Program;
using DotNetLoadDotEnv;
using Account;
public static class Program
{
  public static void Main (string[] args)
  {
    DotEnv.Load();
    var db = new userDAO();
    db.conectDatabase();
    if (db.isConnectedDatabase())
    {
      System.Console.WriteLine("Connection OK!");
    }
    else
    {
      System.Console.WriteLine("Connection fail!");
    }
    db.closeConnectionDatabase();
  }
}
