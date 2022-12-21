using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.ViewModels;

public class InputActorsViewModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}