using System.ComponentModel.DataAnnotations;

using Blazor.AppTest.Data;

public class ExampleModel
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }
    [Required]
    public int? Age { get; set; }
    public Gender Gender { get; set; } = Gender.Male;
}