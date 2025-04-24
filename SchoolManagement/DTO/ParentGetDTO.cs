using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class ParentGetDTO
    {
        
        public int Id { get; set; }

        
        public string Name { get; set; } 

        
        public string Email { get; set; } 

        public string Address { get; set; } 

        public int PhoneNumber { get; set; }
    }
}
