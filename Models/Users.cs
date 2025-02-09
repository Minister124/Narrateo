namespace Narrateo.Models;

public class Users
{
    public Guid Id {get; set;}
    public string? FullName {get; set;}
    public string? Username {get; set;}
    public string? Email {get; set;}
    public string? HashedPassword {get; set;}
    public Guid RoleId {get; set;}
    public Roles? Role {get; set;}
}
