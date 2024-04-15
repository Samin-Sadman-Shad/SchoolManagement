using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public Student? Student { get; set; }

        public Grade? Grade { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public Course? Course { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}