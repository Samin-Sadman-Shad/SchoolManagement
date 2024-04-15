using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime AdmissionDate { get; set; }

        /// <summary>
        /// Contains all the Enrollment Entity that is related to the Student Entity
        /// </summary>
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
