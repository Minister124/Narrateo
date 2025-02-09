
namespace Narrateo.Models;

public class Roles
{
    public Guid Id {get; set;}
    public string? Description {get; set;}

    public ICollection<Users>? Users {get; set;}
}
