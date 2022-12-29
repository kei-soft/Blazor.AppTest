using Blazor.AppTest.Common;

using System.ComponentModel.DataAnnotations;

namespace Blazor.AppTest.Data
{
    public class RequriedCheckModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }
        [Required]
        [Range(1, 100)]
        public int Age { get; set; }
        [ChangeableRequired]
        public string Introduction { get; set; }
        [Required]
        public Gender Gender { get; set; } = Gender.Male;
    }
}
