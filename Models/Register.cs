using System.ComponentModel.DataAnnotations;

namespace Narrateo.Models;

public class Register
{
    [Required]
    public string? FullName {get; set;}

    [Required]
    public string? Username {get; set;}

    [Required]
    [EmailAddress]
    public string? EmailAddress {get; set;}

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8)]
    public string? Password {get; set;}

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string? ConfirmPassword {get; set;}
}