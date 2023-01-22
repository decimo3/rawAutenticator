namespace Account;

public class UserJWT
{
  public long exp {get; set;}
  public string user {get; set;}
  public Role role {get; set;} = Role.Operational;
  public enum Role {Administrator, Manager, Operational}
}
