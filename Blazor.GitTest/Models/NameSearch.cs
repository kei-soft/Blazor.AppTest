using System.ComponentModel.DataAnnotations;

namespace Blazor.GitTest.Models
{
    public class NameSearch
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
