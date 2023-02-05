namespace Account;
public static class databaseAcess
{
  private static string connectionString = "Host=localhost;Username=usuario;Password=123456789;Database=aplicacao";
  public static bool insert(string table, string[] values)
  {
    using(var connection = new Npgsql.NpgsqlConnection())
    {
      connection.ConnectionString = connectionString;
      connection.Open();
      System.Console.WriteLine("Connection OK from 'insert'!");
      using (var command = new Npgsql.NpgsqlCommand())
      {
        command.Connection = connection;
        var sqlValues = new System.Text.StringBuilder();
        foreach (string valor in values)
        {
          sqlValues.Append($", '{@valor}'");
        }
        command.CommandText = $"INSERT INTO \"{@table}\" VALUES (DEFAULT{@sqlValues})";
        System.Console.WriteLine(command.CommandText);
        command.ExecuteNonQuery();
      }
      if (connection.State == System.Data.ConnectionState.Open) connection.Close();
      return true;
    }
  }
  public static bool exist(string table, string field, string word)
  {
    Npgsql.NpgsqlDataReader results;
    using(var connection = new Npgsql.NpgsqlConnection())
    {
      connection.ConnectionString = connectionString;
      connection.Open();
      System.Console.WriteLine("Connection OK from 'exist'!");
      using (var command = new Npgsql.NpgsqlCommand())
      {
        command.Connection = connection;
        command.CommandText = $"SELECT {@field} FROM \"{@table}\" WHERE {@field} = '{@word}'";
        using(var results = command.ExecuteReader(System.Data.CommandBehavior.Default))
        {
          return results.HasRows;
        }
      }
    }
  }
  public static System.Collections.Generic.Dictionary<string, object> recover(string table, string field, string word)
  {
    var linha = new System.Collections.Generic.Dictionary<string, object>();
    using(var connection = new Npgsql.NpgsqlConnection())
    {
      Npgsql.NpgsqlDataReader result;
      connection.ConnectionString = connectionString;
      connection.Open();
      System.Console.WriteLine("Connection OK from 'recover'!");
      
      using (var command = new Npgsql.NpgsqlCommand())
      {
        command.Connection = connection;
        command.CommandText = $"SELECT * FROM \"{@table}\" WHERE {@field} = '{@word}'";
        result = command.ExecuteReader();
        
        for (int i = 0; i < result.FieldCount; i++)
        {
          linha.Add(result.GetName(i), result.GetValue(i));
          System.Console.WriteLine(result.GetValue(i));
        }
      }
      if (connection.State == System.Data.ConnectionState.Open) connection.Close();
    }
    return linha;
  }
}