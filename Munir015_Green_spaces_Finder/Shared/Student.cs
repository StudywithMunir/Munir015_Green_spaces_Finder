using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munir015_Green_spaces_Finder.Shared
{

    //Quiz Model
    public class Student
    {
        [Key]
        public int sid { get; set; }
        public string? sname { get; set; }
        public string? major { get; set; }
        public string? standing { get; set; }
        public int age { get; set; }
        public int marks { get; set; }
       public IList<Course> coursses { get; set; }
    }
}
