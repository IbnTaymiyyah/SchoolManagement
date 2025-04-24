using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class TeacherGetDTO
    {
        
        public int Id { get; set; }

        
        public string Name { get; set; } 

       
        public string Gender { get; set; }

        
        public string Email { get; set; }

        public string Address { get; set; } 
    }
}
