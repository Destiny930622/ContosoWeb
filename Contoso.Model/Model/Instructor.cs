using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Model
{
    [Table("Instructor")]
    public class Instructor : People
    {
        public DateTime? HiretDate { get; set; }
        public ICollection<Departments> Departments { get; set; }

        public ICollection<InstructorCourses> InstructorCourses { get; set; }

    }
}
