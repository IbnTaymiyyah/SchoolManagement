using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class ClassUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string AcadmicYear { get; set; } = string.Empty;
    }
}
