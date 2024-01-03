using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munir015_Green_spaces_Finder.Shared
{

    //Quiz Model
    public class Course
    {
        [Key]
        public int cid { get; set; }

        public int marks { get; set; }

        public Faculty faculty { get; set; }

        public IList<Student> students { get; set; }   

    }
}
