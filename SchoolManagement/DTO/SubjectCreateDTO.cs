using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class SubjectCreateDTO
    {
       

        [Required]
        public string Name { get; set; } = string.Empty;


        public string Description { get; set; } = string.Empty;
    }
}
