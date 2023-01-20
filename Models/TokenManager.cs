namespace Account;
public static class TokenManager
{
  public static string intokerize (User user)
  {
    string secret = System.Environment.GetEnvironmentVariable("SECRET");
    return new JWT.Builder.JwtBuilder()
      .WithAlgorithm(new JWT.Algorithms.HMACSHA256Algorithm())
      .WithSecret(System.Text.Encoding.UTF8.GetBytes(secret))
      .AddClaim("exp", System.DateTimeOffset.UtcNow.AddHours(7).ToUnixTimeSeconds())
      .AddClaim("user", user.username)
      .AddClaim("role", user.role)
      .Encode();
  }
  public static string untokerize (string token)
  {
    string secret = System.Environment.GetEnvironmentVariable("SECRET");
    return new JWT.Builder.JwtBuilder()
      .WithAlgorithm(new JWT.Algorithms.HMACSHA256Algorithm())
      .WithSecret(System.Text.Encoding.UTF8.GetBytes(secret))
      .MustVerifySignature()
      .Decode(token);
  }
}