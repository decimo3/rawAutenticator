namespace Account;
public static class TokenManager
{
  private static string secret = System.Environment.GetEnvironmentVariable("SECRET");
  public static string intokerize (User user)
  {
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
    return new JWT.Builder.JwtBuilder()
      .WithAlgorithm(new JWT.Algorithms.HMACSHA256Algorithm())
      .WithSecret(System.Text.Encoding.UTF8.GetBytes(secret))
      .MustVerifySignature()
      .Decode(token);
  }
}