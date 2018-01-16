using Contoso.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Model
{
    public class InstructorCourses : Entity
    {
        public Courses Courses { get; set; }
        public Instructor Instructor { get; set; }
        
    }
}
