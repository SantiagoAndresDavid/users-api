namespace Entites;

public class User : Person
{
    public required string Password { get; set; }
    public required string UserName { get; set; }
}
