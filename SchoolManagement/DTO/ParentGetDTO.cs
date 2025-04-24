using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class ParentGetDTO
    {
        
        public int Id { get; set; }

        
        public string Name { get; set; } = string.Empty;

        
        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int PhoneNumber { get; set; }
    }
}
