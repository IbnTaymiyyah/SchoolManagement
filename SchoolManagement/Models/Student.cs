using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender {  get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        // Foreign Keys

        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public Parent Parent { get; set; } 
        
        
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; } 

    }
}
