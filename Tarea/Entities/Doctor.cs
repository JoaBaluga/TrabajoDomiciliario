using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class Doctor
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Specialties Specialty { get; set; }

        public virtual ICollection<Hospital> Hospitals { get; set; }
    }
}
