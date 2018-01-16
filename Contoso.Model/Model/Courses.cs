using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Model.Model
{
    public class Courses : AuditableEntity
    {
        [StringLength(50, MinimumLength = 3)]
        public String Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }   //Foreign Key
        public Departments Department { get; set; }

        public ICollection<InstructorCourses> InstructorCourses { get; set; }
    }
}
