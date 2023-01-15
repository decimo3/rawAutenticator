namespace Account;
using Npgsql;

public class userDAO
{
  private NpgsqlConnection connection;
  private string connectionString = "Host=localhost;Username=usuario;Password=123456789;Database=aplicacao";
  public void conectDatabase()
  {
    connection = new NpgsqlConnection(connectionString);
    try
    {
      connection.Open();
    }
    catch(NpgsqlException error)
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
  public bool isConnectedDatabase()
  {
    return (connection.State == System.Data.ConnectionState.Open);
  }
  public void closeConnectionDatabase()
  {
    if (connection.State == System.Data.ConnectionState.Open) connection.Close();
  }
  /*
  public int existsUser (string username);
  public int insertUser (User user);
  public int loginUser (User user);
  */
}
