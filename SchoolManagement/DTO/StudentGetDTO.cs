using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.DTO
{
    public class StudentGetDTO
    {
    
        public int Id { get; set; }

       
        public string Name { get; set; } 

    
        public string Gender { get; set; } 


        public string Address { get; set; } 


        public int PhoneNumber { get; set; }
    }
}
