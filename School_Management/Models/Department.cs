﻿using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
