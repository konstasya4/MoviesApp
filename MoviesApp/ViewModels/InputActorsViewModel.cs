using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;

namespace MoviesApp.ViewModels;

public class InputActorsViewModel
{
    [Required]
    [MinLength(4,ErrorMessage = "The length of the name can't be less than 4.")]
    public string Name { get; set; }
    [Required]
    [MinLength(4,ErrorMessage = "The length of the surname can't be less than 4.")]
    public string Surname { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [OldActor(1924, 2016)]
    public DateTime DateOfBirth { get; set; }
}