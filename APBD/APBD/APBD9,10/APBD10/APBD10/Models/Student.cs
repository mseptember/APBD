using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBD10.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }

        [Display(Name = "First Name"), StringLength(20, MinimumLength = 3), Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), StringLength(20, MinimumLength = 3), Required]
        public string LastName { get; set; }

        [StringLength(50), Required]
        public string Address { get; set; }

        [Display(Name = "Index Number"), RegularExpression(@"^s[0-9]{4,5}$", ErrorMessage ="The index number is not valid"), Required]
        public string IndexNumber { get; set; }

        [Display(Name = "Studies"), Range(1, int.MaxValue, ErrorMessage = "Please select studies")]
        public int IdStudies { get; set; }

        public virtual Studies Studies { get; set; }
    }
}
