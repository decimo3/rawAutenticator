namespace Account;
public static class databaseAcess
{
  public static string connectionString()
  {
    return "Host=localhost;Username=usuario;Password=123456789;Database=aplicacao";
  }
  public static int insert(string query)
  {
    using(var connection = new Npgsql.NpgsqlConnection())
    {
      try
      {
        connection.ConnectionString = connectionString();
        connection.Open();
        System.Console.WriteLine("Connection OK!");
        using (var command = new Npgsql.NpgsqlCommand())
        {
          command.Connection = connection;
          command.CommandText = @query;
          return command.ExecuteNonQuery();
        }
      }
      catch(Npgsql.NpgsqlException error)
      {
        System.Console.WriteLine("Connection fail!");
        System.Console.WriteLine(error.Message);
        System.Console.WriteLine(error.StackTrace);
        return 0;
      }
      catch (System.Exception error)
      {
        System.Console.WriteLine("Connection fail!");
        System.Console.WriteLine(error.Message);
        System.Console.WriteLine(error.StackTrace);
        return 0;
      }
      finally
      {
        if (connection.State == System.Data.ConnectionState.Open) connection.Close();
      }
    }
  }
  public static void search(string query)
  {
    using(var connection = new Npgsql.NpgsqlConnection(connectionString()))
    {
      try
      {
        connection.Open();
        System.Console.WriteLine("Connection OK!");
      }
      catch(Npgsql.NpgsqlException error)
      {
        System.Console.WriteLine("Connection fail!");
        System.Console.WriteLine(error.Message);
        System.Console.WriteLine(error.StackTrace);
      }
      catch (System.Exception error)
      {
        System.Console.WriteLine("Connection fail!");
        System.Console.WriteLine(error.Message);
        System.Console.WriteLine(error.StackTrace);
      }
      finally
      {
        if (connection.State == System.Data.ConnectionState.Open) connection.Close();
      }
    }
  }
}