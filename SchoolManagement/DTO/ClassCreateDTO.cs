using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class ClassCreateDTO
    {
    

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string AcadmicYear { get; set; } = string.Empty;
    }
}
