using System;
using System.ComponentModel.DataAnnotations;

namespace Narrateo.Models;

public class Login
{
    [Required]
    public string? UserName {get; set;}

    [Required]
    [DataType(DataType.Password)]
    public string? Password {get; set;}
}
