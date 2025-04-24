using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class ParentCreateDTO
    {
      

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;


        public string Address { get; set; } = string.Empty;


        public int PhoneNumber { get; set; }
    }
}
