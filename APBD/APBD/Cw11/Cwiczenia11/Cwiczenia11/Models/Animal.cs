using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Animal
    {
        [Key]
        public int IdAnimal { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        public int Age { get; set; }

        [MaxLength(150)]
        public string Owner { get; set; }

        
        public int IdAnimalType { get; set; }
    }
}
