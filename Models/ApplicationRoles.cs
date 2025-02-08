using System;
using Microsoft.AspNetCore.Identity;

namespace Narrateo.Models;

public class ApplicationRoles : IdentityRole
{
    public string? Description {get; set;}
}
