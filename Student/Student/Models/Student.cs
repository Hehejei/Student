using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Student
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MiddleName { get; set; }
        public string Nick { get; set; }
    }
}
