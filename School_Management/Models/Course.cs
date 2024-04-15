using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public float Credits { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}