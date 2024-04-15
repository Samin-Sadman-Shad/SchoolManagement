using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentID { get; set; }

        [Required]
        public Student? Student { get; set; }

        public Grade? Grade { get; set; }

        [Required]
        public int CourseID { get; set; }

        [Required]
        public Course? Course { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}