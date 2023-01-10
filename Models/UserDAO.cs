namespace userDAO;
using MySql.Data.MySqlClient;
using User;

public class userDAO
{
  private MySqlConnection connection;
  // private MySqlDataAdapter cursor;
  private string connectionString = "Persist Security Info=False;server=localhost;database=aplication;uid=usuario;pwd=123456789";
  public void conectDatabase()
  {
    connection = new MySqlConnection(connectionString);
    try
    {
      connection.Open();
    }
    catch(System.Exception error)
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
