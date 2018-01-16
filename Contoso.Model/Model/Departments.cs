using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model.Model
{
    public class Departments : AuditableEntity
    {
        public String Name { get; set; }
        public Decimal Budget { get; set; }
        public DateTime?  StartDate { get; set; }
        public int? InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int RowVersion { get; set; }

        public ICollection<Courses> Courses { get; set; }
    }
}
