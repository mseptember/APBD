using System;
using System.Collections.Generic;

namespace APBD10.Models
{
    public partial class Studies
    {
        public Studies()
        {
            Student = new HashSet<Student>();
        }

        public int IdStudies { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
