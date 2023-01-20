/*
Classe para configuração de dotenv obtida na página
https://www.treinaweb.com.br/blog/utilizando-arquivos-dotenv-env-em-uma-aplicacao-asp-net-core
*/

namespace DotNetLoadDotEnv;

public static class DotEnv
{
  public static void Load(string filePath)
  {
    if (!System.IO.File.Exists(filePath)) return;
    foreach (var line in System.IO.File.ReadAllLines(filePath))
    {
      var parts = line.Split('=', System.StringSplitOptions.RemoveEmptyEntries);
      if (parts.Length != 2)
        continue;
      System.Environment.SetEnvironmentVariable(parts[0], parts[1]);
    }
  }

  public static void Load()
  {
    var appRoot = System.IO.Directory.GetCurrentDirectory();
    var dotEnv = System.IO.Path.Combine(appRoot, ".env");
    Load(dotEnv);
  }
}
