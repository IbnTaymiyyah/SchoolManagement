using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class TeacherUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Gender { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;


        public string Address { get; set; } = string.Empty;

    }
}
