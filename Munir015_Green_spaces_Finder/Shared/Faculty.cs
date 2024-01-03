using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munir015_Green_spaces_Finder.Shared
{
    //Quiz Model
    public class Faculty
    {
        [Key]
        public int fid { get; set; }
        public string fname { get; set; }
        public string standing { get; set; }

        public IList<Course> courssses { get; set; }
    }
}
