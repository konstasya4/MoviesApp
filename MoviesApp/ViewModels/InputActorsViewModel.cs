using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;

namespace MoviesApp.ViewModels;

public class InputActorsViewModel
{
    [Required]
    [NameAttribute(4)]
    public string Name { get; set; }
    [Required]
    [NameAttribute(4)]
    public string Surname { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}