using System;
using System.ComponentModel.DataAnnotations;

namespace Narrateo.Models;

public class Blog
{
    [Required]
    public Guid Id {get; set;}
    public List<string>? Image {get; set;}
    public string? Title {get; set;}
    public string? Content {get; set;}
    public string? Author {get; set;}
    public DateTime CreatedAt {get; set;}
}
