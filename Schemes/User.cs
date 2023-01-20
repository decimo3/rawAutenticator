namespace Account;

public class User
{
  public string username {get; set;}
  public string password {get; set;}
  public Role role {get; set;} = Role.Operational;
  public User (string username, string password, Role role)
  {
    this.username = username;
    this.password = password;
    this.role = role;
  }
  public User (string username, string password)
  {
    this.username = username;
    this.password = password;
  }
  public User () {}
  public enum Role {Administrator, Manager, Operational}
}
