using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
    }
}
