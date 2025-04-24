using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class SubjectUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        
        public string Description { get; set; } = string.Empty;

        
    }
}
