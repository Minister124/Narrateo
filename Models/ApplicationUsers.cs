using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Narrateo.Models;

public class ApplicationUsers : IdentityUser
{
    public string? FullName {get; set;}
    
}
