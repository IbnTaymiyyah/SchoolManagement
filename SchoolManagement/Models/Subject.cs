using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement.Models
{
    public class Subject
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Foreign Keys

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
